using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1010.Delivery
{
    public partial class DE52301 : ArgusRPT.BaseReport
    {
        public DE52301()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Delivery.Reports.OrderPrintLayout> webObject = deserializeGet<ArgusDS.Delivery.Reports.OrderPrintLayout>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;

            clientRef_data.Text = webObject.record.orderView.reference;
            clientName_data.Text = webObject.record.orderView.clientName;
            phoneNumber_data.Text = webObject.record.shipAddress?.phone;
            //szName_data.Text = webObject.record.clientView.szName;

            invRef_data.Text = webObject.record.orderView.reference;
            invDate_data.Text = webObject.record.orderView.date.ToString(sessionInfo.dateFormat);

            driverName_data.Text = webObject.record.orderView.driverName;
            camionPlatNumber_data.Text = webObject.record.orderView.vehiclePlateNo;

            clientNameSig_data.Text = webObject.record.orderView.clientName;

            notes_data.Text = webObject.record.orderView.notes;

            printSignature.Text = DateTime.Now.ToString("dd/MM/yyyy") + " à " + DateTime.Now.ToString("hh:mm");
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1010.DE52301";
        }
    }
}