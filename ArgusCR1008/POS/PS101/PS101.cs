using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1008.POS.PS101
{
    public partial class PS101 : ArgusRPT.BaseReport
    {
        public PS101()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(InvoiceItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(InvoiceReceiptSubReports.ReportSource)).setSessionInfo(sessionInfo);

            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS101> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS101>();

            logo_data.ImageUrl = webObject.record.companyInfo.logoUrl;
            reference_data.Text = webObject.record.invoiceView.reference;
            date_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.invoiceView.spName;
            plant_data.Text = webObject.record.invoiceView.plantName;
        
          if (webObject.record.address != null)
           {
                clientName_data.Text = webObject.record.address.name;
                phoneNumber_data.Text = webObject.record.address.phone;
                address_data.Text = webObject.record.address.street1;
            }           
          
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.invoiceItems;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports.ReportSource)).data = webObject.record.receipts;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1008\\PS101";
        }
    }
}