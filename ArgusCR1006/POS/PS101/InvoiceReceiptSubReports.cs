using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1006.POS.PS101
{
    public partial class InvoiceReceiptSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.PointOfSale.InvoiceReceiptView> data;

        public InvoiceReceiptSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void InvoiceReceiptSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {

        }

        protected override void labelsText()
        {
            cashAccountRef_lbl.Text = labelText(0);
            currencyRef_lbl.Text = labelText(1);
            typeName_lbl.Text = labelText(2);
            ccRef_lbl.Text = labelText(3);
            cardType_lbl.Text = labelText(4);
            Amount_lbl.Text = labelText(5);
            explanation_lbl.Text = labelText(6);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101.IR";
        }
    }
}
