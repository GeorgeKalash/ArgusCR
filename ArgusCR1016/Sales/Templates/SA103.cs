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
            reference_data.Text = webObject.record.trxHeader.reference;

            if (webObject.record.logTime != null)
            {
                date_data.Text = ((DateTime)webObject.record.logTime).ToString(sessionInfo.dateFormat) + " " + ((DateTime)webObject.record.logTime).ToString("HH:mm");
            }

            clientName_data.Text = webObject.record.client.name;

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();

            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            vatNumber_lbl.Text = labelText(0);
            invoice_lbl.Text = labelText(1);

            usd_lbl.Text = labelText(2);

            description_lbl.Text = labelText(3);
            weight_lbl.Text = labelText(4);
            qty_lbl.Text = labelText(5);
            unitPrice_lbl.Text = labelText(6);
            amount_lbl.Text = labelText(7);

            subtotal_lbl.Text = labelText(8);
            discount_lbl.Text = labelText(9);

            vat_lbl.Text = labelText(10);
            netTotal_lbl.Text = labelText(11);

            totalPieces_lbl.Text = labelText(12);
            totalWeight_lbl.Text = labelText(13);

            footerText1_lbl.Text = labelText(14);
            footerText2_lbl.Text = labelText(15);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\SA103";
        }
    }
}
