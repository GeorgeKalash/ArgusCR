using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Purchase.Templates
{
    public partial class PU103 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public PU103()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.InvoicePrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.InvoicePrintLayout>();
            DataSource = webObject.record.items;

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

            puRef_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vat_data.Text = webObject.record.header.vatAmount.ToString("N2");
            netAmount_data.Text = webObject.record.header.amount.ToString("N2");

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {

        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
            
        }
        protected override string dictionaryStore()
        {
            return "CR1029.PU103";
        }



    }
}