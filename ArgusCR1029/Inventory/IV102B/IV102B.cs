using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory.IV102B
{
    public partial class IV102B : ArgusRPT.BaseReport
    {
        public IV102B()
        {
            InitializeComponent();
        }
        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(TransferSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Inventory.Reports.IV102> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV102>();

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");

            fromSiteRef_data.Text = webObject.record.header.fromSiteRef;
            fromSiteName_data.Text = webObject.record.header.fromSiteName;
            toSiteRef_data.Text = webObject.record.header.toSiteRef;
            toSiteName_data.Text = webObject.record.header.toSiteName;

            ((TransferSubReports)(TransferSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV102";
        }
    }
}