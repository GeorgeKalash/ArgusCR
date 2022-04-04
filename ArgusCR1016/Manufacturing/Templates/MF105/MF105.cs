using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    public partial class MF105 : Reports.BaseReport
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
            ((Reports.BaseReport)(Templates.MF105.IssueOfMaterialsSubReport.ReportSource)).setSessionInfo(sessionInfo);
            ((Reports.BaseReport)(Templates.MF105.CategorySubReport.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF105> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF105>();
      
                 
            ((IssueOfMaterialsSubReport)(Templates.MF105.IssueOfMaterialsSubReport.ReportSource)).data = webObject.record.rawMaterials;
            ((CategorySubReport)(Templates.MF105.CategorySubReport.ReportSource)).data = webObject.record.categories;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            workSheet_lbl.Text = labelText(0);
        }
        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF105";
        }
    }
}

