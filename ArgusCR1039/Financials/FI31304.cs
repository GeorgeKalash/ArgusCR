﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1039.Financials
{
    public partial class FI31304 : ArgusRPT.BaseReport
    {
        public FI31304()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI109> obj = deserializeGet<ArgusDS.Financials.Reports.FI109>();

            accountRef_data.Text = obj.record.accountRef;
            accountName_data.Text = obj.record.accountName;

            reference_data.Text = obj.record.reference;
            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");
            sp_data.Text = obj.record.spName;
            currencyRef_data.Text = obj.record.currencyRef;

            checkNo_data.Text = obj.record.checkNo;
            notes_data.Text = obj.record.notes;
            amount_data.Text = obj.record.amount.ToString("N2");
            amount2_data.Text = obj.record.amount.ToString("N2");


            if (obj.record.currencyProfileId != null)
                amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)obj.record.amount, obj.record.currencyProfileId, 2);

            amountInWords_data.Text = string.Format("\"{0}\"", amountInWords_data.Text);

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1039.FI102";
        }
    }
}