using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1006.POS.PS101
{
    public partial class InvoiceItemsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.PointOfSale.Reports.PS101_item> data;

        public InvoiceItemsSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;


            base.OnBeforePrint(e);
        }

        private void InvoiceItemsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {

        }

        protected override void labelsText()
        {
            itemRef_lbl.Text = labelText(0);
            description_lbl.Text = labelText(1);
            purity_lbl.Text = labelText(2);
            wGold_lbl.Text = labelText(3);
            qty_lbl.Text = labelText(4);
            unitPrice_lbl.Text = labelText(5);
            extendedPrice_lbl.Text = labelText(6);
            vat_lbl.Text = labelText(7);
            totalPrice_lbl.Text = labelText(8);

            subTotal_lbl.Text = labelText(9);

            subtotal2_lbl.Text = labelText(10);
            vatAmount_lbl.Text = labelText(11);
            amount_lbl.Text = labelText(12);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101.II";
        }
    }
}


