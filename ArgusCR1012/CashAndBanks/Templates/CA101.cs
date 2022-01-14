using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1012.CashAndBanks.Templates
{
    public partial class CA101 : Reports.BaseReport
    {
        public CA101()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Cash.Reports.CA101> webObject = deserializeGet<ArgusDS.Cash.Reports.CA101>();
            DataSource = webObject.record;


            base.OnBeforePrint(e);

        }

        protected override void labelsText()
        {
          
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\CA101";
        }
    }
}

