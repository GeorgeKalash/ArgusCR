using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace ArgusRPT
{
    public class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        public struct ReportHeaders
        {
            public string accountId, userName, languageId, dateFormat;
        }

        readonly string package;
        protected ReportHeaders sessionInfo;
        protected string jsonData;
        private Dictionary<string, string> labels;

        public BaseReport() : base()
        {
            sessionInfo = new ReportHeaders();
        }

        public BaseReport(string _package) : this()
        {
            package = _package;
        }

        protected virtual string dictionaryStore() { return null;  }

        protected virtual void labelsText() { }

        protected virtual void initSubReports()
        {

        }
        public void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            sessionInfo = new ReportHeaders()
            {
                accountId = _reportHeaders["accountId"],
                languageId = _reportHeaders["languageId"],
                userName = _reportHeaders["userName"],
                dateFormat = _reportHeaders["dateFormat"]
            };

            if (sessionInfo.languageId == ((short)SharedClasses.Language.ARABIC).ToString())
            {
                RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            }

            initSubReports();
        }

        public void setSessionInfo(ReportHeaders _sessionInfo)
        {
            sessionInfo = _sessionInfo;
        }

        public void setParams(Dictionary<string, string> _parameters)
        {
            foreach (KeyValuePair<string, string> kv in _parameters)
            {
                this.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Name = kv.Key, Value = kv.Value });
            }
        }

        public void setReportData(string _jsonBody)
        {
            jsonData = _jsonBody;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            loadLablesDict();
            base.OnBeforePrint(e);
        }

        private void loadLablesDict()
        {
            string path = ConfigurationManager.AppSettings["reports-labels-folder"] + dictionaryStore() + ".xml";
            labels = SharedClasses.XMLTools.loadDict(path, "L" + sessionInfo.languageId);
            labelsText();
        }

        protected string labelText(int idx)
        {
            return labels[idx.ToString()];
        }

        public string companyLogoUrl
        {
            get
            {
                return string.Format("https://s3-eu-west-1.amazonaws.com/{0}/20203/{1}/1-0.png", package, sessionInfo.accountId);
            }
        }

        public SharedClasses.JsonProtocol.QryStructure<T> deserializeList<T>()
        {
            SharedClasses.JsonProtocol.QryStructure<T> obj;
            SharedClasses.JsonProtocol.StatusCheck status;
            try
            {
                status = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.StatusCheck>(jsonData);
            }
            catch
            {
                throw new Exception("JSON_FORMAT_EXCEPTION: " + jsonData);
            }

            if (status.statusId < 0)
            {
                SharedClasses.JsonProtocol.ErrorStructure errorObj = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.ErrorStructure>(jsonData);
                throw new Exception(errorObj.statusId.ToString() + ": " + errorObj.error);
            }
            try
            {
                obj = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.QryStructure<T>>(jsonData);
            }
            catch
            {
                throw new Exception("JSON_FORMAT_EXCEPTION: " + jsonData);
            }
            return obj;
        }

        public SharedClasses.JsonProtocol.GetStructure<T> deserializeGet<T>()
        {
            SharedClasses.JsonProtocol.GetStructure<T> obj;
            SharedClasses.JsonProtocol.StatusCheck status;
            try
            {
                status = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.StatusCheck>(jsonData);
            }
            catch
            {
                throw new Exception("JSON_FORMAT_EXCEPTION: " + jsonData);
            }

            if (status.statusId < 0)
            {
                SharedClasses.JsonProtocol.ErrorStructure errorObj = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.ErrorStructure>(jsonData);
                throw new Exception(errorObj.statusId.ToString() + ": " + errorObj.error);
            }
            try
            {
                obj = JsonConvert.DeserializeObject<SharedClasses.JsonProtocol.GetStructure<T>>(jsonData);
            }
            catch
            {
                throw new Exception("JSON_FORMAT_EXCEPTION: " + jsonData);
            }
            return obj;
        }
    }
}


