using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1012.Financials
{
    public partial class FI101 : Reports.BaseReport
    {
        public FI101()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.ReceiptVoucherView> obj = deserializeGet<ArgusDS.Financials.ReceiptVoucherView>();
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

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            receiptVoucher_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            plant_lbl.Text = labelText(4);
            account_lbl.Text = labelText(5);
            cashAccount_lbl.Text = labelText(6);
            currency_lbl.Text = labelText(7);
            paymentMethod_lbl.Text = labelText(8);
            amount_lbl.Text = labelText(9);
            notes_lbl.Text = labelText(10);
        }
        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\FI101";
        }

    }
}
