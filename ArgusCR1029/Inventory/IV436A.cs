using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV436A : ArgusRPT.BaseReport
    {
        public IV436A()
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
            xrChart.DataSource = webObject.list;

            xrChart.Series[0].ArgumentDataMember = "monthName";
            xrChart.Series[0].ValueDataMembers.Clear();
            xrChart.Series[0].ValueDataMembers.AddRange(new string[] { "cost" });

            asOfDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV436A";
        }
    }
}