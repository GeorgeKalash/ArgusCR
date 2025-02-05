using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36324
{
    public partial class RE36324T1 : ArgusRPT.BaseReport
    {
        public RE36324T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT103> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT103>();

            QRCode.Text = webObject.record.reference;
            DataSource = webObject.record.paymentDetails;

            date_data.Text = webObject.record.date.ToString(sessionInfo.dateFormat);
            time_data.Text = webObject.record.clockStamp.ToString("HH:mm");
            refNo_data.Text = webObject.record.reference;
            branch_data.Text = webObject.record.plantName;

            trxNo_data.Text = webObject.record.trackingNo;
            amount_data.Text = webObject.record.amount.ToString("N2");
            baseCurRef_data.Text = webObject.record.baseCurrencyRef;

            benName_data.Text = webObject.record.beneficiaryName;
            relation_data.Text = webObject.record.relationName;
            address_data.Text = webObject.record.beneficiaryAddressLine1;
            telNo_data.Text = webObject.record.beneficiaryCellPhone;
            bank_data.Text = webObject.record.beneficiaryBankName;
            accNo_data.Text = webObject.record.beneficiaryAccountRef;
            branch2_data.Text = webObject.record.beneficiaryBankBranchName;
            agentName_data.Text = webObject.record.corName;

            remName_data.Text = webObject.record.clientName + "/" + webObject.record.clientRef;
            nationality_data.Text = webObject.record.remitterNationality;
            telNo2_data.Text = webObject.record.remitterCellPhone;
            idNo_data.Text = webObject.record.remitterIdNo.ToString();

            rate_data.Text = webObject.record.exRate.ToString("N2");
            charge_data.Text = webObject.record.commission.ToString("N2");
            vat_data.Text = webObject.record.vatAmount.ToString("N2");
            total_data.Text = webObject.record.amount.ToString("N2");

            purpose_data.Text = webObject.record.remitterPurpose;
            cashierNo_data.Text = webObject.record.cashAccountRef;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36324T1";
        }
    }
}