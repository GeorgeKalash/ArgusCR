using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA420 : ArgusRPT.BaseReport
    {
        public SA420()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA422> obj = deserializeList<Custom.CR1029.SA422>();
            DataSource = obj.list;

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
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            itemGroup_lbl.Text = labelText(1);
            qty18_lbl.Text = labelText(2);
            qty21_lbl.Text = labelText(3);
            laborPrice_lbl.Text = labelText(4);
            vatAmount_lbl.Text = labelText(5);
            discountAmount_lbl.Text = labelText(6);
            netAmount_lbl.Text = labelText(7);
            avgDiscount_lbl.Text = labelText(8);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA420";
        }
    }
}