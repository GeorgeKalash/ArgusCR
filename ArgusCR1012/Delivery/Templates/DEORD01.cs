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
            return deliveryNote_lbl.Text;
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
           
            deliveryLocation_data.Text = string.Format("{0}, {1}", webObject.record.shipAddress?.city,webObject.record.shipAddress?.countryName);
            attention_data.Text = webObject.record.shipAddress?.name; // Attention
            delPhone.Text = webObject.record.shipAddress?.phone; // Del Contact No

            driverName_data.Text = webObject.record.header.driverName; // Driver Name
            printSignature_lbl.Text = reportSignature();

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            deliveryNote_lbl.Text = labelText(0);

            customer_lbl.Text = labelText(1);
            clientName_lbl.Text = labelText(2);
            contactName_lbl.Text = labelText(3);
            contactNo_lbl.Text = labelText(4);

            deliveryNo_lbl.Text = labelText(5);
            deliveryDate_lbl.Text = labelText(6);
            reference_lbl.Text = labelText(7);
            spName_lbl.Text = labelText(8);
            spCellPhone_lbl.Text = labelText(9);

            lineNo_lbl.Text = labelText(10);
            sku_lbl.Text = labelText(11);
            itemName_lbl.Text = labelText(12);
            qty_lbl.Text = labelText(13);
            remarks_lbl.Text = labelText(14);

            shipingDeliveryInfo_lbl.Text = labelText(15);
            deliveryLocation_lbl.Text = labelText(16);
            attention_lbl.Text = labelText(17);
            mobileNo_lbl.Text = labelText(18);
            shippingMode_lbl.Text = labelText(19);

            vTDeliveryInfo_lbl.Text = labelText(20);
            note_lbl.Text = labelText(21);
            approximate_lbl.Text = labelText(22);

            prepared_lbl.Text = labelText(23);
            driverName_lbl.Text = labelText(24);
            driverContactNo_lbl.Text = labelText(25);
            driverSig_lbl.Text = labelText(26);

            thanks_lbl.Text = labelText(27);
            anyQuestion_lbl.Text = labelText(28);
            custAcceptance_lbl.Text = labelText(29);
            authorizedSig_lbl.Text = labelText(30);
            authorizedDate_lbl.Text = labelText(31);

            distributionDriver_lbl.Text = labelText(32);
            printSignature_lbl.Text = labelText(33);
            numberpage_lbl.Text = labelText(34);

            mTitle_lbl.Text = labelText(35);
            tamdeed_lbl.Text = labelText(36);
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
