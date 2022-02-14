using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1008.Inventory.Templates
{
    public partial class IV102 : Reports.BaseReport
    {
        public IV102()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Inventory.Reports.IV102> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV102>();
            DataSource = webObject.record.items;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy");
            plantName_data.Text = webObject.record.header.plantName;

            fromSiteRef_data.Text = webObject.record.header.fromSiteRef;
            fromSiteName_data.Text = webObject.record.header.fromSiteName;
            toSiteRef_data.Text = webObject.record.header.toSiteRef;
            toSiteName_data.Text = webObject.record.header.toSiteName;
            notes_data.Text = webObject.record.header.notes;
            city_data.Text = webObject.record.toAddress?.city;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            materialsTransfer_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            plantName_lbl.Text = labelText(4);

            fromSite_lbl.Text = labelText(5);
            toSite_lbl.Text = labelText(6);
            notes_lbl.Text = labelText(7);

            sku_lbl.Text = labelText(8);
            itemName_lbl.Text = labelText(9);
            qty_lbl.Text = labelText(10);

            city_lbl.Text = labelText(11);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1008\\IV102";
        }
    }
}