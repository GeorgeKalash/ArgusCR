using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1000.Sales.Templates
{
    public partial class SATRX03 : Reports.BaseReport
    {
        public SATRX03()
        {
            InitializeComponent();            
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = CreateDataSourceFromText();
            base.OnBeforePrint(e);
        }

        private void Detail_BeforePrint(object sender, PrintEventArgs e)
        {
        }
    }
}