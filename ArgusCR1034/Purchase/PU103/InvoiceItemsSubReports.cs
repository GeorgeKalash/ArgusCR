using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1034.Purchase.PU103
{
    public partial class InvoiceItemsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Purchase.InvoiceItemView> data;
        int itemsCounter = 1;

        public InvoiceItemsSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void InvoiceItemsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            seqNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override string dictionaryStore()
        {
            return "CR1034.PU103";
        }
    }
}