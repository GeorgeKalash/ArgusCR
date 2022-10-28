using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1009.Sales.Templates
{
    public partial class SA103 : ArgusRPT.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = webObject.record.companyInfo.logoUrl;
            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;
            cAddressName_data.Text = webObject.record.companyInfo.address?.name;
            cAddressStreet1_data.Text = webObject.record.companyInfo.address?.street1;
            cAddressCity_data.Text = webObject.record.companyInfo.address?.city;
            cAddressCountryName_data.Text = webObject.record.companyInfo.address?.countryName;
            cAddressPhone_data.Text = webObject.record.companyInfo.address?.phone;

            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVat_data.Text = webObject.record.client.vatNumber;
            AddressName_data.Text = webObject.record.billAddress?.name;
            AddressStreet1_data.Text = webObject.record.billAddress?.street1;
            AddressCity_data.Text = webObject.record.billAddress?.city;
            AddressCountryName_data.Text = webObject.record.billAddress?.countryName;
            AddressPhone_data.Text = webObject.record.billAddress?.phone;

            docRef_data.Text = webObject.record.trxHeader.reference;
            clientRef_data.Text = webObject.record.trxHeader.clientRef;
            currency_data.Text = webObject.record.trxHeader.currencyName;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);

            description_data.Text = webObject.record.trxHeader.description;

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            discount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            vat_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            netPrice_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            salesInvoice_lbl.Text = labelText(0);

            docRef_lbl.Text = labelText(1);
            clientRef_lbl.Text = labelText(2);
            currency_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);

            sku_lbl.Text = labelText(5);
            item_lbl.Text = labelText(6);
            qty_lbl.Text = labelText(7);
            price_lbl.Text = labelText(8);
            extPrice_lbl.Text = labelText(9);

            subtotal_lbl.Text = labelText(10);
            discount_lbl.Text = labelText(11);
            vat_lbl.Text = labelText(12);
            netPrice_lbl.Text = labelText(13);
        }
        protected override string dictionaryStore()
        {
            return "CR1009.SA103";
        }
    }
}
