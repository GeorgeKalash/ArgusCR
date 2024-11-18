using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1004.Sales.SA103B
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
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void MetalSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1004.SA103";
        }
    }
}