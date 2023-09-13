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
            plant_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            sz_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            clientGrp_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            plantGrp_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            itemGrp_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;
            syFunction_param.Text = Parameters.Count > 12 ? Parameters[12].Value.ToString() : string.Empty;
           
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
            plant_lbl.Text = labelText(12);
            sz_lbl.Text = labelText(13);
            client_lbl.Text = labelText(14);
            clientGrp_lbl.Text = labelText(15);
            plantGrp_lbl.Text = labelText(16);
            itemCategory_lbl.Text = labelText(17);
            item_lbl.Text = labelText(18);
            itemGrp_lbl.Text = labelText(19);
            syFunction_lbl.Text = labelText(20);
            production_lbl.Text = labelText(21);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA502";
        }
    }
}