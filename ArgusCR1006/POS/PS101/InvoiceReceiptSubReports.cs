﻿using ArgusDS.Manufacturing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1006.POS.PS101
{
    public partial class InvoiceReceiptSubReports : Reports.BaseReport
    {
        public List<ArgusDS.PointOfSale.InvoiceReceiptView> data;

        public InvoiceReceiptSubReports()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            //total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);
            DataSource = data;
            base.OnBeforePrint(e);
        }

        private void InvoiceReceiptSubReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {


        }

        protected override void labelsText()
        {
            cashAccountRef_lbl.Text = labelText(0);

        }


        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101.IR";
        }

    }
}
