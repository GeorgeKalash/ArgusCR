using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{ 
    public partial class IssueOfMaterialsSubReports : ArgusRPT.BaseReport
{
        public List<ArgusDS.Manufacturing.Reports.MF203> data;

        public IssueOfMaterialsSubReports()
        {
            InitializeComponent();
        }
  

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void IssueOfMaterialsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {

           
        }

        protected override void labelsText()
        {
            issueOfMaterials_lbl.Text = labelText(0);

            itemRef_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            qty_lbl.Text = labelText(3);
            pcs_lbl.Text = labelText(4);
            cost_lbl.Text = labelText(5);
            extendedCost_lbl.Text = labelText(6);
        }



        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF104.IM";
        }

    }
}

