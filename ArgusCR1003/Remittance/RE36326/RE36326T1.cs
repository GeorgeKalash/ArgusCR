using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36326
{
    public partial class RE36326T1 : ArgusRPT.BaseReport
    {
        public RE36326T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT107> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT107>();

            QRCode.Text = webObject.record.reference;

            datetime_data.Text = webObject.record.returnDate.ToString("hh:mm tt") + "-" + webObject.record.returnDate.ToString(sessionInfo.dateFormat);
            refNo_data.Text = webObject.record.returnRef;
            branch_data.Text = webObject.record.branchName;
            vatNo_data.Text = webObject.record.vatNo;
            trxNo_data.Text = webObject.record.returnTransferNo;

            benName_data.Text = webObject.record.benName;
            address_data.Text = webObject.record.benAddress;
            telNo_data.Text = webObject.record.benTelNo;
            bank_data.Text = webObject.record.benBankName;
            accNo_data.Text = webObject.record.benAcNo;
            branch2_data.Text = webObject.record.benBranch;
            agentName_data.Text = webObject.record.benAgentName;

            remName_data.Text = webObject.record.remitterName;
            nationality_data.Text = webObject.record.remitterNationality;
            string phoneNumber = webObject.record.remitterTelNo;
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
            purpose_data.Text = webObject.record.remitterPurpose;

            currency_data.Text = webObject.record.paymentCurrency;
            fcAmount_data.Text = webObject.record.paymentFcAmount.ToString("N2");
            rate_data.Text = webObject.record.paymentRate.ToString("N2");
            lcAmount_data.Text = webObject.record.paymentLcAmount.ToString("N2");
            charge_data.Text = webObject.record.paymentCharge.ToString("N2");
            discout_data.Text = webObject.record.paymentDiscount.ToString("N2");
            vat_data.Text = webObject.record.paymentVat.ToString("N2");
            total_data.Text = webObject.record.paymentTotal.ToString("N2");
            refundAm_data.Text = webObject.record.refundAmount.ToString("N2");
            refundCharge_data.Text = webObject.record.refundCharge.ToString("N2");
            refundTot_data.Text = webObject.record.refundTotal.ToString("N2");
            refundVat_data.Text = webObject.record.refundVat?.ToString("N2");

            taxL_data.Text = webObject.record?.taxPercent?.ToString("N2") + "%";
            taxR_data.Text = webObject.record?.taxPercent?.ToString("N2") + "%";
            payDetVatPerc_data.Text = webObject.record?.taxPercent?.ToString("N2") + "%";

            total_text.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.refundTotal, 2, 2);
            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36326T1";
        }
    }
}