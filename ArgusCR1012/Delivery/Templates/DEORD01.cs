using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Delivery;
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
            SharedClasses.JsonProtocol.GetStructure<OrderItem> webObject = deserializeGet<OrderItem>();
            DataSource = webObject.record;
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
