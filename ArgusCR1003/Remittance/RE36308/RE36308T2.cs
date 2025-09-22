using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36308
{
    public partial class RE36308T2 : ArgusRPT.BaseReport
    {
        public RE36308T2()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT105> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT105>();

 

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36308T2";
        }

    }
}