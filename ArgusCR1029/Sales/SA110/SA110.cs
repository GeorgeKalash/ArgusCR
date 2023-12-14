using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1029.Sales.SA110
{
    public partial class SA110 : ArgusRPT.BaseReport
    {
        public SA110()
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

            SharedClasses.JsonProtocol.GetStructure <ArgusDS.Sales.Reports.SA110> webObject = deserializeGet<ArgusDS.Sales.Reports.SA110>();

            logo_data.ImageUrl = companyInfo.logoUrl;


            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            plant_data.Text = webObject.record.trxHeader.plantName;
            spName_data.Text = webObject.record.trxHeader.spName;
            address_data.Text = companyInfo.address?.street1;


            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            phoneNumber_data.Text = webObject.record.billAddress?.phone;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            tdPct_data.Text = webObject.record.trxHeader.tdPct.ToString();
            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 10, 2);

            description_data.Text = webObject.record.trxHeader.description;
            spName2_data.Text = webObject.record.trxHeader.spName;

            pcs_data.Text = webObject.record.trxHeader.pcs.ToString();

            ((InvoiceItemsSubReports)(InvoiceItemsSubReports.ReportSource)).data = webObject.record.serials;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA110";
        }
    }
}