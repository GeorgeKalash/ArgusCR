using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI205 : ArgusRPT.BaseReport
    {
        public FI205()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Financials.Reports.FI205> obj = deserializeList<ArgusDS.Financials.Reports.FI205>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            referenceParam_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            statusParam_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            systemFunction_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            accountRef_lbl.Text = labelText(3);
            accountName_lbl.Text = labelText(4);
            sku_lbl.Text = labelText(5);
            name_lbl.Text = labelText(6);
            qty_lbl.Text = labelText(7);
            purity_lbl.Text = labelText(8);
            totalqty_lbl.Text = labelText(9);
            creditAmount_lbl.Text = labelText(10);
            totalCredit_lbl.Text = labelText(11);
            description_lbl.Text = labelText(12);
            status_lbl.Text = labelText(13);

            total1_lbl.Text = labelText(14);
            total2_lbl.Text = labelText(15);

            startDate_lbl.Text = labelText(16);
            endDate_lbl.Text = labelText(17);
            referenceParam_lbl.Text = labelText(18);
            plant_lbl.Text = labelText(19);
            plantGroup_lbl.Text = labelText(20);
            account_lbl.Text = labelText(21);
            accountGroup_lbl.Text = labelText(22);
            site_lbl.Text = labelText(23);
            statusParam_lbl.Text = labelText(24);
            systemFunction_lbl.Text = labelText(25);
            item_lbl.Text = labelText(26);
            itemCategory_lbl.Text = labelText (27);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI205";
        }
    }
}