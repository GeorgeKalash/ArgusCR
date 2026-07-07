using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using ArgusDS.Financials;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.Financials
{
    public partial class FI418 : ArgusRPT.BaseReport
    {
        public FI418()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Financials.Reports.FI418> obj = deserializeList<ArgusDS.Financials.Reports.FI418>();
            DataSource = obj.list;

            if (Parameters.Count > 0)
            {
                fiscalYear_param.Text = Parameters[0].Value.ToString();
                startDate_param.Text = Parameters[1].Value.ToString();
                endDate_param.Text = Parameters[2].Value.ToString();
                account_param.Text = Parameters[3].Value.ToString();
                accountGroup_param.Text = Parameters[4].Value.ToString();
                salesPerson_param.Text = Parameters[5].Value.ToString();
                currency_param.Text = Parameters[6].Value.ToString();

                accounBalance_param.Text = Parameters[7].Value.ToString();
                accountType_param.Text = Parameters[8].Value.ToString();
                plant_param.Text = Parameters[9].Value.ToString();
                plantGroup_param.Text = Parameters[10].Value.ToString();
                saleZone_param.Text = Parameters[11].Value.ToString();
                clientGroup_param.Text = Parameters[12].Value.ToString();
            }

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyInfoName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }

            printSignature.Text = reportSignature();
            date_data.TextFormatString = dateFormat();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            reportTitle_lbl.Text = labelText(0);

            functionName_lbl.Text = labelText(1);
            docRef_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            description_lbl.Text = labelText(4);
            currency_lbl.Text = labelText(5);

            amount_lbl.Text = labelText(6);
            debit_lbl.Text = labelText(7);
            credit_lbl.Text = labelText(8);
            balance_lbl.Text = labelText(9);

            base_lbl.Text = labelText(10);
            baseDebit_lbl.Text = labelText(11);
            baseCredit_lbl.Text = labelText(12);
            runningBaseBalance_lbl.Text = labelText(13);

            rate_lbl.Text = labelText(14);

            subTotal_lbl.Text = labelText(15);
            grandTotal_lbl.Text = labelText(16);

            fiscalYear_lbl.Text = labelText(17);
            startDate_lbl.Text = labelText(18);
            endDate_lbl.Text = labelText(19);
            account_lbl.Text = labelText(20);
            accountGroup_lbl.Text = labelText(21);
            salesPerson_lbl.Text = labelText(22);
            currencyParam_lbl.Text = labelText(23);

            accountBalance_lbl.Text = labelText(24);
            accountType_lbl.Text = labelText(25);
            plant_lbl.Text = labelText(26);
            plantGroup_lbl.Text = labelText(27);
            saleZone_lbl.Text = labelText(28);
            clientGroup_lbl.Text = labelText(29);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI418";
        }
    }
}