using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1016.Sales
{
    public partial class SA101b : Reports.BaseReport
    {
        public SA101b()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
       
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayoutWithDimensions> webObject = deserializeGet<QuotationPrintLayoutWithDimensions>();
            DataSource = webObject.record.items;

            clientRef_data.Text = webObject.record.header.clientRef;
            clientName_data.Text = webObject.record.header.clientName;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            quotation_lbl.Text = labelText(0);

            client_lbl.Text = labelText(1);
            date_lbl.Text = labelText(2);

            itemRef_lbl.Text = labelText(3);
            description_lbl.Text = labelText(4);
            weight_lbl.Text = labelText(5);
            size_lbl.Text = labelText(6);
            diamonds_lbl.Text = labelText(7);
            otherStones_lbl.Text = labelText(8);
            qty_lbl.Text = labelText(9);
            unitPrice_lbl.Text = labelText(10);
            unitCost_lbl.Text = labelText(11);

        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1016\\SA101b";
        }
    }
}
