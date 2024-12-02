using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    public partial class MF104 : ArgusRPT.BaseReport
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
            ((ArgusRPT.BaseReport)(IssueOfMaterialsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(OverheadsSubReport.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF104> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF104>();
      
            dtName_data.Text = webObject.record.jobOrder.dtName;
            reference_data.Text = webObject.record.jobOrder.reference;

            decimal grandTotal = (webObject.record.jobOrder.RMCost?? 0) + (webObject.record.jobOrder.overheadAmount?? 0);
            grandTotal_data.Text = grandTotal.ToString("N2");


            ((IssueOfMaterialsSubReports)(IssueOfMaterialsSubReports.ReportSource)).data = webObject.record.rawMaterials;
            ((OverheadsSubReport)(OverheadsSubReport.ReportSource)).data = webObject.record.overheadViews;

            QRCode.Text = webObject.record.jobOrder.recordId.ToString();

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
            return "CR1016.MF104";
        }
    }
}

