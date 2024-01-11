using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1009.Sales.SA51301
{
    public partial class SA51301T1 : ArgusRPT.BaseReport
    {
        public SA51301T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();
            DataSource = webObject.record.items;

            reference_data.Text = webObject.record.header.reference;
            client_data.Text = webObject.record.header.clientName;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, (short) webObject.record.header.currencyProfileId, 3);

            ht_data.Text = webObject.record.header.subtotal.ToString("N2");
            tva_data.Text = webObject.record.header.vatAmount.ToString("N2");
            ttc_data.Text = webObject.record.header.amount.ToString("N2");

            clientName2_data.Text = webObject.record.header.clientName;
            spName_data.Text = webObject.record.header.spName;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1009.SA51301T1";
        }
    }
}
