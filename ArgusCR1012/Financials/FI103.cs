using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1012.Financials
{
    public partial class FI103 : ArgusRPT.BaseReport
    {
        public FI103()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI110> obj = deserializeGet<ArgusDS.Financials.Reports.FI110>();

            functionName_data.Text = obj.record.functionName;
            documentType_data.Text = obj.record.dtName;
            reference_data.Text = obj.record.reference;
            plantName_data.Text = obj.record.plantName;
            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");
            accountRef_data.Text = obj.record.accountRef;
            accountName_data.Text = obj.record.accountName;
            currencyName_data.Text = obj.record.currencyName;
            subtotal_data.Text = obj.record.subtotal.ToString("N2");
            vatPct_data.Text = obj.record.vatPct.ToString();
            vatAmount_data.Text = obj.record.vatAmount.ToString("N2");
            isSubjectToVAT.Checked = obj.record.isSubjectToVAT == true;
            amount_data.Text = obj.record.amount.ToString("N2");
            notes_data.Text = obj.record.notes;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            documentType_lbl.Text = labelText(0);
            reference_lbl.Text = labelText(1);
            plantName_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            account_lbl.Text = labelText(4);
            currencyName_lbl.Text = labelText(5);
            subtotal_lbl.Text = labelText(6);
            vatPct_lbl.Text = labelText(7);
            vatAmount_lbl.Text = labelText(8);
            isSubjectToVAT_lbl.Text = labelText(9);
            amount_lbl.Text = labelText(10);
            notes_lbl.Text = labelText(11);
        }

        protected override string dictionaryStore()
        {
            return "CR1012.FI103";
        }
    }
}