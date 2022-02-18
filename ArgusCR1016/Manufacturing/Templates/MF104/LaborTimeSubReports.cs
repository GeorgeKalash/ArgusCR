using ArgusDS.Manufacturing;
using ArgusDS.Manufacturing.Reports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    public partial class LaborTimeSubReports : Reports.BaseReport
    {
        public List<MF104_TimeUnit> data;
        public LaborTimeSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void LaborTimeSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {


        }

        protected override void labelsText()
        {
            realTimeElapsed_lbl.Text = labelText(0);
        }


        protected override string dictionaryStore()
        {
            return "MF104.LT";
        }
    }
}
