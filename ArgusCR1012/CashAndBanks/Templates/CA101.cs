using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1012.CashAndBanks.Templates
{
    public partial class CA101 : ArgusRPT.BaseReport
    {
        public CA101()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Cash.Reports.CA101> obj = deserializeGet<ArgusDS.Cash.Reports.CA101>();

            dtName_data.Text = obj.record.dtName;
            reference_data.Text = obj.record.reference;
            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");
            currencyRef_data.Text = obj.record.currencyRef;
            fromCARef_data.Text = obj.record.fromCARef;
            toCARef_data.Text = obj.record.toCARef;
            fromCAName_data.Text = obj.record.fromCAName;
            toCAName_data.Text = obj.record.toCAName;
            amount_data.Text = obj.record.amount.ToString("N2");
            notes_data.Text = obj.record.notes;
            base.OnBeforePrint(e);

        }

        protected override void labelsText()
        {
            Transfers_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            currencyRef_lbl.Text = labelText(4);
            fromCAName_lbl.Text = labelText(5);
            toCAName_lbl.Text = labelText(6);
            amount_lbl.Text = labelText(7);
            notes_lbl.Text = labelText(8);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\CA101";
        }
    }
}

