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
           spName_data.Text = webObject.record.header.spName;
           address_data.Text = companyInfo.address?.street1;

           clientRef_data.Text = webObject.record.header.clientRef;
           clientVATNo_data.Text = webObject.record.header.clientVATNo;
           clientName_data.Text = webObject.record.header.clientName;
           phoneNumber_data.Text = webObject.record.billAddress?.phone;
           cAddress_data.Text = webObject.record.billAddress?.street1;
           exhibitionManager_data.Text = webObject.record.header.contactName;

            tdPct_data.Text = webObject.record.header.tdPct.ToString();
            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.header.tdAmount.ToString();
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 10, 2);

            description_data.Text = webObject.record.header.description;

            spName2_data.Text = webObject.record.header.spName;

            pcs_data.Text = webObject.record.header.pcs.ToString();

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