using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing
{
    public partial class MF205 : ArgusRPT.BaseReport
    {
        public MF205()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Manufacturing.Reports.MF205> webObject = deserializeList<ArgusDS.Manufacturing.Reports.MF205>();
            DataSource = webObject.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;

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

            jobRef_lbl.Text = labelText(1);
            startDat_lbl.Text = labelText(2);
            sku_lbl.Text = labelText(3);
            itemName_lbl.Text = labelText(4);
            productionClass_lbl.Text = labelText(5);
            standardClass_lbl.Text = labelText(6);
            exptectedPcs_lbl.Text = labelText(7);
            stdWeigt_lbl.Text = labelText(8);
            exptectedQty_lbl.Text = labelText(9);
            exptectedAdd_lbl.Text = labelText(10);
            actualPcs_lbl.Text = labelText(11);
            actualQty_lbl.Text = labelText(12);
            stoneWGT_lbl.Text = labelText(13);
            addMina_lbl.Text = labelText(14);
            addSusta_lbl.Text = labelText(15);
            status_lbl.Text = labelText(16);

            startDate_lbl.Text = labelText(17);
            endDate_lbl.Text = labelText(18);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.MF205";
        }
    }
}