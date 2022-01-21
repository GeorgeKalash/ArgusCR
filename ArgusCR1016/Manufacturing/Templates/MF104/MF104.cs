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

            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Manufacturing.Reports.MF104> webObject = deserializeList<ArgusDS.Manufacturing.Reports.MF104>();
            DataSource = webObject.list;
    

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

