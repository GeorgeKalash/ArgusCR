using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1024.Purchase.Templates.PU103GLD
{
    public partial class MetalSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Logistics.MetalSummary> data;

        public MetalSubReports()
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

        private void InvoiceReceiptSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
            metalPurity_lbl.Text = labelText(0);
            qty_lbl.Text = labelText(1);
        }

        protected override string dictionaryStore()
        {
            return "CR1024.PU103.MT.GLD";
        }
    }
}