using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36323
{
    public partial class RE36323T1 : ArgusRPT.BaseReport
    {
        public RE36323T1()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT201> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT201>();
            QRCode.Text = new KycQrCode(webObject.record.header.reference).ToBase64();
            dateTop_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy"); 
            refNo_data.Text = webObject.record.header.reference;
            branch_data.Text = webObject.record.header.plantName;
            sar_data.Text = webObject.record.header.amount.ToString("N2");
            receivedFrom_data.Text = webObject.record.header.clientName;
            from_data.Text = webObject.record.header.clientName;
            only_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, 1);
            for_data.Text = webObject.record.header.beneficiaryName;
            idType_data.Text = webObject.record.header.idType ;
            expiryDate_data.Text = webObject.record.header.idExpiryDate?.ToString("dd/MM/yyyy");
            nationality_data.Text = webObject.record.header.clientNationality;
            idNo_data.Text = webObject.record.header.idNo;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36323T1";
        }

        private void RE36323T1_BeforePrint(object sender, PrintEventArgs e)
        {

        }
    }
}
