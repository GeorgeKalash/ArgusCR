using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36324
{
    public partial class RE36324T2 : ArgusRPT.BaseReport
    {
        public RE36324T2()
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

            benName_data.Text = webObject.record.beneficiaryName;
            address_data.Text = webObject.record.beneficiaryAddressLine1;
            telNo_data.Text = webObject.record.beneficiaryCellPhone;
            bank_data.Text = webObject.record.beneficiaryBankName;
            accNo_data.Text = webObject.record.beneficiaryAccountRef;
            branch2_data.Text = webObject.record.beneficiaryBankBranchName;
            agentName_data.Text = webObject.record.corName;

            remName_data.Text = webObject.record.clientFullName + "/" + webObject.record.clientRef;
            nationality_data.Text = webObject.record.remitterNationality;
            string phoneNumber = webObject.record.remitterCellPhone;
            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length > 4)
            {
                telNo2_data.Text = new string('*', phoneNumber.Length - 4) + phoneNumber.Substring(phoneNumber.Length - 4);
            }
            else
            {
                telNo2_data.Text = phoneNumber;
            }
            string idNumber = webObject.record.remitterIdNo.ToString();
            if (!string.IsNullOrEmpty(idNumber) && idNumber.Length > 4)
            {
                idNo_data.Text = new string('*', idNumber.Length - 4) + idNumber.Substring(idNumber.Length - 4);
            }
            else
            {
                idNo_data.Text = idNumber;
            }
            idExp_data.Text = webObject.record?.remitterIdExpiryDate?.ToString(sessionInfo.dateFormat);
            purpose_data.Text = webObject.record.remitterPurpose;
            sof_data.Text = webObject.record.remitterSourceOfIncome;
            relation_data.Text = webObject.record.relationName;

            fcAmount_data.Text = webObject.record.fcAmount.ToString("N2");
            charge_data.Text = webObject.record.commission.ToString("N2");
            rate_data.Text = webObject.record.exRate.ToString("N2");
            lcAmount_data.Text = webObject.record.lcAmount.ToString("N2");
            tdAmount_data.Text = webObject.record?.tdAmount?.ToString("N2");
            vat_data.Text = webObject.record.vatAmount.ToString("N2");
            total_data.Text = webObject.record.amount.ToString("N2");
            fcAmmCurr_data.Text = webObject.record.currencyRef;
            chargeBaseCur_data.Text = webObject.record.baseCurrencyRef;
            amountBaseCur_data.Text = webObject.record.baseCurrencyRef;
            totBaseCur_data.Text = webObject.record.baseCurrencyRef;
            taxR_data.Text = webObject.record?.taxPercent?.ToString("N2")+"%";
            taxL_data.Text = webObject.record?.taxPercent?.ToString("N2") + "%";

            accName_data.Text = webObject.record.cashAccountName;
            accRef_data.Text = "[ " + webObject.record.cashAccountRef+ " ]";

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36324T2";
        }
    }
}