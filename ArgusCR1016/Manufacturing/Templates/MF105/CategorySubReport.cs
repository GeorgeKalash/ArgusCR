using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    public partial class CategorySubReport : Reports.BaseReport
    {
        public List<ArgusDS.Manufacturing.Reports.MF105c> data;

        public static BaseReport ReportSource { get; internal set; }

        public CategorySubReport()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void CategorySubReport_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {


        }

        protected override void labelsText()
        {
            itemCategoryRef_lbl.Text = labelText(0);
            itemCategoryName_lbl.Text = labelText(1);
            nbOfStones_lbl.Text = labelText(2);
            weight_lbl.Text = labelText(3);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF105.CA";
        }

    }
}