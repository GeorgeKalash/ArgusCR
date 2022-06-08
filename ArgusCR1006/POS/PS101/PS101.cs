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
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS101> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS101>();
            DataSource = webObject.record.invoiceItems;

            vatNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.invoiceView.reference;
            date_data.Text = webObject.record.invoiceView.date.ToString(sessionInfo.dateFormat);
            total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.invoiceView.amount, 2, 2);
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

            printSignature_lbl.Text = reportSignature();
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
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101";
        }
    }
}