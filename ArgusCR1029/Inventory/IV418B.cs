using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV418B : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV418B()
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
            sku_lbl.Text = labelText(2);
            name_lbl.Text = labelText(3);
            qty_lbl.Text = labelText(4);
            avgCost_lbl.Text = labelText(5);
            totalCost_lbl.Text = labelText(6);

            fromSite_lbl.Text = labelText(7);
            startDate_lbl.Text = labelText(8);
            endDate_lbl.Text = labelText(9);
            item_lbl.Text = labelText(10);
            itemCategory_lbl.Text = labelText(11);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV418B";
        }
    }
}