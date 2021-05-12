using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SATRX01 : Reports.BaseReport
    {
        public SATRX01()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return base.dictionaryStore() + "SA103";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            clientName_data.Text = webObject.record.trxHeader.clientName;
            date_data.Text = webObject.record.trxHeader.date.ToString("dd/MM/yy");
            description_data.Text = webObject.record.trxHeader.description;
            phone2_data.Text = webObject.record.quickView.phone2;
            phone3_data.Text = webObject.record.quickView.phone3;
            phone_data.Text = webObject.record.quickView.phone;
            reference_data.Text = webObject.record.trxHeader.reference;
            spRef_data.Text = webObject.record.trxHeader.spRef;
            szName_data.Text = webObject.record.trxHeader.szName;
            if (webObject.record.trxHeader.volume != null)
                volume_data.Text = ((double)webObject.record.trxHeader.volume).ToString("N2");

            base.OnBeforePrint(e);
        }

        private void XrLabel28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}