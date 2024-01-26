using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA500 : ArgusRPT.BaseReport
    {
        public SA500()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA500> obj = deserializeList<Custom.CR1029.SA500>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            sz_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            clientGrp_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            plantGrp_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            itemGrp_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            syFunction_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 12 ? Parameters[12].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            zoneRef_lbl.Text = labelText(1);
            zoneName_lbl.Text = labelText(2);
            clientCount_lbl.Text = labelText(3);
            qty18_lbl.Text = labelText(4);
            qty21_lbl.Text = labelText(5);
            laborPrice_lbl.Text = labelText(6);
            amount_lbl.Text = labelText(7);
            vatAmount_lbl.Text = labelText(8);
            netAmount_lbl.Text = labelText(9);
            avg_lbl.Text = labelText(10);

            startDate_lbl.Text = labelText(11);
            endDate_lbl.Text = labelText(12);
            level_lbl.Text = labelText(13);
            plant_lbl.Text = labelText(14);
            sz_lbl.Text = labelText(15);
            client_lbl.Text = labelText(16);
            clientGrp_lbl.Text = labelText(17);
            plantGrp_lbl.Text = labelText(18);
            itemCategory_lbl.Text = labelText(19);
            item_lbl.Text = labelText(20);
            itemGrp_lbl.Text = labelText(21);
            syFunction_lbl.Text = labelText(22);
            production_lbl.Text = labelText(23);
            totalQty_lbl.Text = labelText(24);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA500";
        }
    }
}