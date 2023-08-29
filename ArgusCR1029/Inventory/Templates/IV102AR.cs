using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory.Templates
{
    public partial class IV102AR : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV102AR()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Inventory.Reports.IV102> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV102>();
            base.OnBeforePrint(e);
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

            invRef_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");

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
            return "CR1029.IV102AR";
        }



    }
}