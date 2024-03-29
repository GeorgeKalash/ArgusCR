﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    public partial class MF105 : ArgusRPT.BaseReport
    {
        public MF105()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return workSheet_lbl.Text;
        }

        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(IssueOfMaterialsSubReport.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(CategorySubReport.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF105> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF105>();
            orderNum_data.Text = webObject.record.workSheet.jobRef;
            orderTo_data.Text = webObject.record.jobOrder.clientName;
            laborRef_data.Text = webObject.record.workSheet.laborRef;
            laborName_data.Text = webObject.record.workSheet.laborName;
            date_data.Text = webObject.record.workSheet.date.ToString(sessionInfo.dateFormat);
            remarks_data.Text = webObject.record.workSheet.notes;
            refBarcode.Text = webObject.record.workSheet.reference;
            weightBefore_data.Text = webObject.record.workSheet.wgtBefore.ToString();
            weightAfter_data.Text = webObject.record.workSheet.wgtAfter.ToString();

            ((IssueOfMaterialsSubReport)(IssueOfMaterialsSubReport.ReportSource)).data = webObject.record.rawMaterials;
            ((CategorySubReport)(CategorySubReport.ReportSource)).data = webObject.record.categories;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            workSheet_lbl.Text = labelText(0);
            orderNum_lbl.Text = labelText(1);
            orderTo_lbl.Text = labelText(2);
            labor_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            weightBefore_lbl.Text = labelText(5);
            weightAfter_lbl.Text = labelText(6);
            remarks_lbl.Text = labelText(7);
        }

        protected override string dictionaryStore()
        {
            return "CR1016.MF105";
        }
    }
}

