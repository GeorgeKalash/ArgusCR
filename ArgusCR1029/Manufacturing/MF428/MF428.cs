using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace ArgusCR1029.Manufacturing.MF428
{
    public partial class MF428 : ArgusRPT.BaseReport
    {
        public MF428()
        {
            InitializeComponent();
        }
        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(GeneralSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
           SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF428> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF428>();

            ((GeneralSubReports)(GeneralSubReports.ReportSource)).data = webObject.record.lineMetalSummary;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummary;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            workCenter_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;

            endDate2_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyInfoName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }

            printSignature.Text = reportSignature();

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.MF428";
        }
    }
}