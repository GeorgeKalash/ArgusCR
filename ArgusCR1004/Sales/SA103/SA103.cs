using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1004.Sales.SA103
{
    public partial class SA103 : ArgusRPT.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(InvoiceItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();


            invRef_data.Text = webObject.record.trxHeader.reference;
            invDate_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);

            clientName_data.Text = webObject.record.trxHeader.clientName;
            crNo_data.Text = webObject.record.client.reference;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            clientDistrict_data.Text = webObject.record.billAddress?.cityDistrict;
            clientCity_data.Text = webObject.record.billAddress?.city;

            //seller data missing binding

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            discount_data.Text = webObject.record.trxHeader.tdAmount?.ToString("N2");
            taxable_data.Text = webObject.record.trxHeader.subtotal.ToString("N2"); 
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);
            //g24_data.Text = webObject.record.trxHeader.;
            description_data.Text = webObject.record.trxHeader.description;

            itemsNo_data.Text = webObject.record.items.Count.ToString();
            subttl_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            TVA_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            pureWeight_data.Text = webObject.record.pureMetalQty.ToString("N2");

            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.trxHeader.date, webObject.record.trxHeader.amount.ToString(), webObject.record.trxHeader.vatAmount.ToString()).ToBase64();

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "SA51303T19";
        }
    }
}