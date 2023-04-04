using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Inventory;
using ArgusDS.Inventory.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1029.Inventory
{
    public partial class IV429 : ArgusRPT.BaseReport
    {
        public IV429()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return inventoryStatus_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            printDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV428> webObject = deserializeList<ArgusDS.Inventory.Reports.IV408>();

           // DataSource = webObject.list;

            fiscalYear_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            asOfDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
  
        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV408";
        }
    }
}