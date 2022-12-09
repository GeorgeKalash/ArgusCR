using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials.FI104
{
    public partial class ItemsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Financials.MetalItemView> data;

        public ItemsSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void ItemsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }


        protected override void labelsText()
        {
            metal_lbl.Text = labelText(0);
            sku_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            purity_lbl.Text = labelText(3);
            qty_lbl.Text = labelText(4);
            labor_lbl.Text = labelText(5);
            totalLabor_lbl.Text = labelText(6);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI104.IT";
        }
    }
}