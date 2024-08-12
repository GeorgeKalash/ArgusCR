using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36301
{
    public partial class RE36301T1 : ArgusRPT.BaseReport
    {
        public RE36301T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT101> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT101>();
   
            date_data.Text = webObject.record.date.ToString(sessionInfo.dateFormat);
            time_data.Text = webObject.record.date.ToString("HH:mm");
            refNo_data.Text = webObject.record.reference;
            branch_data.Text = webObject.record.plantName;

            trxNo_data.Text = webObject.record.recordId.ToString();
            amount_data.Text = webObject.record.amount.ToString("N2"); 

            benName_data.Text = webObject.record.beneficiaryName;
            address_data.Text = webObject.record.countryName;
            telNo_data.Text = webObject.record.beneficiaryCellPhone;
            bank_data.Text = webObject.record.bankName;
            accNo_data.Text = webObject.record.accountNo;
            branch2_data.Text = webObject.record.plantName;
            agentName_data.Text = webObject.record.agentName;

            remName_data.Text = webObject.record.clientName + "/" + webObject.record.clientRef;
            nationality_data.Text = webObject.record.clientNationalityName;
            telNo2_data.Text = webObject.record.cellPhone;
            idNo_data.Text = webObject.record.clientId.ToString();

           // payMode_data
           // cashReceived_data
          //  balancePaid_data

         //   rate_data
        //    charge_data
       //     vat_data
        //    total_data

     //       purpose_data
      //      cashierNo_data

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36301T1";
        }

    }
}