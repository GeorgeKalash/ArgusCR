using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class Layout1 : ArgusRPT.BaseReport
    {
      
        public Layout1()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            //SharedClasses.JsonProtocol.QryStructure<ArgusDS._1029.Layout1> obj = deserializeList<ArgusDS._1029.Layout1>();
            //DataSource = obj.list;

            //startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            //endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            //site_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            //productionLine_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            //itemgrp_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            manufacturing_lbl.Text = labelText(4);
            purchase_lbl.Text = labelText(5);
            returnPurchase_lbl.Text = labelText(6);
            sales_lbl.Text = labelText(7);
            returnSales_lbl.Text = labelText(8);
            receiptGold_lbl.Text = labelText(9);
            paymentGold_lbl.Text = labelText(10);
            incomingTransfer_lbl.Text = labelText(11);
            outboundTransfer_lbl.Text = labelText(12);
            adj_lbl.Text = labelText(13);
            purity_lbl.Text = labelText(14);
            g21_lbl.Text = labelText(15);
            balanceValue_lbl.Text = labelText(16);
            
            startDate_lbl.Text = labelText(17);
            endDate_lbl.Text = labelText(18);
            siteParam_lbl.Text = labelText(19);
            productionLine_lbl.Text = labelText(20);
            itemGp_lbl.Text = labelText(21);
        }
      
        protected override string dictionaryStore()
        {
            return "CR1029.Layout1";
        }
    }
}