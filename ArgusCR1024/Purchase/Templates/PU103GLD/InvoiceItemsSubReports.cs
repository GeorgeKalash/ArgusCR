using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1024.Purchase.Templates.PU103GLD
{
    public partial class InvoiceItemsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Purchase.InvoiceItemView> data;

        public InvoiceItemsSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;

            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void InvoiceItemsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
            sku_lbl.Text = labelText(0);
            itemName_lbl.Text = labelText(1);
            qty_lbl.Text = labelText(2);
            weight_lbl.Text = labelText(3);
            unitPrice_lbl.Text = labelText(4);
            vtAmount_lbl.Text = labelText(5);
            mdAmount_lbl.Text = labelText(6);
            extendedPrice_lbl.Text = labelText(7);
            notes_lbl.Text = labelText(8);

            TotalQuantity_lbl.Text = labelText(9);
        }

        protected override string dictionaryStore()
        {
            return "CR1024.PU103.II.GLD";
        }
    }
}