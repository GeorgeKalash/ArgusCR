using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV432 : ArgusRPT.BaseReport
    {
        public IV432()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV432> obj = deserializeList<ArgusDS.Inventory.Reports.IV432>();
            DataSource = obj.list;

            fiscal_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            itemRef_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            previousBalance_lbl.Text = labelText(3);
            purchase_lbl.Text = labelText(4);
            purchaseReturn_lbl.Text = labelText(5);
            sales_lbl.Text = labelText(6);
            salesReturn_lbl.Text = labelText(7);
            metalReceipt_lbl.Text = labelText(8);
            metalPayment_lbl.Text = labelText(9);
            transferIn_lbl.Text = labelText(10);
            transferOut_lbl.Text = labelText(11);
            adj_lbl.Text = labelText(12);
            grossBalance_lbl.Text = labelText(13);
            baseBalance_lbl.Text = labelText(14);

            fiscal_lbl.Text = labelText(15);
            startDate_lbl.Text = labelText(16);
            endDate_lbl.Text = labelText(17);
            site_lbl.Text = labelText(18);
            item_lbl.Text = labelText(19);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV432";
        }
    }
}