using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV412_L2 : ArgusRPT.BaseReport
    {
        public IV412_L2()
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

            fiscalYear_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            date_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            itemGrp_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            siteGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            ref_lbl.Text = labelText(3);
            ms_lbl.Text = labelText(4);
            qty_lbl.Text = labelText(5);
            cost_lbl.Text = labelText(6);
            total_lbl.Text = labelText(7);

            fiscalYear_lbl.Text = labelText(8);
            date_lbl.Text = labelText(9);
            siteParam_lbl.Text = labelText(10);
            item_lbl.Text = labelText(11);
            itemCategory_lbl.Text = labelText(12);
            itemGroup_lbl.Text = labelText(13);
            siteGroup_lbl.Text = labelText(14);
            production_lbl.Text = labelText(15);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV412_L2";
        }
    }
}