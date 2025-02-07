using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing
{
    public partial class MF416 : ArgusRPT.BaseReport
    {
        public MF416()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure <ArgusDS._1029.MF416> webObject = deserializeList<ArgusDS._1029.MF416>();
            DataSource = webObject.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            productionLine_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            design_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;

            productionClass_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            productionStandard_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            collection_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            brand_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            colorStone_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;
            stone_param.Text = Parameters.Count > 12 ? Parameters[12].Value.ToString() : string.Empty;
            status_param.Text = Parameters.Count > 13 ? Parameters[13].Value.ToString() : string.Empty;

            jobStartedFrom_param.Text = Parameters.Count > 14 ? Parameters[14].Value.ToString() : string.Empty;
            jobStartedTo_param.Text = Parameters.Count > 15 ? Parameters[15].Value.ToString() : string.Empty;
            workCenter_param.Text = Parameters.Count > 16 ? Parameters[16].Value.ToString() : string.Empty;

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
        }
        protected override string dictionaryStore()
        {
            return "CR1029.MF416";
        }
    }
}