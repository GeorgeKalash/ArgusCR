using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    public partial class IssueOfMaterialsSubReport : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Manufacturing.Reports.MF105b> data;

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
            issued_lbl.Text = labelText(0);
            returned_lbl.Text = labelText(1);
            lost_lbl.Text = labelText(2);

            itemRef_lbl.Text = labelText(3);
            description_lbl.Text = labelText(4);
            shape_lbl.Text = labelText(5);
            size_lbl.Text = labelText(6);
            cost_lbl.Text = labelText(7);

            nbOfStones1_lbl.Text = labelText(8);
            weight1_lbl.Text = labelText(9);

            nbOfStones2_lbl.Text = labelText(10);
            weight2_lbl.Text = labelText(11);

            nbOfStones3_lbl.Text = labelText(12);
            weight3_lbl.Text = labelText(13);

            Signature_lbl.Text = labelText(14);
         }

        protected override string dictionaryStore()
        {
            return "CR1016.MF105.IM";
        }
    }
}
