using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace ArgusCR1003.Remittance.RE36313
{
    public partial class RE36313T1 : ArgusRPT.BaseReport
    {
        public RE36313T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT104> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT104>();

            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            time_data.Text = webObject.record.date.ToString("HH:mm");
            refNo_data.Text = webObject.record.reference;
            branch_data.Text = webObject.record.plantName;
         // tax_data.Text = webObject.record.

            clientRef_data.Text = webObject.record.clientRef;
            clientName_data.Text = webObject.record.clientName;
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.baseAmount, 2, Convert.ToInt16(sessionInfo.languageId));
            nationality_data.Text = webObject.record.nationality;
            phoneNo_data.Text = webObject.record.cellPhone;
            nationalityNo_data.Text = webObject.record.idNo;
       //    payNo_data.Text = webObject.record.reference;
            idType_data.Text = webObject.record.idType;
            purpose_data.Text = webObject.record.purposeOfExchange;
            idExpDate_data.Text = webObject.record.idExpiryDate?.ToString("dd/MM/yyyy");
            andThatFor_data.Text = webObject.record.reference;

            amount_data.Text = webObject.record.baseAmount.ToString("N2");
            senderName_data.Text = webObject.record.senderName;

            QRCode.Text = webObject.record.reference;
            cashierSignature_data.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36313T1";
        }

    }
}
