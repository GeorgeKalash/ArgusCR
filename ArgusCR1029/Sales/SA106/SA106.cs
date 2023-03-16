using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1029.Sales.SA106
{
    public partial class SA106 : ArgusRPT.BaseReport
    {
        public SA106()
        {
            InitializeComponent();
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(InvoiceItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Sales.Reports.SA106> webObject = deserializeGet<ArgusDS.Sales.Reports.SA106>();

            logo_data.ImageUrl = companyInfo.logoUrl;
            dtName_data.Text = webObject.record.dtName;
            reference_data.Text = webObject.record.reference;
            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            clientRef_data.Text = webObject.record.clientRef;
            clientName_data.Text = webObject.record.clientName;

            siteRef_data.Text = webObject.record.siteRef;
            siteName_data.Text = webObject.record.siteName;
            currency_data.Text = webObject.record.currencyName;
            salesPerson_data.Text = webObject.record.spName;

            description_data.Text = webObject.record.description;

            subtotal_data.Text = webObject.record.subtotal.ToString("N2");
            vat_data.Text = webObject.record.vatAmount.ToString("N2");
            total_data.Text = webObject.record.amount.ToString("N2");

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.serials;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA106";
        }
    }
}