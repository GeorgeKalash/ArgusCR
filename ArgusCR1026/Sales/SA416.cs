using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1026.Sales
{
    public partial class SA416 : ArgusRPT.BaseReport
    {
        public SA416()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return detailedItemsSales_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Sales.Reports.SA416> obj = deserializeList<ArgusDS.Sales.Reports.SA416>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

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
            detailedItemsSales_lbl.Text = labelText(0);

            date_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            functionName_lbl.Text = labelText(3);
            sku_lbl.Text = labelText(4);
            itemName_lbl.Text = labelText(5);
            qty_lbl.Text = labelText(6);
            unitPrice_lbl.Text = labelText(7);
            vatAmount_lbl.Text = labelText(8);
            amount_lbl.Text = labelText(9);
            netPrice_lbl.Text = labelText(10);

            startDate_lbl.Text = labelText(11);
            endDate_lbl.Text = labelText(12);
            itemCategory_lbl.Text = labelText(13);
            itemGroup_lbl.Text = labelText(14);

            clientRef_lbl.Text = labelText(15);
            clientName_lbl.Text = labelText(16);
            weight_lbl.Text = labelText(17);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.SA416";
        }
    }
}