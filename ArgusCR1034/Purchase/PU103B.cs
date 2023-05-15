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

            //SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.>();

            //logo_data.ImageUrl = webObject.record.companyInfo.logoUrl;
            //companyName_data.Text = webObject.record.companyInfo.name;
            //companyVatNo_data.Text = webObject.record.companyInfo.taxNo;

            //if (webObject.record.address != null)
            //{
            //    clientName_data.Text = webObject.record.address.name;
            //    clientReference_data.Text = webObject.record.?
            //    date_data.Text = webObject.record.address.street1;
            //}

            //amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);
            //desc_data.Text = 

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
