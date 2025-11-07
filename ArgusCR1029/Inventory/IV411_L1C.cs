using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV411_L1C : ArgusRPT.BaseReport
    {
        public IV411_L1C()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.IV403_L1> webObject = deserializeList<Custom.CR1029.IV403_L1>();
            DataSource = webObject.list;
            crossTab.DataSource = webObject.list;

            item_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            date_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            itemGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            fromSiteGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            toSiteGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV411_L1C";
        }
    }
}