using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    public partial class OverheadsSubReport : Reports.BaseReport
    {
        public BindingList<JobOverheadView> data;
        public OverheadsSubReport()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void OverheadsSubReport_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {


        }

        protected override void labelsText()
        {
            overheads_lbl.Text = labelText(0);

            itemRef_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            qty_lbl.Text = labelText(3);
            cost_lbl.Text = labelText(4);
            extendedCost_lbl.Text = labelText(5);
        }

        protected override string dictionaryStore()
        {
            return "MF104.OH";
        }

    }
}
