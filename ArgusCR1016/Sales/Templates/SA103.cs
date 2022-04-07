using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using ArgusDS.Inventory;
using System.Collections.Generic;
using System.Linq;

namespace ArgusCR1016.Sales.Templates
{
    public partial class SA103 : Reports.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            vatNumber_data.Text = webObject.record.companyInfo.taxNo;
            date_data.Text = ((DateTime)webObject.record.trxHeader.date).ToString(sessionInfo.dateFormat);

            companyAddress1_data.Text = webObject.record.companyInfo.address?.street1;
            companyAddress2_data.Text = webObject.record.companyInfo.address?.city + ""+webObject.record.companyInfo.address?.countryName;
            companyAddress3_data.Text = webObject.record.companyInfo.address?.phone;

            clientName_data.Text = webObject.record.client.name;
            clientAddress1_data.Text = webObject.record.billAddress?.city +""+ webObject.record.billAddress?.countryName;
            clientAddress2_data.Text = webObject.record.billAddress?.phone;

            reference_data.Text = webObject.record.trxHeader.reference;

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 6, 1);

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();

            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            vatNumber_lbl.Text = labelText(0);
            date_lbl.Text = labelText(1);
            invoice_lbl.Text = labelText(2);

            usd_lbl.Text = labelText(3);

            description_lbl.Text = labelText(4);
            weight_lbl.Text = labelText(5);
            qty_lbl.Text = labelText(6);
            unitPrice_lbl.Text = labelText(7);
            amount_lbl.Text = labelText(8);

            subtotal_lbl.Text = labelText(9);
            discount_lbl.Text = labelText(10);

            vat_lbl.Text = labelText(11);
            netTotal_lbl.Text = labelText(12);

            totalPieces_lbl.Text = labelText(13);
            totalWeight_lbl.Text = labelText(14);

            footerText1_lbl.Text = labelText(15);
            footerText2_lbl.Text = labelText(16);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\SA103";
        }
    }
}
