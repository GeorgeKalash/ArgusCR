using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;

namespace ArgusCR1012.Purchase.Templates
{
    public partial class PUSHP01 : ArgusRPT.BaseReport
    {
        public PUSHP01()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return shipment_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Purchase.Reports.ShipmentPrintLayout> webObject = deserializeGet<ArgusDS.Purchase.Reports.ShipmentPrintLayout>();
            DataSource = webObject.record.items;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            vendorRef_data.Text = webObject.record.header.vendorRef;
            vendorName_data.Text = webObject.record.header.vendorName;

            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            plantName_data.Text = webObject.record.header.plantName;
            siteName_data.Text = webObject.record.header.siteName;
            poRef_data.Text = webObject.record.header.poRef;


            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            shipment_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            vendorRef_lbl.Text = labelText(3);
            vendorName_lbl.Text = labelText(4);

            date_lbl.Text = labelText(5);
            plantName_lbl.Text = labelText(6);
            siteName_lbl.Text = labelText(7);
            poRef_lbl.Text = labelText(8);
            
            sku_lbl.Text = labelText(9);
            itemName_lbl.Text = labelText(10);
            qty_lbl.Text = labelText(11);
            totalQuantity_lbl.Text = labelText(12);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\PU102";
        }
    }
}
