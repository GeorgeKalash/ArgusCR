using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA502 : ArgusRPT.BaseReport
    {
        public SA502()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA502> obj = deserializeList<Custom.CR1029.SA502>();
            DataSource = obj.list;

            logo_data.ImageUrl = companyInfo.logoUrl;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            zone_lbl.Text = labelText(1);
            productionLine_data.Text = labelText(2);
            g18_lbl.Text = labelText(3);
            g21_lbl.Text = labelText(4);
            vat_lbl.Text = labelText(5);
            discount_lbl.Text = labelText(6);
            net_lbl.Text = labelText(7);
            avgDiscount_lbl.Text = labelText(8);

            startDate_lbl.Text = labelText(9);
            endDate_lbl.Text = labelText(10);
            level_lbl.Text = labelText(11);
            saleZone_lbl.Text = labelText(12);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA502";
        }
    }
}