﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA416 : ArgusRPT.BaseReport
    {
        public SA416()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA416> obj = deserializeList<Custom.CR1029.SA416>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            itemGroup_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
  
            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            documentRef_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);
            plantRef_lbl.Text = labelText(3);
            plantGroupRef_lbl.Text = labelText(4);
            costCenter_lbl.Text = labelText(5);
            sku_lbl.Text = labelText(6);
            itemName_lbl.Text = labelText(7);
            G18_lbl.Text = labelText(8);
            G21_lbl.Text = labelText(9);
            laborPrice_lbl.Text = labelText(10);
            vatAmount_lbl.Text = labelText(11);
            totalWithVat_lbl.Text = labelText(12);
            totalCost_lbl.Text = labelText(13);
            grossProfit_lbl.Text = labelText(14);

            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            itemCategory_lbl.Text = labelText(17);
            itemGroup_lbl.Text = labelText(18);
            item_lbl.Text = labelText(19);
            client_lbl.Text = labelText(20);

            total_lbl.Text = labelText(21);
        }

        protected override string dictionaryStore()
        {
            return "CR1029.SA416";
        }
    }
}