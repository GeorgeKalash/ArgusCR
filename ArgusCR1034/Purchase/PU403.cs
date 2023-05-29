using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1034.Purchase
{
    public partial class PU403 : ArgusRPT.BaseReport
    {
        public PU403()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Purchase.Reports.PU403> webObject = deserializeList<ArgusDS.Purchase.Reports.PU403>();
            DataSource = webObject.list;

            startDate_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;

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

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            vendorRef_lbl.Text = labelText(1);
            tdAmount_lbl.Text = labelText(2);
            tdAmount_lbl.Text = labelText(3);
            vatAmount_lbl.Text = labelText(4);
            amount_lbl.Text = labelText(5);

            startDate_lbl.Text = labelText(6);
            endDate_lbl.Text = labelText(7);
            vendor_lbl.Text = labelText(8);
        }

        protected override string dictionaryStore()
        {
            return "CR1034.PU403";
        }
    }
}