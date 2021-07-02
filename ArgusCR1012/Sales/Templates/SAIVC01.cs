using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;


namespace ArgusCR1012.Sales.Templates
{
    public partial class SAIVC01 : Reports.BaseReport
    {
        int itemsCounter = 1;

        public SAIVC01()
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

            spRef_data.Text = webObject.record.header.spRef;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.header.spName;
            spCellPhone_data.Text = webObject.record.header.spCellPhone;

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, Convert.ToInt16(sessionInfo.languageId));
            amount_data.Text = webObject.record.header.amount.ToString("N2");


            if (webObject.record.header.deliveryDate != null)
                deliveryDate_data.Text = ((DateTime)webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);

            if (webObject.record.shipAddress != null)
            {
                shipToAddress_data.Text = string.Format("{0}\\r\\n{1}\\r\\n{2}", webObject.record.shipAddress.street1, webObject.record.shipAddress.street2, webObject.record.shipAddress.city);
            }

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
            invoice_lbl.Text = labelText(0);
            customerVatNo_lbl.Text = labelText(1);
            masagVatNo_lbl.Text = labelText(2);
            accountNo_lbl.Text = labelText(3);
            clientName_lbl.Text = labelText(4);
            billAddressName_lbl.Text = labelText(5);
            billAddressPhone_lbl.Text = labelText(6);
            spRef_lbl.Text = labelText(7);
            reference_lbl.Text = labelText(8);
            date_lbl.Text = labelText(9);
            spName_lbl.Text = labelText(10);
            spCellPhone_lbl.Text = labelText(11);
            lineNo_lbl.Text = labelText(12);
            sku_lbl.Text = labelText(13);
            itemName_lbl.Text = labelText(14);
            qty_lbl.Text = labelText(15);
            unitPrice_lbl.Text = labelText(16);
            extendedPrice_lbl.Text = labelText(17);
            subtotal_lbl.Text = labelText(18);
            vatAmount_lbl.Text = labelText(19);
            amountInWords_lbl.Text = labelText(20);
            amount_lbl.Text = labelText(21);
            deliveryInfo_lbl.Text = labelText(22);
            deliveryDate_lbl.Text = labelText(23);
            shipAddress_lbl.Text = labelText(24);
            shippingMode_lbl.Text = labelText(25);
            paymentTerms_lbl.Text = labelText(26);
            cash_lbl.Text = labelText(27);
            notes_lbl.Text = labelText(28);
            thanksMessage_lbl.Text = labelText(29);
            callTel_lbl.Text = labelText(30);
            customerAcceptance_lbl.Text = labelText(31);
            authorizedSign_lbl.Text = labelText(32);
            dateSeal_lbl.Text = labelText(33);
            preparedBy_lbl.Text = labelText(34);
            approvedBy_lbl.Text = labelText(35);
            confirmedBy_lbl.Text = labelText(36);
            receivedBy_lbl.Text = labelText(37);
            postedBy_lbl.Text = labelText(38);
            saleManager_lbl.Text = labelText(39);
            departmentManager_lbl.Text = labelText(40);
            accountsManager_lbl.Text = labelText(41);
            costomerEnd_lbl.Text = labelText(42);
            postingDate_lbl.Text = labelText(43);
            distribution_lbl.Text = labelText(44);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA103";
        }

    }
}
