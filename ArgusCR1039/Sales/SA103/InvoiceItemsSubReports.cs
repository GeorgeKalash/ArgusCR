﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1039.Sales.SA103
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

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            ArgusDS.Sales.ItemView obj = ((List<ArgusDS.Sales.ItemView>)DataSource)[e.CurrentRow];

            decimal netUnitPrice = obj.unitPrice - (obj.mdValue ?? 0);
            decimal epWithVAT = obj.extendedPrice + obj.vatAmount;

            unitPrice_data.Text = netUnitPrice.ToString("N2");
            extendedPriceWithVAT_data.Text = epWithVAT.ToString("N2");
            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1039.SA103";
        }
    }
}