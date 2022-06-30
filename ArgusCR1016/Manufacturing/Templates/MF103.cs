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
            orderedby_data.Text = webObject.record.spName;

            if (webObject.record.deliveryDate != null)
            {
                deliveryDate_data.Text = ((DateTime)webObject.record.deliveryDate).ToString(sessionInfo.dateFormat);
            }

            clientName_data.Text = webObject.record.clientName;
            clientPhone_data.Text = webObject.record.clientPhone;
            clientEmail_data.Text = webObject.record.clientEmail;
           

            description_data.Text = webObject.record.description;

            designName_data.Text = webObject.record.designName;

            if (webObject.record.userDefinedLists.ContainsKey(10))
            {
                ringSize_data.Text = webObject.record.userDefinedLists[10];
            }

            if (webObject.record.userDefinedLists.ContainsKey(12))
            {
                metalType_data.Text = webObject.record.userDefinedLists[12];
            }

            if (webObject.record.userDefinedLists.ContainsKey(13))
            {
                metalColor_data.Text = webObject.record.userDefinedLists[13];
            }

            //ringSize_data = property 10 / metalType_data = property 12 / metalColor_data = property 13 // 

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

