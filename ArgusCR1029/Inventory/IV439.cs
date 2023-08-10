using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV439 : ArgusRPT.BaseReport
    {
        public IV439()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV439> obj = deserializeList<ArgusDS.Inventory.Reports.IV439>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            fromSite_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            toSite_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            warehouse_lbl.Text = labelText(1);
            issueRef_lbl.Text = labelText(2);
            issueDate_lbl.Text = labelText(3);
            issueTo_lbl.Text = labelText(4);
            itemRef_lbl.Text = labelText(5);
            itemName_lbl.Text = labelText(6);
            itemType_lbl.Text = labelText(7);
            itemCategory_lbl.Text = labelText(8);
            qty_lbl.Text = labelText(9);
            actualCost_lbl.Text = labelText(10);
            avgCost_lbl.Text = labelText(11);

            startDate_lbl.Text = labelText(12);
            endDate_lbl.Text = labelText(13);
            fromSite_lbl.Text = labelText(14);
            toSite_lbl.Text = labelText(15);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV439";
        }
    }
}