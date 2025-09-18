using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace ArgusCR1003.CurrencyTrading.CT35301
{
    public partial class CT35301T1 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public CT35301T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Trading.Reports.CT102> webObject = deserializeGet<ArgusCT_DS.Trading.Reports.CT102>();
            DataSource = webObject.record.items;
            QRCode.Text = webObject.record.header.reference;

            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");
            time_data.Text = webObject.record.header.date.ToString("hh:mm tt");
            refNo_data.Text = webObject.record.header.reference;
            branch_data.Text = webObject.record.header.plantName;
            valueDate_data.Text = webObject.record.header.deliveryDate?.ToString("dd/MM/yyyy");

         //   fromCity_data.Text = webObject.record.header.reference;
        //    toCity_data.Text = webObject.record.header.reference;
         //   exportCarrier_data.Text = webObject.record.header.reference;
         //   awbNo_data.Text = webObject.record.header.reference;
         //   noOfPackages_data.Text = webObject.record.header.reference;
         //   grossWeight_data.Text = webObject.record.header.reference;
         //   flightNumber_data.Text = webObject.record.header.reference;

         //   name_data.Text = webObject.record.header.reference;
         //   address_data.Text = webObject.record.header.reference;
            city_data.Text = webObject.record.header.reference;
            country_data.Text = webObject.record.header.reference;
           // fax_data.Text = webObject.record.header.reference;
           // tel_data.Text = webObject.record.header.reference;
            //eMail_data.Text = webObject.record.header.reference;

            base.OnBeforePrint(e);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.CT35301T1";
        }
    }
}
