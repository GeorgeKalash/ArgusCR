﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales
{
    public partial class SA501 : ArgusRPT.BaseReport
    {
        public SA501()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1029.SA501> obj = deserializeList<Custom.CR1029.SA501>();
            DataSource = obj.list;

            startDate_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            plant_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;
            sz_param.Text = Parameters.Count > 3 ? Parameters[3].Value.ToString() : string.Empty;
            level_param.Text = Parameters.Count > 4 ? Parameters[4].Value.ToString() : string.Empty;
            client_param.Text = Parameters.Count > 5 ? Parameters[5].Value.ToString() : string.Empty;
            clientGrp_param.Text = Parameters.Count > 6 ? Parameters[6].Value.ToString() : string.Empty;
            plantGrp_param.Text = Parameters.Count > 7 ? Parameters[7].Value.ToString() : string.Empty;
            itemCategory_param.Text = Parameters.Count > 8 ? Parameters[8].Value.ToString() : string.Empty;
            item_param.Text = Parameters.Count > 9 ? Parameters[9].Value.ToString() : string.Empty;
            itemGrp_param.Text = Parameters.Count > 10 ? Parameters[10].Value.ToString() : string.Empty;
            syFunction_param.Text = Parameters.Count > 11 ? Parameters[11].Value.ToString() : string.Empty;
            production_param.Text = Parameters.Count > 12 ? Parameters[12].Value.ToString() : string.Empty;

            logo_data.ImageUrl = companyInfo.logoUrl;
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            clientRef_lbl.Text = labelText(1);
            clientName_lbl.Text = labelText(2);

            g18_lbl.Text = labelText(3);
            qty18_lbl.Text = labelText(4);
            egp18_lbl.Text = labelText(5);
            g21_lbl.Text = labelText(6);
            qty21_lbl.Text = labelText(7);
            egp21_lbl.Text = labelText(8);
            laborPrice_lbl.Text = labelText(9);
            amount_lbl.Text = labelText(10);
            vatAmount_lbl.Text = labelText(11);
            netAmount_lbl.Text = labelText(12);
            avg_lbl.Text = labelText(13);

            startDate_lbl.Text = labelText(14);
            endDate_lbl.Text = labelText(15);
            level_lbl.Text = labelText(16);
            plant_lbl.Text = labelText(17);
            sz_lbl.Text = labelText(18);
            client_lbl.Text = labelText(19);
            clientGrp_lbl.Text = labelText(20);
            plantGrp_lbl.Text = labelText(21);
            itemCategory_lbl.Text = labelText(22);
            item_lbl.Text = labelText(23);
            itemGrp_lbl.Text = labelText(24);
            syFunction_lbl.Text = labelText(25);
            production_lbl.Text = labelText(26);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.SA501";
        }
    }
}