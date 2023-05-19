using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SA102B : ArgusRPT.BaseReport
    {
        public SA102B()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SA102";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<OrderPrintLayout> webObject = deserializeGet<OrderPrintLayout>();
            DataSource = webObject.record.items;

            description_data.Text = webObject.record.header.description;
            amount_data.Text = webObject.record.header.amount.ToString("N0");
            clientName_data.Text = webObject.record.header.clientName;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yy");
       //     if (webObject.record.quickView.balance != null)
        //    {
         //       balance_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
        //        balance2_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
        //    }
        //    else
      //      {
        //        balance_data.Text = balance2_data.Text = string.Empty;
       //     }
            phone_data.Text = webObject.record.shipAddress?.phone;
            phone2_data.Text = webObject.record.shipAddress?.phone2;
            phone3_data.Text = webObject.record.shipAddress?.phone3;

            reference_data.Text = webObject.record.header.reference;
            spName_data.Text = webObject.record.header.spName;
            szName_data.Text = webObject.record.header.szName;
            if (webObject.record.header.volume != null)
                volume_data.Text = ((double)webObject.record.header.volume).ToString("N2");
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
