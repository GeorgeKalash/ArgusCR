using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36308
{
    public partial class RE36308T2 : ArgusRPT.BaseReport
    {
        public RE36308T2()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT105> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT105>();

            dateAndTime_data.Text = webObject.record.date.ToString("dd/MM/yyyy hh:mm tt");
            branch_data.Text = webObject.record.oldBeneficiaryBranchName;
            vatReg_data.Text = webObject.record.vatNo;
            refNo_data.Text = webObject.record.reference;
            transferNo_data.Text = webObject.record.transferNo;

            benName_data.Text = webObject.record.oldBeneficiaryName;
            address_data.Text = webObject.record.oldBeneficiaryAddressLine1;
            telNo_data.Text = webObject.record.oldBeneficiaryCellPhone;
            agentName_data.Text = webObject.record.oldBeneficiaryAgentName;
            bank_data.Text = webObject.record.oldBeneficiaryBankName;
            accNo_data.Text = webObject.record.oldBeneficiaryAccountRef;
            branchBB_data.Text = webObject.record.oldBeneficiaryBranchName;

            benNameAfter_data.Text = webObject.record.newBeneficiaryName;
            addressAfter_data.Text = webObject.record.newBeneficiaryAddressLine1;
            telNoAfter_data.Text = webObject.record.newBeneficiaryCellPhone;
            agentNameAfter_data.Text = webObject.record.newBeneficiaryAgentName;
            bankAfter_data.Text = webObject.record.newBeneficiaryBankName;
            accNoAfter_data.Text = webObject.record.newBeneficiaryAccountRef;
            branchBBAfter_data.Text = webObject.record.newBeneficiaryBranchName;

            remitterName_data.Text = webObject.record.remitterRef;
            nationality_data.Text = webObject.record.remitterNationality;
            telNoRemitter_data.Text = webObject.record.remitterCellPhone;
            idNoRemitter_data.Text = webObject.record.remitterIdNo;
            idExp_data.Text = webObject.record.remitterIdExpiry.ToString();
            purpose_data.Text = webObject.record.remitterPurpose;
            sourceOfFunds_data.Text = webObject.record.remitterSource;
            relation_data.Text = webObject.record.remitterRelation;

            currency_data.Text = webObject.record.currencyName;
            amount_data.Text = webObject.record.lcAmount.ToString();
            charge_data.Text = webObject.record.commission.ToString();
            rate_data.Text = webObject.record.rate.ToString();
            tdAmount_data.Text = webObject.record.fcAmount.ToString();
            vat_data.Text = webObject.record.vat.ToString();
            taxPerc_data.Text = webObject.record.vatNo;
            total_data.Text = webObject.record.total.ToString();

            QRCode.Text = webObject.record.reference;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36308T2";
        }

    }
}