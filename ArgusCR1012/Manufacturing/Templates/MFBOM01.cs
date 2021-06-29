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
            status_data.Text = webObject.record.header.activeStatus.ToString();
            version_data.Text = webObject.record.header.version;
            date_data.Text = ((DateTime)webObject.record.header.date).ToString(sessionInfo.dateFormat);
            description_data.Text = webObject.record.header.description;
            qty_data.Text = webObject.record.header.qty.ToString();
            type_data.Text = webObject.record.header.type.ToString();
            printSignature.Text = reportSignature();



            base.OnBeforePrint(e);
        }


        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            xrTableCell23.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
            sku_lbl.Text = labelText(0);
            name_lbl.Text = labelText(1);
            qty_lbl.Text = labelText(2);
            lineNo_lbl.Text = labelText(3);

            
            bomReference_lbl.Text = labelText(4);
            bomName_lbl.Text = labelText(5);
            bomType_lbl.Text = labelText(6);
            bomDesc_lbl.Text = labelText(7);

            bomStatus_lbl.Text = labelText(8);
            bomVersion_lbl.Text = labelText(9);
            bomDate_lbl.Text = labelText(10);
            bomQty_lbl.Text = labelText(11);


            bomTitle_lbl.Text = labelText(12);
            bomTitle2_lbl.Text = labelText(12);
            mTitle_lbl.Text = labelText(13);
            tamdeedTitle_lbl.Text = labelText(14);


        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\MF101";
        }


    }
}
