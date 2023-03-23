using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1029.Inventory.IV107
{
    public partial class IV107 : ArgusRPT.BaseReport
    {
        public IV107()
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
            ((ArgusRPT.BaseReport)(TransferSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure <ArgusDS.Inventory.Reports.IV107> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV107>();

            logo_data.ImageUrl = companyInfo.logoUrl;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");

            fromSiteRef_data.Text = webObject.record.header.fromSiteRef;
            fromSiteName_data.Text = webObject.record.header.fromSiteName;
            toSiteRef_data.Text = webObject.record.header.toSiteRef;
            toSiteName_data.Text = webObject.record.header.toSiteName;

            notifyName_data.Text = webObject.record.header.notifyName;

            totalWeightG21_data.Text = webObject.record.header.totalWeightG21.ToString("N2");
            sumSalesPrice_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.sumSalesPrice, 4, 2);
            notes_data.Text = webObject.record.header.notes;

            printSignature_lbl.Text = reportSignature();

            ((TransferSubReports)(TransferSubReports.ReportSource)).data = webObject.record.serials;
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV107";
        }
    }
}