using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.CurrencyTrading.CT35401
{
    public partial class ReceiptsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusCT_DS.Trading.CashInvoice.CashInvoiceReceipt> data;

        public ReceiptsSubReports()
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

        protected override string dictionaryStore()
        {
            return "CR1003.CT35401T1";
        }
    }
}