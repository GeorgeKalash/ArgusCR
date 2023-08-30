using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1029.Purchase.Templates
{
    public partial class PU101 : ArgusRPT.BaseReport
    {
        public PU101()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
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
            plant_data.Text = webObject.record.header.plantName;
            pm_data.Text = webObject.record.header.pmName;
            vendorDocRef_data.Text = webObject.record.header.vendorDocRef;
            vatCheckBox.Checked = webObject.record.header.isVattable == true;
            if (webObject.record.header.deliveryDate != null)
                vendorRef_data.Text = ((DateTime)webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);
            dm_data.Text = webObject.record.header.deliveryMethodName;
            exWorksCheckBox.Checked = webObject.record.header.exWorks == true;

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            description_data.Text = webObject.record.header.description;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            vendor_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            currencyName_lbl.Text = labelText(5);
            plant_lbl.Text = labelText(6);
            pm_lbl.Text = labelText(7);
            vendorDocRef_lbl.Text = labelText(8);
            vat_lbl.Text = labelText(9); 
            deliveryDate_lbl.Text = labelText(10);
            dm_lbl.Text = labelText(11);
            exWorks_lbl.Text = labelText(12);

            TotalQuantity_lbl.Text = labelText(13);
            subtotal_lbl.Text = labelText(14);
            vatAmount_lbl.Text = labelText(15);
            amount_lbl.Text = labelText(16);

            sku_lbl.Text = labelText(17);
            itemName_lbl.Text = labelText(18);
            qty_lbl.Text = labelText(19);
            requestRef_lbl.Text = labelText(20);
            unitCost_lbl.Text = labelText(21);
            vatt_lbl.Text = labelText(22);
            extendedCost_lbl.Text = labelText(23);
            deliveryDate2_lbl.Text = labelText(24);

            description_lbl.Text = labelText(25);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.PU101";
        }
    }
}