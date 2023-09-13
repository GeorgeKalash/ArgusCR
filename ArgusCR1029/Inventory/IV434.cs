using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV434 : ArgusRPT.BaseReport
    {
        public IV434()
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
            itemCategory_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            siteGroup_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            siteRef_data.Text = labelText(1);
            siteName_lbl.Text = labelText(2);
            previousBalance_lbl.Text = labelText(3);
            worksheet_lbl.Text = labelText(4);
            purchase_lbl.Text = labelText(5);
            purchaseReturn_lbl.Text = labelText(6);
            sales_lbl.Text = labelText(7);
            salesReturn_lbl.Text = labelText(8);
            metalReceipt_lbl.Text = labelText(9);
            metalPayment_lbl.Text = labelText(10);
            transferIn_lbl.Text = labelText(11);
            transferOut_lbl.Text = labelText(12);
            adj_lbl.Text = labelText(13);
            grossBalance_lbl.Text = labelText(14);
            baseBalance_lbl.Text = labelText(15);
            price_lbl.Text = labelText(16);

            fiscal_lbl.Text = labelText(17);
            startDate_lbl.Text = labelText(18);
            endDate_lbl.Text = labelText(19);
            site_lbl.Text = labelText(20);
            item_lbl.Text = labelText(21);
            itemCategory_lbl.Text = labelText(22);
            itemGroup_lbl.Text = labelText(23);
            siteGroup_lbl.Text = labelText(24);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV434";
        }
    }
}