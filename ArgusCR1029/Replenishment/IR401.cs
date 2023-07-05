using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Replenishment
{
    public partial class IR401 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IR401()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Replenishment.Report.IR401> webObject = deserializeList<ArgusDS.Replenishment.Report.IR401>();
            DataSource = webObject.list;

            date_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            replenishmentGrp_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            rec_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            sku_lbl.Text = labelText(3);
            ms_lbl.Text = labelText(4);
            category_lbl.Text = labelText(5);
            avgYearBefore_lbl.Text = labelText(6);
            avgYearAfter_lbl.Text = labelText(7);
            jan_lbl.Text = labelText(8);
            feb_lbl.Text = labelText(9);
            march_lbl.Text = labelText(10);
            april_lbl.Text = labelText(11);
            may_lbl.Text = labelText(12);
            june_lbl.Text = labelText(13);
            july_lbl.Text = labelText(14);
            august_lbl.Text = labelText(15);
            sep_lbl.Text = labelText(16);
            october_lbl.Text = labelText(17);
            nov_lbl.Text = labelText(18);
            dec_lbl.Text = labelText(19);
            onHand_lbl.Text = labelText(20);
            currentCoverage_lbl.Text = labelText(21);
            pr_lbl.Text = labelText(22);
            po_lbl.Text = labelText(23);
            requiredCoverage_lbl.Text = labelText(24);
            totalCoverage_lbl.Text = labelText(25);

            date_lbl.Text = labelText(26);
            site_lbl.Text = labelText(27);
            replenishmentGrp_lbl.Text = labelText(28);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IR401";
        }
    }
}