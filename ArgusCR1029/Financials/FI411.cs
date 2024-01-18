using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI411 : ArgusRPT.BaseReport
    {
        int itemsCounter = 0;
        public FI411 ()
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
            showZeroBalances_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);

            invoiceNo_lbl.Text = labelText(1);
            receiptNo_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);

            invoiceAmount_lbl.Text = labelText(4);
            IG18_lbl.Text = labelText(5);
            IG21_lbl.Text = labelText(6);
            IEGP_lbl.Text = labelText(7);

            paidAmount_lbl.Text = labelText(8);
            PG18_lbl.Text = labelText(9);
            PG21_lbl.Text = labelText(10);
            PEGP_lbl.Text = labelText(11);

            openBalance_lbl.Text = labelText(12);
            OG18_lbl.Text = labelText(13);
            OG21_lbl.Text = labelText(14);
            OEGP_lbl.Text = labelText(15);

            invoiceDate_lbl.Text = labelText(16);

            startDate_lbl.Text = labelText(17);
            endDate_lbl.Text = labelText(18);
            account_lbl.Text = labelText(19);
            currency_lbl.Text = labelText(20);
            accountGroup_lbl.Text = labelText(21);
            showZeroBalances_lbl.Text = labelText(22);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI411";
        }
    }
}