using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV436 : ArgusRPT.BaseReport
    {
        public IV436()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV436> webObject = deserializeList<ArgusDS.Inventory.Reports.IV436>();
            DataSource = webObject.list;
            crossTab.DataSource = webObject.list;

            fiscalYear_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            asOfDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            fiscalYear_lbl.Text = labelText(1);
            asOfDate_lbl.Text = labelText(2);
            site_lbl.Text = labelText(3);

            site2_lbl.Text = labelText(4);
            itemGroup_lbl.Text = labelText(5);

            total_lbl.Text = labelText(6);
            total2_lbl.Text = labelText(7);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV436";
        }
    }
}