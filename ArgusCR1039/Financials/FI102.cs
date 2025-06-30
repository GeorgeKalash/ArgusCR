using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1039.Financials
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
          //  DataSource = obj.record.items;
            accountRef_data.Text = obj.record.header.accountRef;
            accountName_data.Text = obj.record.header.accountName;

            reference_data.Text = obj.record.header.reference;
            date_data.Text = obj.record.header.date.ToString("dd/MM/yyyy");
            currencyRef_data.Text = obj.record.header.currencyRef;

            checkNo_data.Text = obj.record.header.checkNo;
            notes_data.Text = obj.record.header.notes;
            amount_data.Text = obj.record.header.amount.ToString("N2");
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