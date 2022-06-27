using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR112.POS.PS101
{
    public partial class InvoiceItemsSubReports : Reports.BaseReport
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

        }

        protected override string dictionaryStore()
        {
            return "Custom\\R112\\PS101.II";
        }
    }
}


