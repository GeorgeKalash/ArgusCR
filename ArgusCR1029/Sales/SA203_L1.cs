using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA203_L1 : ArgusRPT.BaseReport
    {
        public SA203_L1()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA203_Layout1> obj = deserializeList<Custom.CR1029.SA203_Layout1>();
            DataSource = obj.list;

            clientRef_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            salesPerson_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;


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
            title_lbl.Text = labelText(0);

            documentType_lbl.Text = labelText(1);

            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            clientRef_lbl.Text = labelText(4);
            clientName_lbl.Text = labelText(5);
            spRef_lbl.Text = labelText(6);
            pieces_lbl.Text = labelText(7);

            G18Title_lbl.Text = labelText(8);
            G18_lbl.Text = labelText(9);
            G18Egp_lbl.Text = labelText(10);

            G21Title_lbl.Text = labelText(11);
            G21_lbl.Text = labelText(12);
            G21Egp_lbl.Text = labelText(13);

            totalQty_lbl.Text = labelText(14);
            totalQtyG21_lbl.Text = labelText(15);

            laborPrice_lbl.Text = labelText(16);
            discount_lbl.Text = labelText(17);
            vatAmount_lbl.Text = labelText(18);
            amount_lbl.Text = labelText(19);
            description_lbl.Text = labelText(20);
            status_lbl.Text = labelText(21);

            startDate_lbl.Text = labelText(22);
            endDate_lbl.Text = labelText(23);
            client_lbl.Text = labelText(24);
            salesPerson_lbl.Text = labelText(25);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA203_L1";
        }
    }
}