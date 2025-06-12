using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI102 : ArgusRPT.BaseReport
    {
        public FI102()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI102> obj = deserializeGet<ArgusDS.Financials.Reports.FI102>();

            logo_data.ImageUrl = companyInfo.logoUrl;

            dtName_data.Text = obj.record.header.dtName;
            date_data.Text = obj.record.header.date.ToString("dd/MM/yyyy");
            reference_data.Text = obj.record.header.reference;
            plantName_data.Text = obj.record.header.plantName;
            accountRef_data.Text = obj.record.header.accountRef;
            accountName_data.Text = obj.record.header.accountName;
            cashAccountRef_data.Text = obj.record.header.cashAccountRef;
            cashAccountName_data.Text = obj.record.header.cashAccountName;
            currencyName_data.Text = obj.record.header.currencyName;
            paymentMethodName_data.Text = obj.record.header.paymentMethodName;
            amount_data.Text = obj.record.header.amount.ToString("N2");
            notes_data.Text = obj.record.header.notes;
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)obj.record.header.amount, 10, 2);
            amountInWords_data.Text = string.Format("\"{0}\"", amountInWords_data.Text);

            //   segmentName_data.Text = obj.record.header.segmentName;
            createdName_data.Text = obj.record.header.userName;
            createdDate_data.Text = obj.record.header.createdDate.ToString();

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
            amount_lbl.Text = labelText(9);
            amountInWords_lbl.Text = labelText(10);
            notes_lbl.Text = labelText(11);

            receiverSign_lbl.Text = labelText(12);
            payerSignature_lbl.Text = labelText(13);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI102";
        }
    }
}