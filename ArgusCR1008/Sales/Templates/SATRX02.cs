using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SATRX02 : ArgusRPT.BaseReport
    {
        public SATRX02()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SA103";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            description_data.Text = webObject.record.trxHeader.description;
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N0");
            clientName_data.Text = webObject.record.trxHeader.clientName;
            date_data.Text = webObject.record.trxHeader.date.ToString("dd/MM/yy");
            if (webObject.record.quickView.balance != null)
            {
                balance_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
                balance2_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
            }
            else
            {
                balance_data.Text = balance2_data.Text = string.Empty;
            }
            phone2_data.Text = webObject.record.quickView.phone2;
            phone3_data.Text = webObject.record.quickView.phone3;
            phone_data.Text = webObject.record.quickView.phone;
            reference_data.Text = webObject.record.trxHeader.reference;
            spName_data.Text = webObject.record.trxHeader.spName;
            szName_data.Text = webObject.record.trxHeader.szName;
            if (webObject.record.trxHeader.volume != null)
                volume_data.Text = ((double)webObject.record.trxHeader.volume).ToString("N2");
            else
                volume_data.Text = string.Empty;

            base.OnBeforePrint(e);
        }

        private void XrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = Math.Ceiling(Convert.ToDecimal((sender as XRLabel).Value)).ToString();
        }
    }
}
