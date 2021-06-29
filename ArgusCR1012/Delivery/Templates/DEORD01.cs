using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Delivery.Reports;
using ArgusDS.Sales.Reports;

namespace ArgusCR1012.Delivery.Templates
{
    public partial class DEORD01 : Reports.BaseReport
    {

        int itemsCounter = 1;
        public DEORD01()
        {
            InitializeComponent();
        }


        protected override string reportName()
        {
            return dlNotelbl.Text;
        }


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Delivery.Reports.OrderPrintLayout> webObject = deserializeGet<ArgusDS.Delivery.Reports.OrderPrintLayout>();
            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.shipAddress?.name;  // Customer
            contactName_data.Text = webObject.record.header.clientName; // Contact Name
            contactNo_data.Text = webObject.record.shipAddress?.phone; // Contact No 

            deliveryNo_data.Text = webObject.record.header.reference; // del reference
            deliveryDate_data.Text = ((DateTime)webObject.record.header.date).ToString(sessionInfo.dateFormat); // del date
            reference_data.Text = webObject.record.header.soRef; // SO reference



            delLoc_data.Text = string.Format("{0}, {1}", webObject.record.shipAddress?.city,webObject.record.shipAddress?.countryName);
            attention_data.Text = webObject.record.shipAddress?.name; // Attention
            delPhone.Text = webObject.record.shipAddress?.phone; // Del Contact No


            driverName_data.Text = webObject.record.header.driverName; // Driver Name
            printSignature.Text = reportSignature();






            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            sku_lbl.Text = labelText(0);
            itemName_lbl.Text = labelText(1);
            qty_lbl.Text = labelText(2);
            remarks_lbl.Text = labelText(3);
            lineNo_lbl.Text = labelText(4);

            mTitle_lbl.Text = labelText(5);
            tamdeed_lbl.Text = labelText(6);
            dlNotelbl.Text = labelText(7);
            customer_lbl.Text = labelText(8);
            customer2_lbl.Text = labelText(8);
            contactName_lbl.Text = labelText(9);
            contactNo2_lbl.Text = labelText(9);

            contactNo_lbl.Text = labelText(10);
            delNo_lbl.Text = labelText(11);
            date_lbl.Text = labelText(12);
            salesON_lbl.Text = labelText(13);
            spName_lbl.Text = labelText(14);

            SDI_lbl.Text = labelText(15);
            delLoc_lbl.Text = labelText(16);
            att_lbl.Text = labelText(17);
            mobileNo_lbl.Text = labelText(18);
            shipM_lbl.Text = labelText(19);

            VTD_lbl.Text = labelText(20);
            note_lbl.Text = labelText(21);
            prep_lbl.Text = labelText(22);
            dName_lbl.Text = labelText(23);
            driverContact_lbl.Text = labelText(24);

            driverSig_lbl.Text = labelText(25);
            tu_lbl.Text = labelText(26);
            custAcc_lbl.Text = labelText(27);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            xrTableCell14.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\DE101";
        }
    }
}
