using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1008.Inventory.Templates
{
    public partial class IV103 : ArgusRPT.BaseReport
    {
        public IV103()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Inventory.Reports.IV103> obj = deserializeGet<ArgusDS.Inventory.Reports.IV103>();
            DataSource = obj.record.items;

            dtName_data.Text = obj.record.header.dtName;
            reference_data.Text = obj.record.header.reference;
            plantName_data.Text = obj.record.header.plantName;

            date_data.Text = obj.record.header.date.ToString("dd/MM/yyyy");
            siteRef_data.Text = obj.record.header.siteRef;
            siteName_data.Text = obj.record.header.siteName;

            description_data.Text = obj.record.header.description;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            materialsAdjustment_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            plant_lbl.Text = labelText(3);

            date_lbl.Text = labelText(4);
            site_lbl.Text = labelText(5);

            sku_lbl.Text = labelText(6);
            itemName_lbl.Text = labelText(7);
            qty_lbl.Text = labelText(8);
            notes_lbl.Text = labelText(9);

            description_lbl.Text = labelText(10);
            totQty_lbl.Text = labelText(11);
        }

        protected override string dictionaryStore()
        {
            return "CR1008.IV103";
        }
    }
}
