using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;


namespace ArgusCR120.Sales.SA103
{
    public partial class InvoiceItemsSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Sales.ItemView> data;

        public InvoiceItemsSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void InvoiceItemsSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR120.SA103";
        }
    }
}