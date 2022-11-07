using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1024.Purchase.Templates.PU103GLD
{
    public partial class PU103GLD : ArgusRPT.BaseReport
    {
        public PU103GLD()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return purchaseInvoice_lbl.Text;
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(InvoiceItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {   SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.InvoicePrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.InvoicePrintLayout>();

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            vendorRef_data.Text = webObject.record.header.vendorRef;
            vendorName_data.Text = webObject.record.header.vendorName;
            description_data.Text = webObject.record.header.description;

            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            currencyName_data.Text = webObject.record.header.currencyName;
            plantName_data.Text = webObject.record.header.plantName;
            pmName_data.Text = webObject.record.header.pmName;
            dueDate_data.Text = webObject.record.header.dueDate.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metals;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            purchaseInvoice_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            vendorRef_lbl.Text = labelText(3);
            vendorName_lbl.Text = labelText(4);

            date_lbl.Text = labelText(5);
            currencyName_lbl.Text = labelText(6);
            plantName_lbl.Text = labelText(7);
            pmName_lbl.Text = labelText(8);
            dueDate_lbl.Text = labelText(9);

            subtotal_lbl.Text = labelText(10);
            vatAmount_lbl.Text = labelText(11);
            amount_lbl.Text = labelText(12);
            description_lbl.Text = labelText(13);
        }

        protected override string dictionaryStore()
        {
            return "CR1024.PU103.GLD";
        }
    }
}