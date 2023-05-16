using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1034.Purchase
{
    public partial class PU103B : ArgusRPT.BaseReport
    {
        public PU103B()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.InvoicePrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.InvoicePrintLayout>();
            DataSource = webObject.record.items;
            logo_data.ImageUrl = companyInfo.logoUrl;
            companyName_data.Text = companyInfo.name;
            companyVatNo_data.Text = companyInfo.taxNo;

            reference_data.Text = webObject.record.header.reference;
            vendorRef_data.Text = webObject.record.header.vendorRef;
            vendorName_data.Text = webObject.record.header.vendorName;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, 2);
                 
            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1034.PU103B";
        }
    }
}
