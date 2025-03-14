﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV411_L1B : ArgusRPT.BaseReport
    {
        public IV411_L1B()
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
            siteGroup_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            fiscalYear_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            siteParam_lbl.Text = labelText(3);
            item_lbl.Text = labelText(4);

            itemCategory_lbl.Text = labelText(5);
            itemGroupParam_lbl.Text = labelText(6);
            siteGroup_lbl.Text = labelText(7);
            production_lbl.Text = labelText(8);

            sku_lbl.Text = labelText(9);
            name_lbl.Text = labelText(10);
            weight_lbl.Text = labelText(11);
            siteRef_lbl.Text = labelText(12);
            ItemGroup_lbl.Text = labelText(13);
            productionLine_lbl.Text = labelText(14);
            collection_lbl.Text = labelText(15);
            pcs_lbl.Text = labelText(16);
            qty_lbl.Text = labelText(17);
            purity_lbl.Text = labelText(18);
            qtyG21_lbl.Text = labelText(19);
            avgWeight_lbl.Text = labelText(20);
            pct_lbl.Text = labelText(21);

            SubTotal_lbl.Text = labelText(22);
            grandTotal_lbl.Text = labelText(23);

            mu_lbl.Text = labelText(24);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV411_L1B";
        }
    }
}