using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;


namespace ArgusCR1012.Financials
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
            DataSource = obj.record.items;

            dtName_data.Text = obj.record.header.dtName;
            accountRef_data.Text = obj.record.header.accountRef;
            accountName_data.Text = obj.record.header.accountName;
            paymentMethodName_data.Text = obj.record.header.paymentMethodName;
            currencyRef_data.Text = obj.record.header.currencyRef;
            amount_data.Text = obj.record.header.amount.ToString("N2");
            plantName_data.Text = obj.record.header.plantName;

            reference_data.Text = obj.record.header.reference;
            date_data.Text = obj.record.header.date.ToString("dd/MM/yyyy");
            cashAccountRef_data.Text = obj.record.header.cashAccountRef;
            cashAccountName_data.Text = obj.record.header.cashAccountName;
            checkNo_data.Text = obj.record.header.checkNo;
            notes_data.Text = obj.record.header.notes;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            paymentVoucher_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            accountRef_lbl.Text = labelText(2);
            accountName_lbl.Text = labelText(3);
            paymentMethodName_lbl.Text = labelText(4);
            currencyRef_lbl.Text = labelText(5);
            amount_lbl.Text = labelText(6);
            plantName_lbl.Text = labelText(7);

            reference_lbl.Text = labelText(8);
            date_lbl.Text = labelText(9);
            cashAccountRef_lbl.Text = labelText(10);
            cashAccountName_lbl.Text = labelText(11);
            checkNo_lbl.Text = labelText(12);
            notes_lbl.Text = labelText(13);

            etRef_lbl.Text = labelText(14);
            etName_lbl.Text = labelText(15);
            subtotal_lbl.Text = labelText(16);
            vatAmount_lbl.Text = labelText(17);
            amounts_lbl.Text = labelText(18);
            supplierName_lbl.Text = labelText(19);
            taxRef_lbl.Text = labelText(20);
            note_lbl.Text = labelText(21);
        }

        protected override string dictionaryStore()
        {
            return "CR1012.FI102";
        }
    }
}