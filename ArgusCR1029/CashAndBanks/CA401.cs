using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.CashAndBanks
{
    public partial class CA401 : ArgusRPT.BaseReport
    {
        public CA401()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Financials.Reports.FI401> obj = deserializeList <ArgusDS.Financials.Reports.FI401> ();
            DataSource = obj.list;

            if (Parameters.Count > 0)
                year_param.Text = Parameters[0].Value.ToString();
            if (Parameters.Count > 1)
                startDate_param.Text = Parameters[1].Value.ToString();
            if (Parameters.Count > 2)
                endDate_param.Text = Parameters[2].Value.ToString();
            if (Parameters.Count > 3)
                accountName_param.Text = Parameters[3].Value.ToString();

            startDate2_param.Text = Parameters[1].Value.ToString();
            if (Parameters.Count > 2)
                endDate2_param.Text = Parameters[2].Value.ToString();
            if (Parameters.Count > 3)

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

            date_lbl.Text = labelText(1);
            docRef_lbl.Text = labelText(2);
            description_lbl.Text = labelText(3);
            debit_lbl.Text = labelText(4);
            credit_lbl.Text = labelText(5);
            balance_lbl.Text = labelText(6);

            fiscalYear_lbl.Text = labelText(7);
            startDate_lbl.Text = labelText(8);
            endDate_lbl.Text = labelText(9);
            currencyRef_lbl.Text = labelText(10);
            accountRef_lbl.Text = labelText(11);

            functionName_lbl.Text = labelText(12);
            extraInfo_lbl.Text = labelText(13);
        }
        protected override string dictionaryStore()
        {
            return "CA401";
        }
    }
}