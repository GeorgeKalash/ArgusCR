using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Inventory
{
    public partial class IV01 : Reports.BaseReport
    {
        public IV01()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
           SharedClasses.JsonProtocol.QryStructure<Custom.CR1016.IV01> obj = deserializeList<Custom.CR1016.IV01>();
           DataSource = obj.list;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            itemRef_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            size_lbl.Text = labelText(3);

            form_lbl.Text = labelText(4);

            cost_lbl.Text = labelText(5);
            qty_lbl.Text = labelText(6);

            weight_lbl.Text = labelText(7);
            physicalQty_lbl.Text = labelText(8);

            physicalWeight_lbl.Text = labelText(9);

            diff_lbl.Text = labelText(10);
            notes_lbl.Text = labelText(11);
            physicalInventoryTitle_lbl.Text = labelText(12);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\IV01";
        }
    }
}
