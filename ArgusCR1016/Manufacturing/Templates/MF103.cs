using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1016.Manufacturing.Templates
{
    public partial class MF103 : Reports.BaseReport
    {
        public MF103()
        {
            InitializeComponent();
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.MF103> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.MF103>();

            jobRef_data.Text = webObject.record.jobRef;

            BarCode.Text =  webObject.record.jobRef;


            date_data.Text = webObject.record.date.ToString(sessionInfo.dateFormat);
            orderedby_data.Text = webObject.record.orderedby;
            deliveryDate_data.Text = webObject.record.deliveryDate;

            clientName_data.Text = webObject.record.clientName;
            clientPhone_data.Text = webObject.record.clientPhone;
            clientEmail_data.Text = webObject.record.clientEmail;
            price_data.Text = webObject.record.price.ToString("N2");

            description_data.Text = webObject.record.description;

            designName_data.Text = webObject.record.designName;
            hours_data.Text = webObject.record.hours;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            clientOrder_lbl.Text = labelText(0);

            date_lbl.Text = labelText(1);
            orderedBy_lbl.Text = labelText(2);
            deliveryDate_lbl.Text = labelText(3);

            client_lbl.Text = labelText(4);

            name_lbl.Text = labelText(5);
            tel_lbl.Text = labelText(6);

            price_lbl.Text = labelText(7);
            email_lbl.Text = labelText(8);

            description_lbl.Text = labelText(9);

            ringSize_lbl.Text = labelText(10);
            metalType_lbl.Text = labelText(11);
            metalColor_lbl.Text = labelText(12);

            designName_lbl.Text = labelText(13);
            hours_lbl.Text = labelText(14);
            resinWeight_lbl.Text = labelText(15);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\MF103";
        }
    }
}

