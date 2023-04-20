﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory
{
    public partial class IV208 : ArgusRPT.BaseReport
    {
        public IV208()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.QryStructure<ArgusDS.Inventory.Reports.IV208> obj = deserializeList<ArgusDS.Inventory.Reports.IV208>();
            DataSource = obj.list;

            siteParam_param.Text = Parameters.Count > 0 ? Parameters[0].Value.ToString() : string.Empty;
            startDate_param.Text = Parameters.Count > 1 ? Parameters[1].Value.ToString() : string.Empty;
            endDate_param.Text = Parameters.Count > 2 ? Parameters[2].Value.ToString() : string.Empty;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            docType_lbl.Text = labelText(1);
            draftRef_data.Text = labelText(2);
            date_lbl.Text = labelText(3);
            customer_lbl.Text = labelText(4);
            site_lbl.Text = labelText(5);
            pcs_lbl.Text = labelText(6);
            weight_lbl.Text = labelText(7);
            subTotal_lbl.Text = labelText(8);
            vat_lbl.Text = labelText(9);
            totalAmnt_lbl.Text = labelText(10);
            description_lbl.Text = labelText(11);
            workProcess_lbl.Text = labelText(12);
            status_lbl.Text = labelText(13);
            salesRef_lbl.Text = labelText(14);

            startDate_lbl.Text = labelText(15);
            endDate_lbl.Text = labelText(16);
            siteParam_lbl.Text = labelText(17);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.IV208";
        }
    }
}