using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI409M2 : ArgusRPT.BaseReport
    {
        public FI409M2()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.FI409m2> obj = deserializeList<Custom.CR1029.FI409m2>();
            DataSource = obj.list;

            fiscal_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            accountGrp_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            segment_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            accountType_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            zone_lbl.Text = labelText(1);
            accountRef_lbl.Text = labelText(2);
            keyword_lbl.Text = labelText(3);
            accountName_lbl.Text = labelText(4);
            commericalName_lbl.Text = labelText(5);
            credit_lbl.Text = labelText(6);
            phone_lbl.Text = labelText(7);
            metal_lbl.Text = labelText(8);
            cash_lbl.Text = labelText(9);
            subtotal_lbl.Text = labelText(10);
            total_lbl.Text = labelText(11);

            fiscal_lbl.Text = labelText(12);
            startDate_lbl.Text = labelText(13);
            endDate_lbl.Text = labelText(14);
            accountGrp_lbl.Text = labelText(15);
            account_lbl.Text = labelText(16);
            segment_lbl.Text = labelText(17);
            accountType_lbl.Text = labelText(18);
            plant_lbl.Text = labelText(19);
            level_lbl.Text = labelText(20);
            plantGroup_lbl.Text = labelText(21);
            saleZone_lbl.Text = labelText(22);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI409M2";
        }
    }
}