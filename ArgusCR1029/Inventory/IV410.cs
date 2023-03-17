using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV410 : ArgusRPT.BaseReport
    {
        public IV410()
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
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV410> webObject = deserializeList<ArgusDS.Inventory.Reports.IV410>();
            DataSource = webObject.list;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            inventoryStatus_lbl.Text = labelText(0);

            categoryRef_lbl.Text = labelText(1);
            categoryname_lbl.Text = labelText(2);
            qty_lbl.Text = labelText(3);
            netWeight_lbl.Text = labelText(4);
            netVolume_lbl.Text = labelText(5);
            netCost_lbl.Text = labelText(6);
            netPrice_lbl.Text = labelText(7);
        }

        protected override string dictionaryStore()
        {
            return "IV410";
        }
    }
}