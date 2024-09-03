using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace ArgusCR1012.Delivery.Templates
{
    public partial class DEORD01 : ArgusRPT.BaseReport
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

            //  ArgusDS.Delivery.OrderItemView firstRow = webObject.record.items[0];
            //soRef_data.Text = firstRow.soRef;

            soRef_data.Text = webObject.record.orderView.soRef;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            clientRef_data.Text = webObject.record.orderView.clientRef; 
            clientName_data.Text = webObject.record.orderView.clientName;
            contactName_data.Text = webObject.record.shipAddress?.name;  
            clientCellPhone_data.Text = webObject.record.shipAddress?.phone; 

            deliveryNo_data.Text = webObject.record.orderView.reference; 
            deliveryDate_data.Text = ((DateTime)webObject.record.orderView.date).ToString(sessionInfo.dateFormat);
    
            spName_data.Text = webObject.record.orderView.spName;
            spCellPhone_data.Text = webObject.record.orderView.spCellPhone;

            deliveryLocation_data.Text = string.Format("{0}, {1}", webObject.record.shipAddress?.city,webObject.record.shipAddress?.countryName);
           
            driverName_data.Text = webObject.record.orderView.driverName;
            driverCellPhone_data.Text = webObject.record.orderView.driverCellPhone;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            deliveryNote_lbl.Text = labelText(0);

            tamdeedVatNo_lbl.Text = labelText(1);

            customer_lbl.Text = labelText(2);
            clientName_lbl.Text = labelText(3);
            contactName_lbl.Text = labelText(4);
            clientCellPhone_lbl.Text = labelText(5);

            deliveryNo_lbl.Text = labelText(6);
            deliveryDate_lbl.Text = labelText(7);
            soRef_lbl.Text = labelText(8);
            spName_lbl.Text = labelText(9);
            spCellPhone_lbl.Text = labelText(10);

            lineNo_lbl.Text = labelText(11);
            sku_lbl.Text = labelText(12);
            itemName_lbl.Text = labelText(13);
            qty_lbl.Text = labelText(14);
            notes_lbl.Text = labelText(15);

            shipingDeliveryInfo_lbl.Text = labelText(16);
            deliveryLocation_lbl.Text = labelText(17);
            attention_lbl.Text = labelText(18);
            deliveryCellPhone_lbl.Text = labelText(19);
            shippingMode_lbl.Text = labelText(20);
            byTamdeed_lbl.Text = labelText(21);

            vTDeliveryInfo_lbl.Text = labelText(22);
            note_lbl.Text = labelText(23);
            dispatchTime_lbl.Text = labelText(24);
            arrivalTime_lbl.Text = labelText(25);

            preparedBy_lbl.Text = labelText(26);
            driverName_lbl.Text = labelText(27);
            driverCellPhone_lbl.Text = labelText(28);
            driverSig_lbl.Text = labelText(29);

            thankYou_lbl.Text = labelText(30);
            anyQuestion_lbl.Text = labelText(31);
            custAcceptance_lbl.Text = labelText(32);
            authorizedSig_lbl.Text = labelText(33);
            authorizedDate_lbl.Text = labelText(34);

            distributionDriver_lbl.Text = labelText(35);
            bussinessInfo_lbl.Text = labelText(36);
            paper_lbl.Text = labelText(37);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override string dictionaryStore()
        {
            return "CR1012.DE101";
        }
    }
}