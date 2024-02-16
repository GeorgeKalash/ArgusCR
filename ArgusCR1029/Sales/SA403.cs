using System.Collections.Generic;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.Sales
{
    public partial class SA403 : ArgusRPT.BaseReport
    {
        public SA403()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<SummarySalesByItem> obj = deserializeList<SummarySalesByItem>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;


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

            startDate_lbl.Text = labelText(1);
            endDate_lbl.Text = labelText(2);
            plant_lbl.Text = labelText(3);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA403";
        }
    }
}