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
    public partial class IssueOfMaterialsSubReport : Reports.BaseReport
    {
        public List<ArgusDS.Manufacturing.Reports.MF105b> data;

        public static BaseReport ReportSource { get; internal set; }

        public IssueOfMaterialsSubReport()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void IssueOfMaterialsSubReport_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {


        }

        protected override void labelsText()
        {
           
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF105.IM";
        }

    }
}
