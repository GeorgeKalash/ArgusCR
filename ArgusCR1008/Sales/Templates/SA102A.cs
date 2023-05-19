using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SA102A : ArgusRPT.BaseReport
    {
        public SA102A()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SA102";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
  SharedClasses.JsonProtocol.GetStructure<OrderPrintLayout> webObject = deserializeGet<OrderPrintLayout>();
            DataSource = webObject.record.items;

            amount_data.Text = webObject.record.header.amount.ToString("N3");
            clientName_data.Text = webObject.record.header.clientName;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yy");
            description_data.Text = webObject.record.header.description;

            phone_data.Text = webObject.record.shipAddress?.phone;
            phone2_data.Text = webObject.record.shipAddress?.phone2;
            phone3_data.Text = webObject.record.shipAddress?.phone3;

            reference_data.Text = webObject.record.header.reference;
            spRef_data.Text = webObject.record.header.spRef;
            szName_data.Text = webObject.record.header.szName;
            if (webObject.record.header.volume != null)
                volume_data.Text = ((double)webObject.record.header.volume).ToString("N2");

            base.OnBeforePrint(e);
        }

        private void XrLabel28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}