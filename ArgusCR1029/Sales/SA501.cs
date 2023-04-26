using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA501 : ArgusRPT.BaseReport
    {
        public SA501()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA501> obj = deserializeList<Custom.CR1029.SA501>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            clientRef_lbl.Text = labelText(1);
            clientName_lbl.Text = labelText(2);

            g18_lbl.Text = labelText(3);
            qty18_lbl.Text = labelText(4);
            egp18_lbl.Text = labelText(5);
            g21_lbl.Text = labelText(6);
            qty21_lbl.Text = labelText(7);
            egp21_lbl.Text = labelText(8);
            laborPrice_lbl.Text = labelText(9);
            amount_lbl.Text = labelText(10);
            vatAmount_lbl.Text = labelText(11);
            netAmount_lbl.Text = labelText(12);
            avg_lbl.Text = labelText(13);

            startDate_lbl.Text = labelText(14);
            endDate_lbl.Text = labelText(15);
            plant_lbl.Text = labelText(16);
            saleZone_lbl.Text = labelText(17);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA501";
        }
    }
}