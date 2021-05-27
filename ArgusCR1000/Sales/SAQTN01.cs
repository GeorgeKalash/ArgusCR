using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1000.Sales.Templates
{
    public partial class SAQTN01 : Reports.BaseReport
    {
        public SAQTN01()
        {
            InitializeComponent();           
        }
        protected override string dictionaryStore()
        {
            return base.dictionaryStore() + "SA101";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();
            DataSource = webObject.record.items;
            tdAmount_data.Text = webObject.record.header.tdAmount != null ? ((double)webObject.record.header.tdAmount).ToString("N0") : string.Empty;
            amount_data.Text = webObject.record.header.amount.ToString("N0");
            subtotal_data.Text = webObject.record.header.subtotal.ToString("N0");
            clientRef_data.Text = webObject.record.header.clientRef;
            currencyRef_data.Text = webObject.record.header.currencyName;
            clientName_data.Text = webObject.record.header.clientName;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yy");
            description_data.Text = webObject.record.header.description;
            reference_data.Text = webObject.record.header.reference;
            address_data.Text = webObject.record.billAddress.street1 + "\r\n" + webObject.record.billAddress.city + "\r\n" + webObject.record.billAddress.countryName;
            base.OnBeforePrint(e);
        }
    }
}
