﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Inventory;
using ArgusDS.Inventory.Reports;
using DevExpress.XtraReports.UI;

namespace ArgusCR1016.Inventory
{
    public partial class IV02 : ArgusRPT.BaseReport
    {
        public IV02()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return inventoryStatus_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            printDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            SharedClasses.JsonProtocol.QryStructure<Custom.CR1016.IV02> webObject = deserializeList<Custom.CR1016.IV02>();

            DataSource = webObject.list;

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyInfoName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
  
        protected override void labelsText()
        {
            inventoryStatus_lbl.Text = labelText(0);

            sku_lbl.Text = labelText(1);
            name_lbl.Text = labelText(2);
            uniCost_lbl.Text = labelText(3);
            unitPrice_lbl.Text = labelText(4);
            qty_lbl.Text = labelText(5);
            netWeight_lbl.Text = labelText(6);
            diams_lbl.Text = labelText(7);
            stones_lbl.Text = labelText(8);
        }
        protected override string dictionaryStore()
        {
            return "CR1016.IV02";
        }
    }
}