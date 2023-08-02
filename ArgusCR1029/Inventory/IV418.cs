using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV418 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV418()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV418> webObject = deserializeList<ArgusDS.Inventory.Reports.IV418>();
            DataSource = webObject.list;

            fromSite_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
           
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            rec_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            sku_lbl.Text = labelText(3);
            name_lbl.Text = labelText(4);
            ms_lbl.Text = labelText(5);
            site_lbl.Text = labelText(6);
            itemGrp_lbl.Text = labelText(7);
            itemCategoryy_lbl.Text = labelText(8);
            ref_lbl.Text = labelText(9);
            functionName_lbl.Text = labelText(10);
            qty_lbl.Text = labelText(11);
            avgCost_lbl.Text = labelText(12);
            totalCost_lbl.Text = labelText(13);

            fromSite_lbl.Text = labelText(14);
            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            item_lbl.Text = labelText(17);
            itemCategory_lbl.Text = labelText(18);

            plant_lbl.Text = labelText(19);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV418";
        }
    }
}