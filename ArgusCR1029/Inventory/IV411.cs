using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV411 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV411()
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

            //startDate_param.Text = Parameters.Count >  ? Parameters[].Value.ToString() : string.Empty;
            //endDate_param.Text = Parameters.Count >  ? Parameters[].Value.ToString() : string.Empty;
            //siteParam_param.Text = Parameters.Count >  ? Parameters[].Value.ToString() : string.Empty;

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

            startDate_lbl.Text = labelText(11);
            endDate_lbl.Text = labelText(12);
            siteParam_lbl.Text = labelText(13);

        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV411";
        }
    }
}