﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1010.Sales
{
    public partial class SA51303 : ArgusRPT.BaseReport
    {
        public SA51303()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N0");
            tdPer_data.Text = webObject.record.trxHeader.tdPct.ToString();
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N0");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N0");

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1010.SA51303";
        }
    }
}