using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1004.POS.PS102
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
            return "CR1004.PS101.IR";
        }
    }
}