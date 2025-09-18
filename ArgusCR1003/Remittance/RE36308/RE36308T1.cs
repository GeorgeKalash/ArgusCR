using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;


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

            amoun_data.Text = webObject.record.amount.ToString("N2");
            amountWord_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.amount, 2, Convert.ToInt16(sessionInfo.languageId));

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
