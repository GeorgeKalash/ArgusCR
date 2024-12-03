using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.BusinessPartners
{
    public partial class BP103 : ArgusRPT.BaseReport
    {
        public BP103()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.BP103> obj = deserializeList<Custom.CR1029.BP103>();
            DataSource = obj.list;
            logo_data.ImageUrl = companyInfo.logoUrl;

            bpGrp_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            saleZone_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            city2_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            state2_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            country_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            clientGroup2_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            activeStatus_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            contactName_lbl.Text = labelText(3);
            clientGroup_lbl.Text = labelText(4);
            phone1_lbl.Text = labelText(5);
            phone2_lbl.Text = labelText(6);
            phone3_lbl.Text = labelText(7);
            state_lbl.Text = labelText(8);
            city_lbl.Text = labelText(9);
            szName_lbl.Text = labelText(10);
            isInactive_lbl.Text = labelText(11);

            bpGrp_lbl.Text = labelText(12);
            saleZone_lbl.Text = labelText(13);
            city2_lbl.Text = labelText(14);
            state2_lbl.Text = labelText(15);
            country_lbl.Text = labelText(16);
            clientGroup2_lbl.Text = labelText(17);
            activeStatus_lbl.Text = labelText(18);
            level_lbl.Text = labelText(19);
            createdDate_lbl.Text = labelText(20);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.BP103";
        }
    }
}