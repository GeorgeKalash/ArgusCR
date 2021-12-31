using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1016.Sales.Templates
{
    public partial class SAORD01 : Reports.BaseReport
    {
        public SAORD01()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();
            DataSource = webObject.record.items;

            

            base.OnBeforePrint(e);
        }


  

        protected override void labelsText()
        {
   

        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\SA101";
        }
    }
}
