using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1039.Financials
{
    public partial class FI104B : ArgusRPT.BaseReport
    {
        public FI104B()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI104> obj = deserializeGet<ArgusDS.Financials.Reports.FI104>();
            DataSource = obj.record.items;

            accountRef_data.Text = obj.record.header.accountRef;
            accountName_data.Text = obj.record.header.accountName;

            reference_data.Text = obj.record.header.reference;
            date_data.Text = obj.record.header.date.ToString("dd/MM/yyyy");
            phone_data.Text = obj.record.bpAddress?.phone;

            description_data.Text = obj.record.header.description;
            amountBaseMetalQty_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)obj.record.baseMetalQty, 4, 2);
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1039.FI104";
        }
    }
}