using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using ArgusDS.Financials;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.Financials
{
    public partial class FI402_L1 : ArgusRPT.BaseReport
    {
        public FI402_L1()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.FI402_L1> obj = deserializeList<Custom.CR1029.FI402_L1>();
            DataSource = obj.list;

            fiscalYear_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);

            clientRef_lbl.Text = labelText(1);
            clientName_lbl.Text = labelText(2);
            previousBalance_lbl.Text = labelText(3);
            egpPB_lbl.Text = labelText(4);
            metalPB_lbl.Text = labelText(5);
            sales_lbl.Text = labelText(6);
            egpS_lbl.Text = labelText(7);
            metalS_lbl.Text = labelText(8);
            salesReturn_lbl.Text = labelText(9);
            egpSR_lbl.Text = labelText(10);
            metalSR_lbl.Text = labelText(11);
            receipt_lbl.Text = labelText(12);
            egpR_lbl.Text = labelText(13);
            metalR_lbl.Text = labelText(14);
            payment_lbl.Text = labelText(15);
            egpP_lbl.Text = labelText(16);
            metalP_lbl.Text = labelText(17);
            creditNote_lbl.Text = labelText(18);
            egpCN_lbl.Text = labelText(19);

            metalCN_lbl.Text = labelText(20);
            debitNote_lbl.Text = labelText(21);
            egpDN_lbl.Text = labelText(22);
            metalDN_lbl.Text = labelText(23);
            balanceTransfer_lbl.Text = labelText(24);
            egpBT_lbl.Text = labelText(25);
            metalBT_lbl.Text = labelText(26);
            finalBalance_lbl.Text = labelText(27);
            egpFB_lbl.Text = labelText(28);
            metalFB_lbl.Text = labelText(29);

            total_lbl.Text = labelText(30);
            fiscalYear_lbl.Text = labelText(31);
            startDate_lbl.Text = labelText(32);
            endDate_lbl.Text = labelText(33);
            account_lbl.Text = labelText(34);
            accountGroup_lbl.Text = labelText(35);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI402_L1";
        }
    }
}