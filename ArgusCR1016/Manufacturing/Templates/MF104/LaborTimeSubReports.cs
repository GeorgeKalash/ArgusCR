using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    public partial class LaborTimeSubReports : Reports.BaseReport
    {
        public BindingList<JobOrderView> data;
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
