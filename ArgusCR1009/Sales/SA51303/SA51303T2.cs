using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1009.Sales.SA51303
{
    public partial class SA51303T2 : ArgusRPT.BaseReport
    {
        public SA51303T2 ()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;


            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            //reference2_data.Text = webObject.record.trxHeader.siteRef;

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            totalPay_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            subtotal2_data.Text = (webObject.record.trxHeader.subtotal - webObject.record.trxHeader.tdAmount).ToString();

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, (short)webObject.record.currencyProfileId, 3);

            clientName2_data.Text = webObject.record.trxHeader.clientName;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1009.SA51303T2";
        }
    }
}