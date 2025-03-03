﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Financials.FI31305
{
    public partial class FI31305T1 : ArgusRPT.BaseReport
    {
        public FI31305T1()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI102> webObject = deserializeGet<ArgusDS.Financials.Reports.FI102>();
              dateTop_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy"); ;
                
              refNo_data.Text = webObject.record.header.reference;
              branch_data.Text = webObject.record.header.plantName;
                
              sar_data.Text = webObject.record.header.baseAmount.ToString();
              checkNo_data.Text = webObject.record.header.checkNo;
              payTo_data.Text = webObject.record.header.cashAccountName;
              date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");
              bank_data.Text = webObject.record.header.bankAccountName;
              qrCode.Text = webObject.record.header.reference; ;
              recieptName_data.Text = webObject.record.header.accountRef;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.FI31305T1";
        }
    }
}