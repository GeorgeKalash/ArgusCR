﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1034.POS.Templates.PS101B
{
    public partial class InvoiceReceiptSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.PointOfSale.InvoiceReceiptView> data;

        public InvoiceReceiptSubReports()
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

        private void InvoiceReceiptSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {

        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1034.PS101";
        }
    }
}