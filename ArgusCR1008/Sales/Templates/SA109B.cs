using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SA109B : ArgusRPT.BaseReport
    {
        public SA109B()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SATRX02";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Delivery.Reports.DE103> webObject = deserializeList<ArgusDS.Delivery.Reports.DE103>();
            DataSource = webObject.list;

            base.OnBeforePrint(e);
        }

        private void XrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = Math.Ceiling(Convert.ToDecimal((sender as XRLabel).Value)).ToString();
        }
    }
}