using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Inventory;
using ArgusDS.Inventory.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1026.Inventory
{
    public partial class IV403 : ArgusRPT.BaseReport
    {
        public IV403()
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
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV403> webObject = deserializeList<ArgusDS.Inventory.Reports.IV403>();

            DataSource = webObject.list;

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyInfoName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
  
        protected override void labelsText()
        {
            inventoryStatus_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            qty_lbl.Text = labelText(3);
            weight_lbl.Text = labelText(4);
            totalWeight_lbl.Text = labelText(5);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.IV403";
        }
    }
}