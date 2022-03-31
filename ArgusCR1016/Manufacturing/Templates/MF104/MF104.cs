﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    public partial class MF104 : Reports.BaseReport
    {
        public MF104()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return jobOrderPricing_lbl.Text;
        }
        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((Reports.BaseReport)(IssueOfMaterialsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((Reports.BaseReport)(OverheadsSubReport.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF104> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF104>();
      
            dtName_data.Text = webObject.record.jobOrder.dtName;
            reference_data.Text = webObject.record.jobOrder.reference;
            grandTotal_data.Text = webObject.record.jobOrder.RMCost.ToString() + webObject.record.jobOrder.overheadAmount.ToString();


            ((IssueOfMaterialsSubReports)(IssueOfMaterialsSubReports.ReportSource)).data = webObject.record.rawMaterials;
            ((OverheadsSubReport)(OverheadsSubReport.ReportSource)).data = webObject.record.overheadViews;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            jobOrderPricing_lbl.Text = labelText(0);
            documentType_lbl.Text = labelText(1);
            documentRef_lbl.Text = labelText(2);

            grandTotal_lbl.Text = labelText(3);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF104";
        }
    }
}

