using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;


namespace ArgusCR1029.Inventory
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
        }

        protected override string dictionaryStore()
        {
            return "CR1029.IV102";
        }
    }
}