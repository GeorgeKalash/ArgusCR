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
      public SAIVC01()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
          //plantName_data.Text = webObject.record.trxHeader.reference;
            licenseNo_data.Text = webObject.record.companyInfo.licenseNo;
            crNo_data.Text = webObject.record.companyInfo.crNo;
         // address_data.Text = webObject.record.billAddress.address;
            spName_data.Text = webObject.record.salesPerson.name;
            cellPhone_data.Text = webObject.record.salesPerson.cellPhone;

            clientName_data.Text = webObject.record.client.name;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            phoneNumber_lbl.Text = webObject.record.quickView.phone;
      
            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            subtotal2_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, Convert.ToInt16(sessionInfo.languageId));

            deliveryOrders_data.Text = webObject.record.deliveryOrders;
            description_data.Text = webObject.record.trxHeader.description;

            clientName2_data.Text = webObject.record.trxHeader.clientName;
            spName2_data.Text = webObject.record.trxHeader.spName;

            QRCode.Text = string.Format("\nالبائع:{0}", webObject.record.companyInfo?.name);
            QRCode.Text += string.Format("\nالرقم الضريبي:{0}", webObject.record.companyInfo?.taxNo);
            QRCode.Text += string.Format( "رقم الفاتورة:" + webObject.record.trxHeader.reference);
            QRCode.Text += string.Format("\nتاريخ الفاتورة:{0}", webObject.record.logTime);
            QRCode.Text += string.Format("\nإجمالي الضريبة:{0}", webObject.record.trxHeader.vatAmount.ToString("N2"));
            QRCode.Text += string.Format("\nإجمالي المبلغ:{0}", webObject.record.trxHeader.amount.ToString("N2"));

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            tamdeedVatNo_lbl.Text = labelText(0);
            taxInvoice_lbl.Text = labelText(1);

            invoiceInfo_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);
            license_lbl.Text = labelText(6);
            commercialRecord_lbl.Text = labelText(7);
            address_lbl.Text = labelText(8);
            spName_lbl.Text = labelText(9);

            clientInfo_lbl.Text = labelText(10);
            clientName_lbl.Text = labelText(11);
            clientVATNo_lbl.Text = labelText(12);
            phoneNumber_lbl.Text = labelText(13);
            cAddress_lbl.Text = labelText(14);
            exhibitionManager_lbl.Text = labelText(15);

            sku_lbl.Text = labelText(16);
            itemName_lbl.Text = labelText(17);
            qty_lbl.Text = labelText(18);
            unitPrice_lbl.Text = labelText(19);
            subtotal_lbl.Text = labelText(20);
            discount_lbl.Text = labelText(21);
            vat_lbl.Text = labelText(22);
            vatAmount_lbl.Text = labelText(23);
            extendedPrice_lbl.Text = labelText(24);

            total_lbl.Text = labelText(25);

            deliveryOrderRef_lbl.Text = labelText(26);
            notes_lbl.Text = labelText(27);

            subtotal2_lbl.Text = labelText(28);
            discount2_lbl.Text = labelText(29);
            idk_lbl.Text = labelText(30);
            vatAmount2_lbl.Text = labelText(31);
            amount2_data.Text = labelText(32);

            text_lbl.Text = labelText(33);

            clientSig_lbl.Text = labelText(34);
            cName_lbl.Text = labelText(35);
            cSig_lbl.Text = labelText(36);

            sPSig_lbl.Text = labelText(37);
            saPeName_lbl.Text = labelText(38);
            sPeSig_lbl.Text = labelText(39);
        }
        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA103";
        }

    }
}
