using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV412_L1 : ArgusRPT.BaseReport
    {
        public IV412_L1()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV408> webObject = deserializeList<ArgusDS.Inventory.Reports.IV408>();
            DataSource = webObject.list;

            item_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            asOfDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            itemGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            fromSiteGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            toSiteGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            productionLine_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            ref_lbl.Text = labelText(1);
            ms_lbl.Text = labelText(2);
            qty_lbl.Text = labelText(3);
            cost_lbl.Text = labelText(4);
            total_lbl.Text = labelText(5);

            item_lbl.Text = labelText(6);
            asOfDate_lbl.Text = labelText(7);
            site_lbl.Text = labelText(8);
            itemCategory_lbl.Text = labelText(9);

            itemGroup_lbl.Text = labelText(10);
            fromSiteGroup_lbl.Text = labelText(11);
            toSiteGroup_lbl.Text = labelText(12);
            productionLine_lbl.Text = labelText(13);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV412_L1";
        }
    }
}