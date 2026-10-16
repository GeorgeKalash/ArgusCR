using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing.MF415
{
    public partial class GrandTotalSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS._1029.MF415a> data;

        public GrandTotalSubReports()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)

        {
            DataSource = data;
            base.OnBeforePrint(e);
        }
        private void GrandTotalSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.MF415";
        }
    }
}