﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Purchase
{
    public partial class PU401 : ArgusRPT.BaseReport
    {
        public PU401()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Purchase.Reports.PU401> obj = deserializeList<ArgusDS.Purchase.Reports.PU401>();
            DataSource = obj.list;

            vendor_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            siteParam_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            systemFunction_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            currency_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            systemFunctions_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            vendorRef_lbl.Text = labelText(4);
            vendorName_lbl.Text = labelText(5);
            site_lbl.Text = labelText(6);
            itemCat_lbl.Text = labelText(7);
            metal_lbl.Text = labelText(8);
            itemGrp_lbl.Text = labelText(9);
            itemRef_lbl.Text = labelText(10);
            itemName_lbl.Text = labelText(11);
            pcs_lbl.Text = labelText(12);
            qty_lbl.Text = labelText(13);
            unitCost_lbl.Text = labelText(14);
            amount_lbl.Text = labelText(15);

            startDate_lbl.Text = labelText(16);
            endDate_lbl.Text = labelText(17);
            vendor_lbl.Text = labelText(18);
            item_lbl.Text = labelText(19);
            itemCtgry_lbl.Text = labelText(20);
            siteParam_lbl.Text = labelText(21);
            systemFunction_lbl.Text = labelText(22);
            currency_lbl.Text = labelText(23);
            itemGroup_lbl.Text = labelText(24);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.PU401";
        }
    }
}