using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;


namespace ArgusCR1026.Inventory
{
    public partial class IV102 : ArgusRPT.BaseReport
    {
        public IV102()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Inventory.Reports.IV102> webObject = deserializeGet<ArgusDS.Inventory.Reports.IV102>();
            base.OnBeforePrint(e);
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;

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

            printSignature_lbl.Text = reportSignature();
        }

        protected override void labelsText()
        {
            materialsTransfer_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            plantName_lbl.Text = labelText(4);
            city_lbl.Text = labelText(5);

            fromSite_lbl.Text = labelText(6);
            toSite_lbl.Text = labelText(7);
            notes_lbl.Text = labelText(8);

            sku_lbl.Text = labelText(9);
            itemName_lbl.Text = labelText(10);
            weight_lbl.Text = labelText(11);
            qty_lbl.Text = labelText(12);

            total_lbl.Text = labelText(13);
        }

        protected override string dictionaryStore()
        {
            return "CR1026.IV102";
        }
    }
}