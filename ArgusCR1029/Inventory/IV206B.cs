using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV206B : ArgusRPT.BaseReport
    {
        public IV206B()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV206> webObject = deserializeList<ArgusDS.Inventory.Reports.IV206>();
            DataSource = webObject.list;

            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            date_lbl.Text = labelText(1);
            transferId_lbl.Text = labelText(2);
            itemId_lbl.Text = labelText(3);
            itemName_lbl.Text = labelText(4);
            qty_lbl.Text = labelText(5);
            costPrice_lbl.Text = labelText(6);
            costAmnt_lbl.Text = labelText(7);
            dimension_lbl.Text = labelText(8);
            dimensionDesc_lbl.Text = labelText(9);

            startDate_lbl.Text = labelText(10);
            endDate_lbl.Text = labelText(11);
            siteParam_lbl.Text = labelText(12);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV206B";
        }
    }
}