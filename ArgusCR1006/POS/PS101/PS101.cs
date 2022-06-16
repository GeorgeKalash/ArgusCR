using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1006.POS.PS101
{
    public partial class PS101 : Reports.BaseReport
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
            ((Reports.BaseReport)(InvoiceItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((Reports.BaseReport)(InvoiceReceiptSubReports.ReportSource)).setSessionInfo(sessionInfo);

            ((Reports.BaseReport)(InvoiceItemsSubReports2.ReportSource)).setSessionInfo(sessionInfo);
            ((Reports.BaseReport)(InvoiceReceiptSubReports2.ReportSource)).setSessionInfo(sessionInfo);

            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS101> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS101>();
  
            vatNo_data.Text = webObject.record.companyInfo.taxNo;

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

            total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);

            vatNo2_data.Text = webObject.record.companyInfo.taxNo;

            reference2_data.Text = webObject.record.invoiceView.reference;
            date2_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            spName2_data.Text = webObject.record.invoiceView.spName;
            plant2_data.Text = webObject.record.invoiceView.plantName;

            if (webObject.record.address != null)
            {
                clientName2_data.Text = webObject.record.address.name;
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
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            vatNo_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            title_lbl.Text = labelText(3);
            spName_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);

            clientName_lbl.Text = labelText(6);
            phoneNumber_lbl.Text = labelText(7);
            address_lbl.Text = labelText(8);
            nationality_lbl.Text = labelText(9);
            idNumber_lbl.Text = labelText(10);
            expirydate_lbl.Text = labelText(11);
            versionNumber_lbl.Text = labelText(12);

            total_lbl.Text = labelText(13);
            spSignature_lbl.Text = labelText(14);
            clientSignature_lbl.Text = labelText(15);

            vatNo2_lbl.Text = labelText(16);

            reference2_lbl.Text = labelText(17);
            date2_lbl.Text = labelText(18);
            title2_lbl.Text = labelText(19);
            spName2_lbl.Text = labelText(20);
            plant2_lbl.Text = labelText(21);

            clientName2_lbl.Text = labelText(22);
            phoneNumber2_lbl.Text = labelText(23);
            address2_lbl.Text = labelText(24);
            nationality2_lbl.Text = labelText(25);
            idNumber2_lbl.Text = labelText(26);
            expirydate2_lbl.Text = labelText(27);
            versionNumber2_lbl.Text = labelText(28);

            total2_lbl.Text = labelText(29);
            spSignature2_lbl.Text = labelText(30);
            clientSignature2_lbl.Text = labelText(31);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101";
        }
    }
}