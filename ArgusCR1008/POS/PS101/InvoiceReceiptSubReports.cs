using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1008.POS.PS101
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
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1008\\PS101.IR";
        }
    }
}
