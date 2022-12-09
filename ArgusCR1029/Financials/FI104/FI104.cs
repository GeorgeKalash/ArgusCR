using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1029.Financials.FI104
{
    public partial class FI104 : ArgusRPT.BaseReport
    {
        public FI104()
        {
            InitializeComponent();
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(ItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
           SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI103> webObject = deserializeGet<ArgusDS.Financials.Reports.FI103>();

            ((ItemsSubReports)(ItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;

            dtName_data.Text = webObject.record.header.dtName;
            function_data.Text = webObject.record.header.functionName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");

            plantRef_data.Text = webObject.record.header.plantRef;
            plantName_data.Text = webObject.record.header.plantName;
            siteRef_data.Text = webObject.record.header.siteRef;
            siteName_data.Text = webObject.record.header.siteName;
            accountRef_data.Text = webObject.record.header.accountRef;
            accountName_data.Text = webObject.record.header.accountName;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            metalTransactions_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            function_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);
            site_lbl.Text = labelText(6);
            account_lbl.Text = labelText(7);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI104";
        }
    }
}