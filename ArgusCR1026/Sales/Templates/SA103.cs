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
            date1_data.Text = webObject.record.trxHeader.date.ToString();
            date2_data.Text = webObject.record.trxHeader.reference;
            //reference_data.Text = webObject.record.;
            city_data.Text = webObject.record.trxHeader.plantName;
            name_data.Text = webObject.record.client.flName;
            amount_data.Text = webObject.record.trxHeader.amount.ToString();
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);

            //fulfillment_data.Text = webObject.record.;
            //debtor_data.Text = webObject.record.;
            //id_data.Text = webObject.record.;
            //fingerprint_data.Text = webObject.record.;
            //signature_data.Text = webObject.record.;

            base.OnBeforePrint(e);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.SA103";
        }
    }
}