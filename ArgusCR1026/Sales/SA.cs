using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1026.Sales
{
    public partial class SA : ArgusRPT.BaseReport
    {
        public SA()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
           // SharedClasses.JsonProtocol.QryStructure<SummarySalesBySalesPerson> obj = deserializeList<SummarySalesBySalesPerson>();
          //  DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;

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
            reportTitle_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            pcs_lbl.Text = labelText(3);
            weight_lbl.Text = labelText(4);
            amount_lbl.Text = labelText(5);

            startDate_lbl.Text = labelText(6);
            endDate_lbl.Text = labelText(7);
        }

        protected override string dictionaryStore()
        {
            return "SA405";
        }
    }
}