using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

//public class Assembly : Activity
//{
//    public int? plantId { get; set; }
//    public int bomId { get; set; }
//    public int itemId { get; set; }
//    public int siteId { get; set; }
//    public int rmSiteId { get; set; }
//    public double qty { get; set; }
//    public double rmCost { get; set; }
//    public string notes { get; set; }
//}

//public class AssemblyView : Assembly
//{
//    public string bomName, sku, itemName, siteName, rmSiteName, plantName, dtName;
//}

//public class AssemblyComponent
//{
//    public int assemblyId { get; set; }
//    public short seqNo { get; set; }
//    public int itemId { get; set; }
//    public int siteId { get; set; }
//    public double designQty { get; set; }
//    public double qty { get; set; }
//    public double cost { get; set; }

//}

//public class AssemblyComponentView : AssemblyComponent
//{
//    public string sku, itemName;
//}

namespace ArgusCR1012.Manufacturing.Templates
{
    public partial class MFASM01 : Reports.BaseReport
    {
        public MFASM01()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.AssemblyPrintView> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.AssemblyPrintView>();

            //if (webObject)

            DataSource = webObject.record.items;

            dtName_data.Text = webObject.record.header.dtName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            notes_data.Text = webObject.record.header.notes;
            siteName_data.Text = webObject.record.header.siteName;

            bomName_data.Text = webObject.record.header.bomName;
            bomRef_data.Text = webObject.record.header.bomRef;
            itemName_data.Text = webObject.record.header.itemName;
            qty_data.Text = webObject.record.header.qty.ToString();
            rmCost_data.Text = webObject.record.header.rmCost.ToString("N2");
            rmSiteName_data.Text = webObject.record.header.rmSiteName;

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
       
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            //lineNo.Text = itemsCounter.ToString();
            //++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override void labelsText()
        {
            assembly_lbl.Text = labelText(0);

            dtName_lbl.Text = labelText(1);
            reference_lbl.Text = labelText(2);
            date_lbl.Text = labelText(3);
            notes_lbl.Text = labelText(4);
            siteRef_lbl.Text = labelText(5);

            bomName_lbl.Text = labelText(6);
            bomRef_lbl.Text = labelText(7);
            itemName_lbl.Text = labelText(8);
            qty_lbl.Text = labelText(9);
            rmCost_lbl.Text = labelText(10);
            site_lbl.Text = labelText(11);

            sku_lbl.Text = labelText(12);
            productionItem_lbl.Text = labelText(13);
            componentSite_lbl.Text = labelText(14);
            designQty_lbl.Text = labelText(15);
            productionQty_lbl.Text = labelText(16);
            costs_lbl.Text = labelText(17);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\MF102";
        }
    }
}
