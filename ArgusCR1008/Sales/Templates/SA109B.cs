using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SA109B : ArgusRPT.BaseReport
    {
        public SA109B()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SATRX02";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Delivery.Reports.DE103> webObject = deserializeList<ArgusDS.Delivery.Reports.DE103>();
            DataSource = webObject.list;

         //   if (webObject.record.quickView.balance != null)
         //   {
         //       balance_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
          //      balance2_data.Text = ((double)webObject.record.quickView.balance).ToString("N0");
         //   }
         //   else
        //    {
         //       balance_data.Text = balance2_data.Text = string.Empty;
         //   }
         //   phone2_data.Text = webObject.record.quickView.phone2;
         //   phone3_data.Text = webObject.record.quickView.phone3;
         //   phone_data.Text = webObject.record.quickView.phone;

         //   spName_data.Text = webObject.record.trxHeader.spName;
      //      szName_data.Text = webObject.record.trxHeader.szName;


            base.OnBeforePrint(e);
        }

        private void XrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = Math.Ceiling(Convert.ToDecimal((sender as XRLabel).Value)).ToString();
        }
    }
}