using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.GeneralLedger
{
    public partial class GL301 : ArgusRPT.BaseReport
    {
        public GL301()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return reportTitle_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.GeneralLedger.GL301> obj = deserializeList<ArgusDS.GeneralLedger.GL301>();
            DataSource = obj.list;

            if (Parameters.Count > 0)
                year_param.Text = Parameters[0].Value.ToString();
            if (Parameters.Count > 1)
                startDate_param.Text = Parameters[1].Value.ToString();
            if (Parameters.Count > 2)
                endDate_param.Text = Parameters[2].Value.ToString();
            if (Parameters.Count > 3)
                accountName_param.Text = Parameters[3].Value.ToString();

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

            fiscalYear_lbl.Text = labelText(1);
            startDate_lbl.Text = labelText(2);
            endDate_lbl.Text = labelText(3);

            currencyRef_lbl.Text = labelText(4);
            accountRef_lbl.Text = labelText(5);

            activityType_lbl.Text = labelText(6);
            reference_lbl.Text = labelText(7);
            date_lbl.Text = labelText(8);
            description_lbl.Text = labelText(9);
            costCenter_lbl.Text = labelText(10);
            tpa_lbl.Text = labelText(11);
            currency_lbl.Text = labelText(12);

            amount_lbl.Text = labelText(13);
            debit_lbl.Text = labelText(14);
            credit_lbl.Text = labelText(15);
            balance_lbl.Text = labelText(16);

            base_lbl.Text = labelText(17);
            baseDebit_lbl.Text = labelText(18);
            baseCredit_lbl.Text = labelText(19);
            runningBaseBalance_lbl.Text = labelText(20);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.GL301";
        }
    }
}