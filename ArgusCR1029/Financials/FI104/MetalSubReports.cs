using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials.FI104
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
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void MetalSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
            metal_lbl.Text = labelText(0);
            weight_lbl.Text = labelText(1);
            laborPrice_lbl.Text = labelText(2);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI104.MT";
        }
    }
}