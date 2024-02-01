using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1004.POS.PS102
{
    public partial class PS102 : ArgusRPT.BaseReport
    {
        public PS102()
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
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.PointOfSale.Reports.PS102> webObject = deserializeGet<ArgusDS.PointOfSale.Reports.PS102>();
  
            vatNo_data.Text = companyInfo.taxNo;

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.header.spName;
            plant_data.Text = webObject.record.header.plantName;
            clientName_data.Text = webObject.record.header?.clientName;

          if (webObject.record.address != null)
         {
                phoneNumber_data.Text = webObject.record.address.phone;
                address_data.Text = webObject.record.address.street1;
          }

            total_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, 2);

            vatNo2_data.Text = companyInfo.taxNo;

            reference2_data.Text = webObject.record.header.reference;
            date2_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            spName2_data.Text = webObject.record.header.spName;
            plant2_data.Text = webObject.record.header.plantName;
            clientName2_data.Text = webObject.record.header?.clientName;
            if (webObject.record.address != null)
            {
                phoneNumber2_data.Text = webObject.record.address.phone;
                address2_data.Text = webObject.record.address.street1;
            }

            total2_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, 2);
            QRCode2.Text = new KSAeInvoiceQrCode(companyInfo.name, companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.header.amount.ToString(), webObject.record.header.vatAmount.ToString()).ToBase64();
            QRCode.Text = new KSAeInvoiceQrCode(companyInfo.name, companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.header.amount.ToString(), webObject.record.header.vatAmount.ToString()).ToBase64();
            
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.items;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports.ReportSource)).data = webObject.record.cash;
            ((InvoiceItemsSubReports)(InvoiceItemsSubReports2.ReportSource)).data = webObject.record.items;
            ((InvoiceReceiptSubReports)(InvoiceReceiptSubReports2.ReportSource)).data = webObject.record.cash;

            printSignature_lbl.Text = reportSignature();
            printSignature2_lbl.Text = reportSignature();
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