using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA422 : ArgusRPT.BaseReport
    {
        public SA422()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA422> obj = deserializeList<Custom.CR1029.SA422>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            item_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            productionLine_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            systemFunction_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            plantRef_lbl.Text = labelText(1);
            plantName_lbl.Text = labelText(2);
            qty18_lbl.Text = labelText(3);
            qty21_lbl.Text = labelText(4);
            laborPrice_lbl.Text = labelText(5);
            vatAmount_lbl.Text = labelText(6);
            netAmount_lbl.Text = labelText(7);

            startDate_lbl.Text = labelText(8);
            endDate_lbl.Text = labelText(9);
            itemCategory_lbl.Text = labelText(10);
            itemGroup_lbl.Text = labelText(11);
            plant_lbl.Text = labelText(12);
            plantGroup_lbl.Text = labelText(13);

            item_lbl.Text = labelText(14);
            client_lbl.Text = labelText(15);
            saleZone_lbl.Text = labelText(16);
            productionLine2_lbl.Text = labelText(17);
            systemFunction_lbl.Text = labelText(18);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA422";
        }
    }
}