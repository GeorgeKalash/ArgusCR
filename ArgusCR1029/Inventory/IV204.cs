using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV204 : ArgusRPT.BaseReport
    {
        public IV204()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV204> obj = deserializeList<ArgusDS.Inventory.Reports.IV204>();
            DataSource = obj.list;

            fromSite_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            toSite_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);
            startDate_lbl.Text = labelText(1);
            endDate_lbl.Text = labelText(2);
            fromSiteParam_lbl.Text = labelText(17);
            toSiteParam_lbl.Text = labelText(18);

            docType_lbl.Text = labelText(3);
            draftRef_data.Text = labelText(4);
            date_lbl.Text = labelText(5);
            fromSite_lbl.Text = labelText(6);
            toSite_lbl.Text = labelText(7);
            notify_lbl.Text = labelText(8);
            grossQty_lbl.Text = labelText(9);
            pcs_lbl.Text = labelText(10);
            weight_lbl.Text = labelText(11);
            baseQty_lbl.Text = labelText(12);
            weight2_lbl.Text = labelText(13);
            description_lbl.Text = labelText(14);
            status_lbl.Text = labelText(15);
            transferRef_lbl.Text = labelText(16);

        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV204";
        }
    }
}