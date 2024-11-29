using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV01 : ArgusRPT.BaseReport
    {
        public IV01()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.IV01> obj = deserializeList<Custom.CR1029.IV01>();
            DataSource = obj.list;

            itemCategory_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            ms_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            categoryRef_lbl.Text = labelText(3);
            groupRef_lbl.Text = labelText(4);
            lineRef_lbl.Text = labelText(5);
            msRef_lbl.Text = labelText(6);
            stdCost_lbl.Text = labelText(7);
            salePrice_lbl.Text = labelText(8);
            priceGroupRef_lbl.Text = labelText(9);

            itemCategory_lbl.Text = labelText(10);
            itemGroup_lbl.Text = labelText(11);
            ms_lbl.Text = labelText(12);
            production_lbl.Text = labelText(13);
            collection_lbl.Text = labelText(14);
            createdDate_lbl.Text = labelText(15);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV01";
        }
    }
}