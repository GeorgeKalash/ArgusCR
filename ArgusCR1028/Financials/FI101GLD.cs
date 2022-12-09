﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1028.Financials
{
    public partial class FI101GLD : ArgusRPT.BaseReport
    {
        public FI101GLD()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.ReceiptVoucherView> obj = deserializeGet<ArgusDS.Financials.ReceiptVoucherView>();

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyInfoName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }

            dtName_data.Text = obj.record.dtName;
            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");
            reference_data.Text = obj.record.reference;
            plantName_data.Text = obj.record.plantName;
            accountRef_data.Text = obj.record.accountRef;
            accountName_data.Text = obj.record.accountName;
            cashAccountRef_data.Text = obj.record.cashAccountRef;
            cashAccountName_data.Text = obj.record.cashAccountName;
            currencyName_data.Text = obj.record.currencyName;
            paymentMethodName_data.Text = obj.record.paymentMethodName;
            amount_data.Text = obj.record.amount.ToString("N2");
            notes_data.Text = obj.record.notes;
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)obj.record.amount, 4, 2);
            amountInWords_data.Text = string.Format("\"{0}\"", amountInWords_data.Text);
            segmentName_data.Text = obj.record.segmentName;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            receiptVoucher_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            plant_lbl.Text = labelText(4);
            account_lbl.Text = labelText(5);
            paymentMethod_lbl.Text = labelText(6);
            cashAccount_lbl.Text = labelText(7);
            currency_lbl.Text = labelText(8);      
            weight_lbl.Text = labelText(9);
            notes_lbl.Text = labelText(10);
            receiverSign_lbl.Text = labelText(11);
        }
        protected override string dictionaryStore()
        {
            return "CR1028.FI101GLD";
        }
    }
}