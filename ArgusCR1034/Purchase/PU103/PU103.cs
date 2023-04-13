using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1034.Purchase.PU103
{
    public partial class PU103 : ArgusRPT.BaseReport
    {      
        public PU103()
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
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.InvoicePrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.InvoicePrintLayout>();

            logo_data.ImageUrl = companyInfo.logoUrl;

            companyName_data.Text = companyInfo.name;
            companyPhone_data.Text = companyInfo.address?.phone;
            companyStreet_data.Text = companyInfo.address?.street1;
            companyCity_data.Text = companyInfo.address?.city;
            companyVatNo_data.Text = companyInfo.taxNo;

            siteRef_data.Text = webObject.record.header.siteRef;
            siteName_data.Text = webObject.record.header.siteName;

            vendorRef_data.Text = webObject.record.header.vendorRef;
            vendorName_data.Text = webObject.record.header.vendorName;
            //address_data.Text = webObject.record.header.vendorAddress;
            //phone_data.Text = webObject.record.header.vendorPhone;

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            dueDate_data.Text = webObject.record.header.dueDate.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, 2);

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metals;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1034.PU103";
        }
    }
}