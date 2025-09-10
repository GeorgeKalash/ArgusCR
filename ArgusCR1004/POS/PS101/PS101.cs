using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1004.POS.PS101
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

            ((ArgusRPT.BaseReport)(InvoiceItemsSubReports2.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(InvoiceReceiptSubReports2.ReportSource)).setSessionInfo(sessionInfo);

            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS101> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS101>();
  
            vatNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.invoiceView.reference;
            date_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.salesPerson.name;
            plant_data.Text = webObject.record.invoiceView.plantName;
            clientName_data.Text = webObject.record.invoiceView?.clientName;

            if (webObject.record.address != null)
           {
                phoneNumber_data.Text = webObject.record.address.phone;
                address_data.Text = webObject.record.address.street1;
            }

            total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);

            vatNo2_data.Text = webObject.record.companyInfo.taxNo;

            reference2_data.Text = webObject.record.invoiceView.reference;
            date2_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            spName2_data.Text = webObject.record.salesPerson.name;
            plant2_data.Text = webObject.record.invoiceView.plantName;
            clientName2_data.Text = webObject.record.invoiceView?.clientName;
            if (webObject.record.address != null)
            {
                phoneNumber2_data.Text = webObject.record.address.phone;
                address2_data.Text = webObject.record.address.street1;
            }

            total2_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);
            QRCode2.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.invoiceView.amount.ToString(), webObject.record.invoiceView.vatAmount.ToString()).ToBase64();
            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.invoiceView.amount.ToString(), webObject.record.invoiceView.vatAmount.ToString()).ToBase64();
            
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.invoiceItems;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports.ReportSource)).data = webObject.record.receipts;
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports2.ReportSource)).data = webObject.record.invoiceItems;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports2.ReportSource)).data = webObject.record.receipts;

            printSignature_lbl.Text = reportSignature();
            printSignature2_lbl.Text = reportSignature();

            plantCrNo_data.Text = webObject.record.invoiceView.plantCrNo;
            plantCrNo2_data.Text = webObject.record.invoiceView.plantCrNo;
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1004.PS101";
        }
    }
}