using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using ArgusDS.Financials;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.Financials
{
    public partial class FI401_L1b : ArgusRPT.BaseReport
    {
        public FI401_L1b()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.FI401_Layout1> obj = deserializeList<Custom.CR1029.FI401_Layout1>();
            DataSource = obj.list;

            year_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            segment_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            currency_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            accountBalance_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            accountType_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            date_data.TextFormatString = dateFormat();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);

            date_lbl.Text = labelText(1);
            docRef_lbl.Text = labelText(2);
            functionName_lbl.Text = labelText(3);
            plantRef_lbl.Text = labelText(4);
            description_lbl.Text = labelText(5);

            egp_lbl.Text = labelText(6);
            egpD_lbl.Text = labelText(7);
            egpC_lbl.Text = labelText(8);
            egpB_lbl.Text = labelText(9);

            G21_lbl.Text = labelText(10);
            g21D_lbl.Text = labelText(11);
            g21C_lbl.Text = labelText(12);
            g21B_lbl.Text = labelText(13);

            fiscalYear_lbl.Text = labelText(14);
            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            account_lbl.Text = labelText(17);
            accountGroup_lbl.Text = labelText(18);
            segment_lbl.Text = labelText(19);
            currency_lbl.Text = labelText(20);
            accountBalance_lbl.Text = labelText(21);
            accountType_lbl.Text = labelText(22);
            plant_lbl.Text = labelText(23);
            plantGroup_lbl.Text = labelText(24);
            saleZone_lbl.Text = labelText(25);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI401_L1b";
        }
    }
}