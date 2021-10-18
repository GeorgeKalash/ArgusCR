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
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();

            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.trxHeader.clientName;
            billAddressName_data.Text = webObject.record.billAddress?.name;
            billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            spRef_data.Text = webObject.record.trxHeader.spRef;
            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.trxHeader.spName;
            //spCellPhone_data.Text = webObject.record.trxHeader.spCellPhone;

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, Convert.ToInt16(sessionInfo.languageId));
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

           
            QRCode.Text = string.Format("\nالبائع:{0}", webObject.record.companyInfo?.name);
            QRCode.Text += string.Format("\nالرقم الضريبي:{0}", webObject.record.companyInfo?.taxNo);
            QRCode.Text += string.Format( "            رقم الفاتورة:" + webObject.record.trxHeader.reference);
            QRCode.Text += string.Format("\nتاريخ الفاتورة:{0}", webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat));
            QRCode.Text += string.Format("\nإجمالي الضريبة:{0}", webObject.record.trxHeader.vatAmount.ToString("N2"));
            QRCode.Text += string.Format("\nإجمالي المبلغ:{0}", webObject.record.trxHeader.amount.ToString("N2"));
          

            //if (webObject.record.trxHeader.deliveryDate != null)
            //    deliveryDate_data.Text = ((DateTime)webObject.record.trxHeader.deliveryDate).ToString(sessionInfo.dateFormat);

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
            invoice_lbl.Text = labelText(2);

            customerVatNo_lbl.Text = labelText(3);

            masagVatNo_lbl.Text = labelText(4);

            accountNo_lbl.Text = labelText(5);
            clientName_lbl.Text = labelText(6);
            billAddressName_lbl.Text = labelText(7);
            billAddressPhone_lbl.Text = labelText(8);

            spRef_lbl.Text = labelText(9);
            reference_lbl.Text = labelText(10);
            date_lbl.Text = labelText(11);
            spName_lbl.Text = labelText(12);
            spCellPhone_lbl.Text = labelText(13);

            lineNo_lbl.Text = labelText(14);
            sku_lbl.Text = labelText(15);
            itemName_lbl.Text = labelText(16);
            qty_lbl.Text = labelText(17);
            unitPrice_lbl.Text = labelText(18);
            extendedPrice_lbl.Text = labelText(19);

            subtotal_lbl.Text = labelText(20);
            vatAmount_lbl.Text = labelText(21);
            amountInWords_lbl.Text = labelText(22);
            amount_lbl.Text = labelText(23);

            deliveryInfo_lbl.Text = labelText(24);
            deliveryDate_lbl.Text = labelText(25);
            deliveryLocation_lbl.Text = labelText(26);
            shippingMode_lbl.Text = labelText(27);

            paymentTerms_lbl.Text = labelText(28);
            cash_lbl.Text = labelText(29);
            notes_lbl.Text = labelText(30);

            thanksMessage_lbl.Text = labelText(31);
            callTel_lbl.Text = labelText(32);

            customerAcceptance_lbl.Text = labelText(33);
            authorizedSign_lbl.Text = labelText(34);
            dateSeal_lbl.Text = labelText(35);

            preparedBy_lbl.Text = labelText(36);
            approvedBy_lbl.Text = labelText(37);
            confirmedBy_lbl.Text = labelText(38);
            receivedBy_lbl.Text = labelText(39);
            postedBy_lbl.Text = labelText(40);

            saleManager_lbl.Text = labelText(41);
            departmentManager_lbl.Text = labelText(42);
            accountsManager_lbl.Text = labelText(43);
            costomerEnd_lbl.Text = labelText(44);
            postingDate_lbl.Text = labelText(45);

            distribution_lbl.Text = labelText(46);
            info_lbl.Text = labelText(47);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA103";
        }

    }
}
