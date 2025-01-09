
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36204
{
    public partial class FI31305T1 : ArgusRPT.BaseReport
    {
        public FI31305T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI102> webObject = deserializeGet<ArgusDS.Financials.Reports.FI102>();
              dateTop_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy"); ;
                time_data.Text = webObject.record.clientMaster.categoryName;
                refNo_data.Text = webObject.record.clientRemittance.date.ToString("dd/MM/yyyy"); ;
                branch_data.Text = webObject.record.clientRemittance.plantName;
                taxNo_data.Text = webObject.record.clientIndividual.fl_firstName;
                sar_data.Text = webObject.record.PVExpenseView.amount;
                payTo_data.Text = webObject.record.clientRemittance.genderName;
                only_data.Text = webObject.record.clientMaster.nationalityName;

                date_data.Text = webObject.record.clientIDView.idtName;
                bank_data.Text = webObject.record.clientIDView.idNo;
                checkNo_data.Text = webObject.record.clientIDView.idCountryName;

                for_data.Text = webObject.record.clientIDView.idCityName;

                recieptName_data.Text = webObject.record.clientIDView.idExpiryDate.ToString("dd/MM/yyyy"); ;

                idType_data.Text = webObject.record.clientIDView.idIssueDate?.ToString("dd/MM/yyyy") ?? string.Empty;

                nationality_data.Text = webObject.record.clientRemittance.educationLevelName;
                expiryDate_data.Text = webObject.record.clientRemittance.statusName;
                idNo_data.Text = webObject.record.clientIndividual.sponsorName;
        
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.FI31305T1";
        }

        private void xrLabel16_BeforePrint(object sender, PrintEventArgs e)
        {

        }

        private void xrLabel15_BeforePrint(object sender, PrintEventArgs e)
        {

        }

        private void xrLabel14_BeforePrint(object sender, PrintEventArgs e)
        {

        }
    }
}