using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace ArgusCR1029.Sales.SA111
{
    public partial class SA111 : ArgusRPT.BaseReport
    {
        public SA111()
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

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Sales.Reports.SA111> webObject = deserializeGet<ArgusDS.Sales.Reports.SA111>();

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            plant_data.Text = webObject.record.header.plantName;
            salesPerson_data.Text = webObject.record.header.spName;
            address_data.Text = companyInfo.address?.street1;

            clientRef_data.Text = webObject.record.header.clientRef;
            clientName_data.Text = webObject.record.header.clientName;
           // clientVATNo_data.Text = webObject.record.header.vatNumber;
           // phoneNumber_data.Text = webObject.record.billAddress?.phone;
           // cAddress_data.Text = webObject.record.billAddress?.street1;

            subtotal_data.Text = webObject.record.header.subTotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 10, 2);

            description_data.Text = webObject.record.header.description;
            spName2_data.Text = webObject.record.header.spName;

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA111";
        }
    }
}