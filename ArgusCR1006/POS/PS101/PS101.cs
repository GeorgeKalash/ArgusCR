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

            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);

            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);
            vatNo_lbl.Text = labelText(0);


        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1006\\PS101";
        }
    }
}