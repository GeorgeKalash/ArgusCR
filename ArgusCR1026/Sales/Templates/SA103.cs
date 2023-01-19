using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1026.Sales.Templates
{
    public partial class SA103 : ArgusRPT.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();

            nb_data.Text = webObject.record.trxHeader.reference;
            invoiceDate_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            city_data.Text = webObject.record.trxHeader.plantName;

            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            if (webObject.record.currencyProfileId != null)
                amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, webObject.record.currencyProfileId, 2);

            base.OnBeforePrint(e);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.SA103";
        }
    }
}