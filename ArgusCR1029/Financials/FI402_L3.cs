using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI402_L3 : ArgusRPT.BaseReport
    {
        public FI402_L3()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.FI402_L3> obj = deserializeList<Custom.CR1029.FI402_L3>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            salesPerson_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;

            currency_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            currencyType_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI402_L3";
        }
    }
}