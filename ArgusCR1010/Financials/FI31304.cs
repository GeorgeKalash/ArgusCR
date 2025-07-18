using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1010.Financials
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


            reference_data.Text = obj.record.reference;
            paymentMethodName_data.Text = obj.record.paymentMethodName;
            amount_data.Text = obj.record.amount.ToString("N2");

            if (obj.record.currencyProfileId != null)
                amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)obj.record.amount, obj.record.currencyProfileId, 3);

            amountInWords_data.Text = string.Format("\"{0}\"", amountInWords_data.Text);

            date_data.Text = obj.record.date.ToString("dd/MM/yyyy");

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1010.FI31304";
        }
    }
}