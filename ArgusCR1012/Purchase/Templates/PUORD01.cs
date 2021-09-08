using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;


namespace ArgusCR1012.Purchase.Templates
{
    public partial class PUORD01 : Reports.BaseReport
    {
        public PUORD01()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return purchaseOrder_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.OrderPrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.OrderPrintLayout>();
            DataSource = webObject.record.items;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            vendorRef_data.Text = webObject.record.header.vendorRef;
            vendorName_data.Text = webObject.record.header.vendorName;

            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            currencyName_data.Text = webObject.record.header.currencyName;
            plantName_data.Text = webObject.record.header.plantName;
            pmName_data.Text = webObject.record.header.pmName;
            deliveryDate_data.Text = ((DateTime)webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);
            exWorksCheckBox.Checked = webObject.record.header.exWorks == true;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            purchaseOrder_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            vendorRef_lbl.Text = labelText(3);
            vendorName_lbl.Text = labelText(4);

            date_lbl.Text = labelText(5);
            currencyName_lbl.Text = labelText(6);
            plantName_lbl.Text = labelText(7);
            pmName_lbl.Text = labelText(8);
            deliveryDate_lbl.Text = labelText(9);
            exWorks_lbl.Text = labelText(10);

            sku_lbl.Text = labelText(11);
            itemName_lbl.Text = labelText(12);
            qty_lbl.Text = labelText(13);
            unitPrice_lbl.Text = labelText(14);
            vatAmount_lbl.Text = labelText(15);
            mdAmount_lbl.Text = labelText(16);
            extendedPrice_lbl.Text = labelText(17);
            amount_lbl.Text = labelText(18);
            notes_lbl.Text = labelText(19);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\PU101";
        }



    }
}
