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
    public partial class IV408 : ArgusRPT.BaseReport
    {
        public IV408()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return inventoryStatus_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            printDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV408> webObject = deserializeList<ArgusDS.Inventory.Reports.IV408>();

            DataSource = webObject.list;

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