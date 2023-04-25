using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA204_L1 : ArgusRPT.BaseReport
    {
        public SA204_L1()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA204_Layout1> obj = deserializeList<Custom.CR1029.SA204_Layout1>();
            DataSource = obj.list;

            clientRef_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            salesPerson_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            documentType_lbl.Text = labelText(1);

            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            clientRef_lbl.Text = labelText(4);
            clientName_lbl.Text = labelText(5);
            sp_lbl.Text = labelText(6);
            pieces_lbl.Text = labelText(7);
            G18_lbl.Text = labelText(8);
            G21_lbl.Text = labelText(9);
            laborPrice_lbl.Text = labelText(10);
            discPct_lbl.Text = labelText(11);
            discount_lbl.Text = labelText(12);
            vatAmount_lbl.Text = labelText(13);
            amount_lbl.Text = labelText(14);
            description_lbl.Text = labelText(15);
            status_lbl.Text = labelText(16);

            startDate_lbl.Text = labelText(17);
            endDate_lbl.Text = labelText(18);
            client_lbl.Text = labelText(19);
            salesPerson_lbl.Text = labelText(20);
            plantGroup_lbl.Text = labelText(21);
            plant_lbl.Text = labelText(22);

            totalSales_lbl.Text = labelText(23);
            total_lbl.Text = labelText(24);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA204_L1";
        }
    }
}