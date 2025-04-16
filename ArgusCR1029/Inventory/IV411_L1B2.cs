﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV411_L1B2 : ArgusRPT.BaseReport
    {
        public IV411_L1B2 ()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.IV403_L1> webObject = deserializeList<Custom.CR1029.IV403_L1>();
            DataSource = webObject.list;

            fiscalYear_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            date_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;

            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            fromSiteGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            toSiteGroup_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            production_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            metalPurity_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            col_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            brand_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            mu_lbl.Text = labelText(3);
            site_lbl.Text = labelText(4);
            siteGroup_lbl.Text = labelText(5);
            category_lbl.Text = labelText(6);
            metal_lbl.Text = labelText(7);
            productionLine_lbl.Text = labelText(8);
            itemGroup_lbl.Text = labelText(9);
            collection_lbl.Text = labelText(10);
            stone_lbl.Text = labelText(11);
            pcs_lbl.Text = labelText(12);
            weight_lbl.Text = labelText(13);
            avgWeight_lbl.Text = labelText(14);

            fiscalYear_lbl.Text = labelText(15);
            date_lbl.Text = labelText(16);
            siteParam_lbl.Text = labelText(17);
            item_lbl.Text = labelText(18);

            itemCategory_lbl.Text = labelText(19);
            itemGroupParam_lbl.Text = labelText(20);
            fromSiteGroup_lbl.Text = labelText(21);
            toSiteGroup_lbl.Text = labelText(22);

            production_lbl.Text = labelText(23);
            metalPurity_lbl.Text = labelText(24);
            col_lbl.Text = labelText(25);
            brand_lbl.Text = labelText(26);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV411_L1B2";
        }
    }
}