using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace ArgusCR1029.Sales.SA108
{
    public partial class SA108 : ArgusRPT.BaseReport
    {
        public SA108()
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

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Sales.Reports.SA108> webObject = deserializeGet<ArgusDS.Sales.Reports.SA108>();

           logo_data.ImageUrl = companyInfo.logoUrl;


            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
           plant_data.Text = webObject.record.header.plantName;
           phoneNo_data.Text = companyInfo.address?.phone;
           address_data.Text = companyInfo.address?.street1;

            clientRef_data.Text = webObject.record.header.clientRef;
            clientName_data.Text = webObject.record.header.clientName;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 10, 2);

          spName2_data.Text = webObject.record.header.spName;

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.serials;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA108";
        }
    }
}