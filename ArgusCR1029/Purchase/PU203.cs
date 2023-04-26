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

            vendoref_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            currency_lbl.Text = Parameters.Count >  3 ? Parameters[3].Value.ToString() : string.Empty;
            

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            rec_lbl.Text = labelText(1);
            ref_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            vendRef_lbl.Text = labelText(4);
            site_lbl.Text = labelText(5);
            pcs_lbl.Text = labelText(6);
            qty_lbl.Text = labelText(7);
            avg_lbl.Text = labelText(8);
            sub_lbl.Text = labelText(9);
            vat_lbl.Text = labelText(10);
            amount_lbl.Text = labelText(11);
            desc_lbl.Text = labelText(12);

            startDate_lbl.Text = labelText(13);
            endDate_lbl.Text = labelText(14);
            currency_lbl.Text = labelText(15);
            vendorRef_lbl.Text = labelText(16);
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