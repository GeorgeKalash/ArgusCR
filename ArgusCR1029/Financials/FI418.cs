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
                year_param.Text = Parameters[0].Value.ToString();
                startDate_param.Text = Parameters[1].Value.ToString();
                endDate_param.Text = Parameters[2].Value.ToString();
                accountName_param.Text = Parameters[4].Value.ToString();
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

            amount_lbl.Text = labelText(5);
            debit_lbl.Text = labelText(6);
            credit_lbl.Text = labelText(7);
            balance_lbl.Text = labelText(8);

            base_lbl.Text = labelText(9);
            baseDebit_lbl.Text = labelText(10);
            baseCredit_lbl.Text = labelText(11);
            runningBaseBalance_lbl.Text = labelText(12);

            rate_lbl.Text = labelText(13);

            fiscalYear_lbl.Text = labelText(14);
            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.FI418";
        }
    }
}