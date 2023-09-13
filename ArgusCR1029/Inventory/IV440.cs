using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV440 : ArgusRPT.BaseReport
    {
        public IV440()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV440> webObject = deserializeList<ArgusDS.Inventory.Reports.IV440>();
            DataSource = webObject.list;

            fiscal_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            site_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCat_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            itemName_lbl.Text = labelText(2);
            ms_lbl.Text = labelText(3);
            itemgrp_lbl.Text = labelText(4);
            itemCategory_lbl.Text = labelText(5);
            availability_lbl.Text = labelText(6);
            cost_lbl.Text = labelText(7);
            totalCost_lbl.Text = labelText(8);

            fiscal_lbl.Text = labelText(9);
            startDate_lbl.Text = labelText(10);
            endDate_lbl.Text = labelText(11);
            site_lbl.Text = labelText(12);
            itemCat_lbl.Text = labelText(13);
            itemGroup_lbl.Text = labelText(14);

        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV440";
        }
    }
}