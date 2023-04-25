using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA500 : ArgusRPT.BaseReport
    {
        public SA500()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Sales.Reports.SA500> obj = deserializeList<ArgusDS.Sales.Reports.SA500>();
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

            zoneRef_lbl.Text = labelText(1);
            zoneName_lbl.Text = labelText(2);
            clientCount_lbl.Text = labelText(3);
            g18_lbl.Text = labelText(4);
            qty18_lbl.Text = labelText(5);
            egp18_lbl.Text = labelText(6);
            g21_lbl.Text = labelText(7);
            qty21_lbl.Text = labelText(8);
            egp21_lbl.Text = labelText(9);
            laborPrice_lbl.Text = labelText(10);
            amount_lbl.Text = labelText(11);
            vatAmount_lbl.Text = labelText(12);
            netAmount_lbl.Text = labelText(13);
            avg_lbl.Text = labelText(14);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA500";
        }
    }
}