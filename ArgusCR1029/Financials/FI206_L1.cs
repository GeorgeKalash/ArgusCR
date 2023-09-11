using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI206_L1 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public FI206_L1()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure <ArgusDS._1029.FI206_L1> obj = deserializeList <ArgusDS._1029.FI206_L1> ();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            systemFunction_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            plantGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            account_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            statusParam_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            accountGroup_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            referenceParam_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            descriptionParam_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            rec_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            accRef_lbl.Text = labelText(4);
            accName_lbl.Text = labelText(5);
            site_lbl.Text = labelText(6);
            plantt_lbl.Text = labelText(7);
            g18_lbl.Text = labelText(8);
            g21_lbl.Text = labelText(9);
            g24_lbl.Text = labelText(10);
            g00_lbl.Text = labelText(11);
            totalBase_lbl.Text = labelText(12);
            amount_lbl.Text = labelText(13);
            description_lbl.Text = labelText(14);
            status_lbl.Text = labelText(15);
            total1_lbl.Text = labelText(16);
            total2_lbl.Text = labelText(17);

            startDate_lbl.Text = labelText(18);
            endDate_lbl.Text = labelText(19);
            systemFunction_lbl.Text = labelText(20);
            plant_lbl.Text = labelText(21);
            plantGroup_lbl.Text = labelText(22);
            siteParam_lbl.Text = labelText(23);
            account_lbl.Text = labelText(24);
            statusParam_lbl.Text = labelText(25);
            accountGroup_lbl.Text = labelText(26);
            referenceParam_lbl.Text = labelText(27);
            descriptionParam_lbl.Text = labelText(28);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI206_L1";
        }
    }
}