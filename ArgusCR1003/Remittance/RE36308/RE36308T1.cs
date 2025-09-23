using System;
using System.Drawing.Printing;



namespace ArgusCR1003.Remittance.RE36308
{
    public partial class RE36308T1 : ArgusRPT.BaseReport
    {
        public RE36308T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT105> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT105>();

            QRCode.Text = webObject.record.reference;

            dateTop_data.Text = webObject.record.date.ToString("dd/MM/yyyy");
            time_data.Text = webObject.record.date.ToString("hh:mm tt");
            //number_data.Text = webObject.record.header.plantName;

            reference_data.Text = webObject.record.reference;
            outwardsOrder_data.Text = webObject.record.owtRef;
            date_data.Text = webObject.record.date.ToString("dd/MM/yyyy");

            amount_data.Text = webObject.record.lcAmount.ToString("N2");
            currencyRef_data.Text = webObject.record.currencyName;
            amountWord_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.lcAmount, 2, Convert.ToInt16(sessionInfo.languageId));
            clientName_data.Text = webObject.record.clientName;

            oldBeneficiaryName_data.Text = webObject.record.oldBeneficiaryName;
            newBeneficiaryName_data.Text = webObject.record.newBeneficiaryName;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36308T1";
        }

    }
}
