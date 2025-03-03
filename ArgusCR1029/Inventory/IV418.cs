﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV418 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public IV418()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV418> webObject = deserializeList<ArgusDS.Inventory.Reports.IV418>();
            DataSource = webObject.list;

            fromSite_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            siteGrp_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            plt_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
           
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            record_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            sku_lbl.Text = labelText(3);
            name_lbl.Text = labelText(4);
            ms_lbl.Text = labelText(5);
            site_lbl.Text = labelText(6);
            itemGroup_lbl.Text = labelText(7);
            itemCategory_lbl.Text = labelText(8);
            reference_lbl.Text = labelText(9);
            functionName_lbl.Text = labelText(10);
            qty_lbl.Text = labelText(11);
            avgCost_lbl.Text = labelText(12);
            totalCost_lbl.Text = labelText(13);

            fromSite_lbl.Text = labelText(14);
            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            item_lbl.Text = labelText(17);
            itemCategoryParam_lbl.Text = labelText(18);
            siteGroupParam_lbl.Text = labelText(19);
            plantParam_lbl.Text = labelText(20);

            plant_lbl.Text = labelText(21);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV418";
        }
    }
}