using DevExpress.XtraReports.UI;
using System;
using System.Collections;
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

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF104> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF104>();
            DataSource = webObject.record;
            dtName_data.Text = webObject.record.jobOrder.dtName;
            reference_data.Text = webObject.record.jobOrder.reference;

            ((IssueOfMaterialsSubReports)(IssueOfMaterialsSubReports.ReportSource)).data = webObject.record.rawMaterials;
            ((Reports.BaseReport)(IssueOfMaterialsSubReports.ReportSource)).setSessionInfo(sessionInfo);

            ((LaborTimeSubReports)(LaborTimeSubReports.ReportSource)).data = webObject.record.laborTime;
            ((Reports.BaseReport)(IssueOfMaterialsSubReports.ReportSource)).setSessionInfo(sessionInfo);

            ((OverheadsSubReport)(OverheadsSubReport.ReportSource)).data = webObject.record.overheadViews;
            ((Reports.BaseReport)(IssueOfMaterialsSubReports.ReportSource)).setSessionInfo(sessionInfo);


            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            jobOrderPricing_lbl.Text = labelText(0);

            documentType_lbl.Text = labelText(1);
            documentRef_lbl.Text = labelText(2);
        }

        protected override string dictionaryStore()
        {
            return "MF104";
        }
    }
}

