﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Purchase
{
    public partial class PU401B : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public PU401B()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Purchase.Reports.PU401> webObject = deserializeList<ArgusDS.Purchase.Reports.PU401>();
            DataSource = webObject.list;

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

            rec_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            sku_lbl.Text = labelText(3);
            name_lbl.Text = labelText(4);
            ms_lbl.Text = labelText(5);
            itemGrp_lbl.Text = labelText(6);
            itemCategoryy_lbl.Text = labelText(7);
            vendor_lbl.Text = labelText(8);
            docRef_lbl.Text = labelText(9);
            qty_lbl.Text = labelText(10);
            unitPrice_lbl.Text = labelText(11);
            currency_lbl.Text = labelText(12);
            exRate_lbl.Text = labelText(13);
            extendedPrice_lbl.Text = labelText(14);
            costAllocation_lbl.Text = labelText(15);
            netPice_lbl.Text = labelText(16);

            startDate_lbl.Text = labelText(17);
            endDate_lbl.Text = labelText(18);
            vendorRef_lbl.Text = labelText(19);
            item_lbl.Text = labelText(20);
            itemCtgry_lbl.Text = labelText(21);
            siteParam_lbl.Text = labelText(22);
            systemFunction_lbl.Text = labelText(23);
            currencyParam_lbl.Text = labelText(24);
            itemGroup_lbl.Text = labelText(25);

            extendedPriceEgy_lbl.Text = labelText(26);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.PU401B";
        }
    }
}