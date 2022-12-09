using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1009.Sales.Templates
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
            DataSource = webObject.record.items;

            logo_data.ImageUrl = webObject.record.companyInfo.logoUrl;

            nom_data.Text = webObject.record.trxHeader.clientName;
            adresse_data.Text =  webObject.record.billAddress?.name;
            //cc_data.Text=?


            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            //ref1_data.Text=?
            //ref2_data.Text=?

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);

            total1_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            remise_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            total2_data.Text = webObject.record.trxHeader.miscAmount.ToString();

            tva_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            // ttc_data.Text = ?
            //asdi_data.Text=?
            payer_data.Text= webObject.record.trxHeader.amount.ToString("N2");

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1009.SA103";
        }
    }
}
