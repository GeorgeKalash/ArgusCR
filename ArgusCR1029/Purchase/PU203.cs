using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Purchase
{
    public partial class PU203 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public PU203()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Purchase.InvoiceView> obj = deserializeList<ArgusDS.Purchase.InvoiceView>();
            DataSource = obj.list;


            vendor_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            currency_param.Text = Parameters.Count >  3 ? Parameters[3].Value.ToString() : string.Empty;      

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            rec_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            vendorR_lbl.Text = labelText(4);
            site_lbl.Text = labelText(5);
            pcs_lbl.Text = labelText(6);
            qty_lbl.Text = labelText(7);
            unitCost_lbl.Text = labelText(8);
            subTotal_lbl.Text = labelText(9);
            vat_lbl.Text = labelText(10);
            totalAmount_lbl.Text = labelText(11);
            description_lbl.Text = labelText(12);

            startDate_lbl.Text = labelText(13);
            endDate_lbl.Text = labelText(14);
            currency_lbl.Text = labelText(15);
            vendor_lbl.Text = labelText(16);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.PU203";
        }
    }
}