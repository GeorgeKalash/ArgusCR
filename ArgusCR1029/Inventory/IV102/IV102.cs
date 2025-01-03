﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace ArgusCR1029.Inventory.IV102
{
    public partial class IV102 : ArgusRPT.BaseReport
    {
        public IV102()
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
            ((ArgusRPT.BaseReport)(TransferSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure <ArgusDS.Inventory.Reports.IV102> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV102>();

            logo_data.ImageUrl = companyInfo.logoUrl;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");

            fromSiteRef_data.Text = webObject.record.header.fromSiteRef;
            fromSiteName_data.Text = webObject.record.header.fromSiteName;
            toSiteRef_data.Text = webObject.record.header.toSiteRef;
            toSiteName_data.Text = webObject.record.header.toSiteName;

            notifyName_data.Text = webObject.record.header.notifyName;

            totalWeight21_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.totalWeightG21, 4, 2);
            sumSalesPrice_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.sumSalesPrice, 10, 2);
            note_data.Text = webObject.record.header.notes;

            fromSiteName2_data.Text = webObject.record.header.fromSiteName;
            toSiteName2_data.Text = webObject.record.header.toSiteName;

            printSignature_lbl.Text = reportSignature();

            ((TransferSubReports)(TransferSubReports.ReportSource)).data = webObject.record.items;
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV102";
        }
    }
}