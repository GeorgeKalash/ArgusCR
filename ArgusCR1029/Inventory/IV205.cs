using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV205 : ArgusRPT.BaseReport
    {
        public IV205()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV205> obj = deserializeList<ArgusDS.Inventory.Reports.IV205>();
            DataSource = obj.list;

            fromSite_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            toSite_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);
           
            docType_lbl.Text = labelText(1);
            draftRef_data.Text = labelText(2);
            date_lbl.Text = labelText(3);
            fromSite_lbl.Text = labelText(4);
            toSite_lbl.Text = labelText(5);
            notify_lbl.Text = labelText(6);
            grossQty_lbl.Text = labelText(7);
            pcs_lbl.Text = labelText(8);
            weight_lbl.Text = labelText(9);
            baseQty_lbl.Text = labelText(10);
            weight2_lbl.Text = labelText(11);
            description_lbl.Text = labelText(12);
            status_lbl.Text = labelText(13);
            transferRef_lbl.Text = labelText(14);

            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            fromSiteParam_lbl.Text = labelText(17);
            toSiteParam_lbl.Text = labelText(18);

        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV205";
        }
    }
}