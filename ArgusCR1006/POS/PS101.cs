using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1006.POS
{
    public partial class PS101 : Reports.BaseReport
    {
        public PS101()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {


        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101";
        }

    }
}