using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV411_L1 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV411_L1()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV403> webObject = deserializeList<ArgusDS.Inventory.Reports.IV403>();
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

            rec_lbl.Text = labelText(1);
            sku_lbl.Text = labelText(2);
            name_lbl.Text = labelText(3);
            ms_lbl.Text = labelText(4);
            itemGrp_lbl.Text = labelText(5);
            itemCategoryy_lbl.Text = labelText(6);
            site_lbl.Text = labelText(7);
            qty_lbl.Text = labelText(8);
            cost_lbl.Text = labelText(9);
            total_lbl.Text = labelText(10);

            item_lbl.Text = labelText(11);
            asOfDate_lbl.Text = labelText(12);
            site_lbl.Text = labelText(13);
            itemCategory_lbl.Text = labelText(14);

            itemGroup_lbl.Text = labelText(15);
            fromSiteGroup_lbl.Text = labelText(16);
            toSiteGroup_lbl.Text = labelText(17);
            productionLine_lbl.Text = labelText(18);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV411_L1";
        }
    }
}