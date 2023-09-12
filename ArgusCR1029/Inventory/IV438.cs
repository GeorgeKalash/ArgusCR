using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV438 : ArgusRPT.BaseReport
    {
        public IV438()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV438> webObject = deserializeList<ArgusDS.Inventory.Reports.IV438>();
            DataSource = webObject.list;
            crossTab.DataSource = webObject.list;

            toSite_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            fromGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            toGroup_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            site_lbl.Text = labelText(1);
            total_lbl.Text = labelText(2);
            total2_lbl.Text = labelText(3);

            toSite_lbl.Text = labelText(4);
            startDate_lbl.Text = labelText(5);
            endDate_lbl.Text = labelText(6);
            fromGroup_lbl.Text = labelText(7);
            toGroup_lbl.Text = labelText(8);
            itemCategory_lbl.Text = labelText(9);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV438";
        }
    }
}