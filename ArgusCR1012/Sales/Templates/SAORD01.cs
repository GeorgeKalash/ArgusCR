using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;

namespace ArgusCR1012.Sales.Templates
{
    public partial class SAORD01 : Reports.BaseReport
    {
        public SAORD01()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();
            DataSource = webObject.record.items;

            clientRef_data.Text = webObject.record.header.clientRef;
            clientName_data.Text = webObject.record.header.clientName;
            shipAddress_data.Text = string.Format("{0}\\r\\n{1}\\r\\n{2}", webObject.record.shipAddress.street1, webObject.record.shipAddress.street2, webObject.record.shipAddress.city);

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
     
            spName_data.Text = webObject.record.header.spName;

            description_data.Text = webObject.record.header.description;

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            spName2_data.Text = webObject.record.header.spName;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            tamdeedVatNo_lbl.Text = labelText(0);
            salesOrder_lbl.Text = labelText(1);

            invoiceInfo_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);
            spName_lbl.Text = labelText(6);

            clientInfo_lbl.Text = labelText(7);
            clientName_lbl.Text = labelText(8);
            clientVATNo_lbl.Text = labelText(9);
            phoneNumber_lbl.Text = labelText(10);
            clientAddress_lbl.Text = labelText(11);

            sku_lbl.Text = labelText(12);
            itemName_lbl.Text = labelText(13);
            qty_lbl.Text = labelText(14);
            unitPrice_lbl.Text = labelText(15);
            mdAmount_lbl.Text = labelText(16);
            netPrice_lbl.Text = labelText(17);
            totalPrice_lbl.Text = labelText(18);

            deliveryOrderRef_lbl.Text = labelText(19);
            description_lbl.Text = labelText(20);

            subtotal_lbl.Text = labelText(21);
            vatAmount_lbl.Text = labelText(22);
            amount_lbl.Text = labelText(23);

            sPSig_lbl.Text = labelText(24);
            saPeName_lbl.Text = labelText(25);
            sPeSig_lbl.Text = labelText(26);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA102";
        }
    }
}
