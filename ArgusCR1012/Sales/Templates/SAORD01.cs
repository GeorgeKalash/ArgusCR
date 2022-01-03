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
        int itemsCounter = 1;

        public SAORD01()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();

            //if (webObject)

            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.header.clientName;
            billAddressName_data.Text = webObject.record.billAddress?.name;
            billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            reference_data.Text = webObject.record.header.reference;
            spName_data.Text = webObject.record.header.spName;
            spCellPhone_data.Text = webObject.record.header.spCellPhone;


            //subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            //vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            //amount_data.Text = webObject.record.header.amount.ToString("N2");

            //if (webObject.record.header.deliveryDate != null)
            //    deliveryDate_data.Text = ((DateTime)webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);

            //amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, Convert.ToInt16(sessionInfo.languageId));

            //if (webObject.record.header.expiryDate != null)
            //    validity_data.Text = string.Format("{0} days: {1}", webObject.record.header.validity, ((DateTime)webObject.record.header.expiryDate).ToString(sessionInfo.dateFormat));

            //if (webObject.record.shipAddress != null)
            //{
            //    shipToAddress_data.Text = string.Format("{0}\\r\\n{1}\\r\\n{2}", webObject.record.shipAddress.street1, webObject.record.shipAddress.street2, webObject.record.shipAddress.city);
            //}

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
            title_lbl.Text = labelText(0);
            tamdeed_lbl.Text = labelText(1);
            salesOrder_lbl.Text = labelText(2);
            doc_lbl.Text = labelText(3);

            customerDetail_lbl.Text = labelText(4);
            clientName_lbl.Text = labelText(5);
            billAddressName_lbl.Text = labelText(6);
            billAddressPhone_lbl.Text = labelText(7);

            date_lbl.Text = labelText(8);
            reference_lbl.Text = labelText(9);
            spName_lbl.Text = labelText(10);
            spCellPhone_lbl.Text = labelText(11);

            lineNo_lbl.Text = labelText(12);
            sku_lbl.Text = labelText(13);
            itemName_lbl.Text = labelText(14);
            qty_lbl.Text = labelText(15);
            notes_lbl.Text = labelText(16);

            anyNote_lbl.Text = labelText(17);

            preparedBy_lbl.Text = labelText(18);
            preparedSig_lbl.Text = labelText(19);
            preparedDate_lbl.Text = labelText(20);

            receivedBy_lbl.Text = labelText(21);
            receivedSig_lbl.Text = labelText(22);
            receivedDate_lbl.Text = labelText(23);

            filledBy_lbl.Text = labelText(24);
            pJobOrder_lbl.Text = labelText(25);
            or_lbl.Text = labelText(26);
            deliveryNoteNo_lbl.Text = labelText(27);

            distribution_lbl.Text = labelText(28);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA102";
        }
    }
}
