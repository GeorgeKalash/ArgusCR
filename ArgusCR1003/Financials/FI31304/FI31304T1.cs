using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Financials.FI31304
{
    public partial class FI31304T1 : ArgusRPT.BaseReport
    {
        public FI31304T1()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.ReceiptVoucherView> webObject = deserializeGet<ArgusDS.Financials.ReceiptVoucherView>();
            dateTop_data.Text = webObject.record.date.ToString("dd/MM/yyyy"); ;

            refNo_data.Text = webObject.record.reference;
            branch_data.Text = webObject.record.plantName;

            sar_data.Text = webObject.record.baseAmount.ToString();
            receivedFrom_data.Text = webObject.record.cashAccountName;
            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            
            qrCode.Text = webObject.record.reference; ;
            for_data.Text = webObject.record.accountName;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.FI31304T1";
        }
    }
}