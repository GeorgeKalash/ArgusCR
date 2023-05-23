using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1026.Inventory
{
    public partial class IV202 : ArgusRPT.BaseReport
    {
        public IV202()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return materialsTransfers_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV202> webObject = deserializeList<ArgusDS.Inventory.Reports.IV202>();
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
            materialsTransfers_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            fromsiteRef_lbl.Text = labelText(3);
            tositeRef_lbl.Text = labelText(4);

            sku_lbl.Text = labelText(5);
            itemName_lbl.Text = labelText(6);
            qty_lbl.Text = labelText(7);
            weight_lbl.Text = labelText(8);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.IV202";
        }
    }
}