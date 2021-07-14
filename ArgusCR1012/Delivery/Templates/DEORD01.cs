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

            clientRef_data.Text = webObject.record.header.clientRef; 
            clientName_data.Text = webObject.record.header.clientName;
            contactName_data.Text = webObject.record.shipAddress?.name;  
            clientCellPhone_data.Text = webObject.record.shipAddress?.phone; 

            deliveryNo_data.Text = webObject.record.header.reference; 
            deliveryDate_data.Text = ((DateTime)webObject.record.header.date).ToString(sessionInfo.dateFormat);
            soRef_data.Text = webObject.record.header.soRef;
            spName_data.Text = webObject.record.header.spName;
            spCellPhone_data.Text = webObject.record.header.spCellPhone;

            deliveryLocation_data.Text = string.Format("{0}, {1}", webObject.record.shipAddress?.city,webObject.record.shipAddress?.countryName);
           
            driverName_data.Text = webObject.record.header.driverName;
            driverCellPhone_data.Text = webObject.record.header.driverCellPhone;

            printSignature_lbl.Text = reportSignature();

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            deliveryNote_lbl.Text = labelText(0);
            dlDetails_lbl.Text = labelText(1);
            mTitle_lbl.Text = labelText(2);
            tamdeed_lbl.Text = labelText(3);
        
            customer_lbl.Text = labelText(4);
            clientName_lbl.Text = labelText(5);
            contactName_lbl.Text = labelText(6);
            clientCellPhone_lbl.Text = labelText(7);

            deliveryNo_lbl.Text = labelText(8);
            deliveryDate_lbl.Text = labelText(9);
            soRef_lbl.Text = labelText(10);
            spName_lbl.Text = labelText(11);
            spCellPhone_lbl.Text = labelText(12);

            lineNo_lbl.Text = labelText(13);
            sku_lbl.Text = labelText(14);
            itemName_lbl.Text = labelText(15);
            qty_lbl.Text = labelText(16);
            notes_lbl.Text = labelText(17);

            shipingDeliveryInfo_lbl.Text = labelText(18);
            deliveryLocation_lbl.Text = labelText(19);
            attention_lbl.Text = labelText(20);
            deliveryCellPhone_lbl.Text = labelText(21);
            shippingMode_lbl.Text = labelText(22);
            byTamdeed_lbl.Text = labelText(23);

            vTDeliveryInfo_lbl.Text = labelText(24);
            note_lbl.Text = labelText(25);
            dispatchTime_lbl.Text = labelText(26);
            arrivalTime_lbl.Text = labelText(27);

            preparedBy_lbl.Text = labelText(28);
            driverName_lbl.Text = labelText(29);
            driverCellPhone_lbl.Text = labelText(30);
            driverSig_lbl.Text = labelText(31);

            thankYou_lbl.Text = labelText(32);
            anyQuestion_lbl.Text = labelText(33);
            custAcceptance_lbl.Text = labelText(34);
            authorizedSig_lbl.Text = labelText(35);
            authorizedDate_lbl.Text = labelText(36);

            distributionDriver_lbl.Text = labelText(37);
            bussinessInfo_lbl.Text = labelText(38);
            printSignature_lbl.Text = labelText(39);
            numberpage_lbl.Text = labelText(40);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\DE101";
        }
    }
}
