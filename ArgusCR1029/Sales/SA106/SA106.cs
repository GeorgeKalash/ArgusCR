using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace ArgusCR1029.Sales.SA106
{
    public partial class SA106 : ArgusRPT.BaseReport
    {
        public SA106()
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

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Sales.Reports.SA106> webObject = deserializeGet<ArgusDS.Sales.Reports.SA106>();

            reference_data.Text = webObject.record.reference;
            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            plant_data.Text = webObject.record?.plantName;
            salesPerson_data.Text = webObject.record.spName;
            address_data.Text = companyInfo.address?.street1;

            clientRef_data.Text = webObject.record.clientRef;
            clientName_data.Text = webObject.record.clientName;
            clientVATNo_data.Text = webObject.record.clientVATNo;
            phoneNumber_data.Text = webObject.record.billAddress?.phone;
            cAddress_data.Text = webObject.record.billAddress?.street1;
            exhibitionManager_data.Text = webObject.record.contactName;

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.amount, 10, 2);

            description_data.Text = webObject.record.description;

            subtotal_data.Text = webObject.record.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.amount.ToString("N2");

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.serials;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA106";
        }
    }
}