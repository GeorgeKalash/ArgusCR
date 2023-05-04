using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            reference_lbl.Text = labelText(1);
            accName_lbl.Text = labelText(2);
            commercialName_lbl.Text = labelText(3);
            clientGroup_lbl.Text = labelText(4);
            state_lbl.Text = labelText(5);
            city_lbl.Text = labelText(6);
            szRef_lbl.Text = labelText(7);
            szName_lbl.Text = labelText(8);

            bpGrp_lbl.Text = labelText(9);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.BP103";
        }
    }
}