using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales.SA416b
{
    public partial class SA416b : ArgusRPT.BaseReport
    {      
        public SA416b()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(DetailSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(SummarySubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<Custom.CR1029.SA416b> webObject = deserializeGet<Custom.CR1029.SA416b>();

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            systemFunction_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            docType_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            clientGrp_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            salesPerson_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            reference_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;
            itemCollection_param.Text = Parameters.Count > 12 ? Parameters[12].Value.ToString() : string.Empty;
            productionLine_param.Text = Parameters.Count > 13 ? Parameters[13].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();

            ((DetailSubReports)(DetailSubReports.ReportSource)).data = webObject.record.items;
            ((SummarySubReports)(SummarySubReports.ReportSource)).data = webObject.record.summary;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA416b";
        }
    }
}