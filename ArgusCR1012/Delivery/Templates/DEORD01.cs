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


        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Delivery.Reports.OrderPrintLayout> webObject = deserializeGet<ArgusDS.Delivery.Reports.OrderPrintLayout>();
            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.shipAddress?.name;  // Customer
            billAddressName_data.Text = webObject.record.header.clientName; // Contact Name
            billAddressPhone_data.Text = webObject.record.shipAddress?.phone; // Contact No 

            deliveryNo_data.Text = webObject.record.header.reference; // del reference
            deliveryDate_data.Text = ((DateTime)webObject.record.header.date).ToString(sessionInfo.dateFormat); // del date
            reference_data.Text = webObject.record.header.soRef; // SO reference




            delLoc_data.Text = webObject.record.shipAddress.city;
            attention_data.Text = webObject.record.shipAddress.name;
            delPhone.Text = webObject.record.shipAddress?.phone;


            driverName_data.Text = webObject.record.header.driverName;






            base.OnBeforePrint(e);
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
