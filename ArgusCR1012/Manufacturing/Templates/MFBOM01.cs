using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1012.Manufacturing.Templates
{
    public partial class MFBOM01 : Reports.BaseReport
    {
        int itemsCounter = 1;
        public MFBOM01()
        {
            InitializeComponent();
        }


        protected override string reportName()
        {
            return bomTitle_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.BOMPrintView> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.BOMPrintView>();

            //if (webObject)
            DataSource = webObject.record.items;

            reference_data.Text = webObject.record.header.reference;
            name_data.Text = webObject.record.header.name;
            type_data.Text = webObject.record.header.type.ToString();
            description_data.Text = webObject.record.header.description;

            status_data.Text = webObject.record.header.activeStatus.ToString();
            version_data.Text = webObject.record.header.version;
            date_data.Text = ((DateTime)webObject.record.header.date).ToString(sessionInfo.dateFormat);
            bomQty_data.Text = webObject.record.header.qty.ToString();
            
            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }


        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo_data.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
            masagTitle_lbl.Text = labelText(0);
            tamdeedTitle_lbl.Text = labelText(1);
            bomTitle_lbl.Text = labelText(2);

            billOfMaterial_lbl.Text = labelText(3);
            reference_lbl.Text = labelText(4);
            name_lbl.Text = labelText(5);
            type_lbl.Text = labelText(6);
            description_lbl.Text = labelText(7);

            status_lbl.Text = labelText(8);
            version_lbl.Text = labelText(9);
            date_lbl.Text = labelText(10);
            bomQty_lbl.Text = labelText(11);

            lineNo_lbl.Text = labelText(12);
            sku_lbl.Text = labelText(13);
            itemName_lbl.Text = labelText(14);
            qty_lbl.Text = labelText(15);

            printSignature_lbl.Text = labelText(16);
            pageNumber_lbl.Text = labelText(17);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\MF101";
        }
    }
}
