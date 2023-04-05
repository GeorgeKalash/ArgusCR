﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1031.Purchase.PU103
{
    public partial class MetalSubReports : ArgusRPT.BaseReport
    {
        public List<ArgusDS.Logistics.MetalSummary> data;

        public MetalSubReports()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)

        {
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
            return "CR1031.PU103";
        }
    }
}