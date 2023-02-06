using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1019.POS.PS101
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
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS101> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS101>();

            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.invoiceView.amount.ToString(), webObject.record.invoiceView.vatAmount.ToString()).ToBase64();
            logo_data.ImageUrl = webObject.record.companyInfo.logoUrl;

            companyName_data.Text = webObject.record.companyInfo.name;
            companyStreet_data.Text = webObject.record.companyInfo.address?.street1;
            companyCity_data.Text = webObject.record.companyInfo.address?.city;
            companyVatNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.invoiceView.reference;
            date_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.salesPerson.name;
            plant_data.Text = webObject.record.invoiceView.plantName;
        
          if (webObject.record.address != null)
           {
                clientName_data.Text = webObject.record.address.name;
                phoneNumber_data.Text = webObject.record.address.phone;
                address_data.Text = webObject.record.address.street1;
            }

            total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);
           
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.invoiceItems;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports.ReportSource)).data = webObject.record.receipts;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1019.PS101";
        }
    }
}