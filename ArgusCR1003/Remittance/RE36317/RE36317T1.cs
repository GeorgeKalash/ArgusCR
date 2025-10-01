using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36317
{
    public partial class RE36317T1 : ArgusRPT.BaseReport
    {
        public RE36317T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT106> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT106>();

            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            time_data.Text = webObject.record.date.ToString("HH:mm");
            refNo_data.Text = webObject.record.reference;
            branch_data.Text = webObject.record.plantName;
            transferNo_data.Text = webObject.record.owt_reference;
            //tax_data.Text = webObject.record.;

            benName_data.Text = webObject.record.beneficiaryName;
            address_data.Text = webObject.record.beneficiaryAddressLine1;
            telNo_data.Text = webObject.record.beneficiaryCellPhone;
            accDet_data.Text = webObject.record.beneficiaryAccountRef;
            bank_data.Text = webObject.record.beneficiaryBank;
            accNo_data.Text = webObject.record.beneficiaryIBAN;
            benBranch_data.Text = webObject.record.beneficiaryBankBranch;

            remName_data.Text = webObject.record.remitterName + "/" + webObject.record.remitterRef;
            remNat_data.Text = webObject.record.remitterNationality;
            remNo_data.Text = webObject.record.remitterCellPhone;
            idDet_data.Text = webObject.record.remitterIdType;
            idDate_data.Text = webObject.record.remitterIdExpiryDate?.ToString("dd/MM/yyyy");
            remPurpose_data.Text = webObject.record.remitterPurpose;
            remSou_data.Text = webObject.record.remitterSource;

            amount_data.Text = webObject.record.transferFcAmount.ToString("N2");
            amount2_data.Text = webObject.record.transferLcAmount.ToString("N2");
            charge_data.Text = charge2_data.Text = webObject.record.transferCommission.ToString("N2");
            rate_data.Text = webObject.record.transferExRate.ToString("N2");
            discout_data.Text = webObject.record.transferTdAmount?.ToString("N2");
            vatPct_data.Text = webObject.record.transferTaxPercent?.ToString("N2");
            vat_data.Text = webObject.record.transferVatAmount.ToString("N2");
            total_data.Text = webObject.record.transferAmount.ToString("N2");

            refundAm_data.Text = webObject.record.lcAmount.ToString("N2");
            refCharge_data.Text = webObject.record.commission.ToString("N2");
            vatPctR_data.Text = vatPctL_data.Text =  webObject.record.returnTaxPercent?.ToString("N2");
            refVat_data.Text = webObject.record.vatAmount?.ToString("N2");
            refundTot_data.Text = webObject.record.totalCharge.ToString("N2");


            QRCode.Text = webObject.record.reference;
            cashierSignature_data.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36317T1";
        }
    }
}
