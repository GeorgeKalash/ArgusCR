using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
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
            weight_data.Text = labelText(8);
            salePrice_lbl.Text = labelText(9);
            vatAmount_lbl.Text = labelText(10);
            priceGroupRef_lbl.Text = labelText(11);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV01";
        }
    }
}
