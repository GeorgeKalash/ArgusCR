using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace ArgusCR1003.CurrencyTrading.CT35303
{
    public partial class CT35303T2 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public CT35303T2()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Trading.Reports.CT103> webObject = deserializeGet<ArgusCT_DS.Trading.Reports.CT103>();
            DataSource = webObject.record.items;
            QRCode.Text = webObject.record.header.reference;

            dateTop_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");
            refNo_data.Text = webObject.record.header.reference;
            branch_data.Text = webObject.record.header.plantName;

            corNo_data.Text = webObject.record.header.corRef;
            corName_data.Text = webObject.record.header.corName;
            corCurrencyRef_data.Text = webObject.record.header.corCurrencyRef;
            corCurrencyName_data.Text = webObject.record.header.corCurrencyName;
            //country_data.Text = webObject.record.header.;
            //city_data.Text = webObject.record.header.;

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
            return "CR1003.CT35303T2";
        }
    }
}
