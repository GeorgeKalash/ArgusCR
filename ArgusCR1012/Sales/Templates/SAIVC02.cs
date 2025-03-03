﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using ArgusDS.Inventory;
using System.Collections.Generic;
using System.Linq;

namespace ArgusCR1012.Sales.Templates
{
    public partial class SAIVC02 : ArgusRPT.BaseReport
    {
        public SAIVC02()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.trxHeader.reference;

            if (webObject.record.logTime != null)
            {
                date_data.Text = ((DateTime)webObject.record.trxHeader.date).ToString(sessionInfo.dateFormat) + " " + ((DateTime)webObject.record.logTime).ToString("HH:mm");
            }
         //   date_data.Text = webObject.record.trxHeader.date.ToString("dd/MM/yy");

            plant_data.Text = webObject.record.trxHeader.plantName;
            licenseNo_data.Text = webObject.record.companyInfo.licenseNo;
            crNo_data.Text = webObject.record.companyInfo.crNo;
            address_data.Text = webObject.record.companyInfo.address?.street1;
            spName_data.Text = webObject.record.salesPerson?.name;
            cellPhone_data.Text = webObject.record.salesPerson?.cellPhone;

            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.trxHeader.clientName;

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();

            decimal TotalAmountNonSubjectToTax = webObject.record.trxHeader.subtotal - (webObject.record.trxHeader.tdAmount ?? 0);
            totalSub_data.Text = TotalAmountNonSubjectToTax.ToString("N2");

            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);

            deliveryOrders_data.Text = webObject.record.deliveryOrders;
            description_data.Text = webObject.record.trxHeader.description;

            clientName2_data.Text = webObject.record.trxHeader.clientName;
            spName2_data.Text = webObject.record.trxHeader.spName;

            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.trxHeader.amount.ToString(), webObject.record.trxHeader.vatAmount.ToString()).ToBase64();

            base.OnBeforePrint(e);
        }
        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            ArgusDS.Sales.ItemView obj = ((List<ArgusDS.Sales.ItemView>)DataSource)[e.CurrentRow];

            decimal netUnitPrice = obj.unitPrice - (obj.mdValue ?? 0);
            decimal epWithVAT = obj.extendedPrice + obj.vatAmount;

            unitPrice_data.Text = netUnitPrice.ToString("N2");
            extendedPriceWithVAT_data.Text = epWithVAT.ToString("N2");

            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
            tamdeedVatNo_lbl.Text = labelText(0);
            taxInvoice_lbl.Text = labelText(1);

            invoiceInfo_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);
            license_lbl.Text = labelText(6);
            commercialRecord_lbl.Text = labelText(7);
            address_lbl.Text = labelText(8);
            spName_lbl.Text = labelText(9);

            clientName_lbl.Text = labelText(10);
  
            sku_lbl.Text = labelText(11);
            itemName_lbl.Text = labelText(12);
            qty_lbl.Text = labelText(13);
            unitPrice_lbl.Text = labelText(14);
            subtotal_lbl.Text = labelText(15);

            vat_lbl.Text = labelText(16);
            vatAmount_lbl.Text = labelText(17);
            extendedPrice_lbl.Text = labelText(18);

            deliveryOrderRef_lbl.Text = labelText(19);
            notes_lbl.Text = labelText(20);

            subtotal2_lbl.Text = labelText(21);
            discount2_lbl.Text = labelText(22);
            totalSub_lbl.Text = labelText(23);
            vatAmount2_lbl.Text = labelText(24);
            amount_lbl.Text = labelText(25);

            text_lbl.Text = labelText(26);

            clientSig_lbl.Text = labelText(27);
            cName_lbl.Text = labelText(28);
            cSig_lbl.Text = labelText(29);

            sPSig_lbl.Text = labelText(30);
            saPeName_lbl.Text = labelText(31);
            sPeSig_lbl.Text = labelText(32);
        }
        protected override string dictionaryStore()
        {
            return "CR1012.SA103B";
        }
    }
}