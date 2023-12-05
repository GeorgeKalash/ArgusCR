using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI407 : ArgusRPT.BaseReport
    {
        int itemsCounter = 0;
        public FI407()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS._1029.FI407> obj = deserializeList<ArgusDS._1029.FI407>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            currency_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            showZeroBalances_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS._1029.FI407> obj = deserializeList<ArgusDS._1029.FI407>();

            IG18_data.Text = (obj.list[itemsCounter].amountG18 == 0.0) ? "-" : obj.list[itemsCounter].amountG18.ToString("N2");
            IG21_data.Text = (obj.list[itemsCounter].amountG21 == 0.0) ? "-" : obj.list[itemsCounter].amountG21.ToString("N2");
            IEGP_data.Text = (obj.list[itemsCounter].amountEGP == 0.0) ? "-" : obj.list[itemsCounter].amountEGP.ToString("N2");
           
            PG18_data.Text = (obj.list[itemsCounter].paidAmountG18 == 0.0) ? "-" : obj.list[itemsCounter].paidAmountG18.ToString("N2");
            PG21_data.Text = (obj.list[itemsCounter].paidAmountG21 == 0.0) ? "-" : obj.list[itemsCounter].paidAmountG21.ToString("N2");
            PEGP_data.Text = (obj.list[itemsCounter].paidAmountEGP == 0.0) ? "-" : obj.list[itemsCounter].paidAmountEGP.ToString("N2");
            
            OG18_data.Text = (obj.list[itemsCounter].balanceG18 == 0.0) ? "-" : obj.list[itemsCounter].balanceG18.ToString("N2");
            OG21_data.Text = (obj.list[itemsCounter].balanceG21 == 0.0) ? "-" : obj.list[itemsCounter].balanceG21.ToString("N2");
            OEGP_data.Text = (obj.list[itemsCounter].balanceEGP == 0.0) ? "-" : obj.list[itemsCounter].balanceEGP.ToString("N2");

            ++itemsCounter;

            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);

            accountRef_lbl.Text = labelText(1);
            accountName_lbl.Text = labelText(2);
            invoiceNo_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);

            invoiceAmount_lbl.Text = labelText(5);
            IG18_lbl.Text = labelText(6);
            IG21_lbl.Text = labelText(7);
            IEGP_lbl.Text = labelText(8);

            paidAmount_lbl.Text = labelText(9);
            PG18_lbl.Text = labelText(10);
            PG21_lbl.Text = labelText(11);
            PEGP_lbl.Text = labelText(12);

            openBalance_lbl.Text = labelText(13);
            OG18_lbl.Text = labelText(14);
            OG21_lbl.Text = labelText(15);
            OEGP_lbl.Text = labelText(16);

            metalAging_lbl.Text = labelText(17);
            paid_lbl.Text = labelText(18);

            currencyA_lbl.Text = labelText(19);
            agingPaid_lbl.Text = labelText(20);

            startDate_lbl.Text = labelText(21);
            endDate_lbl.Text = labelText(22);
            account_lbl.Text = labelText(23);
            currency_lbl.Text = labelText(24);
            accountGroup_lbl.Text = labelText(25);
            showZeroBalances_lbl.Text = labelText(26);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI407";
        }
    }
}