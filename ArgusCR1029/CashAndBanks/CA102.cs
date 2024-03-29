﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.CashAndBanks
{
    public partial class CA102 : ArgusRPT.BaseReport
    {
        public CA102()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Cash.Reports.CA102> obj = deserializeGet<ArgusDS.Cash.Reports.CA102>();

            logo_data.ImageUrl = companyInfo.logoUrl;

            title_data.Text = obj.record.functionName;
            dtName_data.Text = obj.record.dtName;
            reference_data.Text = obj.record.reference;
            plant_data.Text = obj.record.plantName;
            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");
            currency_data.Text = obj.record.currencyName;
            CARef_data.Text = obj.record.accountRef;
            CAName_data.Text = obj.record.accountName;
            amount_data.Text = obj.record.amount.ToString("N2");
            notes_data.Text = obj.record.notes;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            dtName_lbl.Text = labelText(0);
            reference_lbl.Text = labelText(1);
            plant_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            currency_lbl.Text = labelText(4);
            CAName_lbl.Text = labelText(5);
            amount_lbl.Text = labelText(6);
            note_lbl.Text = labelText(7);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.CA102";
        }
    }
}