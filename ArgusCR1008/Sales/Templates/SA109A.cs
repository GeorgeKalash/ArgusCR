using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1008.Sales.Templates
{
    public partial class SA109A: ArgusRPT.BaseReport
    {
        public SA109A ()
        {
            InitializeComponent();            
        }

        protected override string dictionaryStore()
        {
            return "CR1008.SATRX01";
        }

        protected override void labelsText()
        {
            base.labelsText();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Delivery.Reports.DE103> webObject = deserializeList<ArgusDS.Delivery.Reports.DE103>();
            DataSource = webObject.list;


         //   phone2_data.Text = webObject.record.quickView.phone2;
          //  phone3_data.Text = webObject.record.quickView.phone3;
          //  phone_data.Text = webObject.record.quickView.phone;

           // spRef_data.Text = webObject.record.trxHeader.spRef;
          //  szName_data.Text = webObject.record.trxHeader.szName;


            base.OnBeforePrint(e);
        }

        private void XrLabel28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}