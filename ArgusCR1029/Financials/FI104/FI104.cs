using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1029.Financials.FI104
{
    public partial class FI104 : ArgusRPT.BaseReport
    {
        public FI104()
        {
            InitializeComponent();
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(ItemsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(MetalSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
           SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI104> webObject = deserializeGet<ArgusDS.Financials.Reports.FI104>();

            ((ItemsSubReports)(ItemsSubReports.ReportSource)).data = webObject.record.items;
            ((MetalSubReports)(MetalSubReports.ReportSource)).data = webObject.record.metalSummaries;

            logo_data.ImageUrl = companyInfo.logoUrl;

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");
            plantName_data.Text = webObject.record.header.plantName;
            siteName_data.Text = webObject.record.header.siteName;

            accountRef_data.Text = webObject.record.header.accountRef;
            accountName_data.Text = webObject.record.header.accountName;
            phoneNumber_data.Text = webObject.record.bpAddress?.phone;
            exhibitionManager_data.Text = webObject.record.contactMasterData?.name;
            cAddress_data.Text = webObject.record.bpAddress?.street1;
            description_data.Text = webObject.record.header.description;

            baseMetalQty_data.Text = webObject.record.baseMetalQty.ToString("N2");
            totalLabor_data.Text = webObject.record.totalLabor.ToString("N2");

            amountBaseMetalQty_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.baseMetalQty, 4, 2);
            amountTotalLabor_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.totalLabor, 10, 2);

            createdName_data.Text = webObject.record.header.userName;
            createdDate_data.Text = webObject.record.header.createdDate.ToString();

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI104";
        }
    }
}