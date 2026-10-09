using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing.MF428
{
    public partial class MetalSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Manufacturing.Reports.MF428Line> data;

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
        }
        protected override string dictionaryStore()
        {
            return "MF428";
        }
    }
}