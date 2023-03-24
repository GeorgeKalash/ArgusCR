using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1030.Sales
{
    public partial class SA103 : ArgusRPT.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return salesInvoice_lbl.Text;
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;
            companyName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;
            cAddressName_data.Text = companyInfo.address?.name;
            cAddressStreet1_data.Text = companyInfo.address?.street1;
            cAddressCity_data.Text = companyInfo.address?.city;
            cAddressCountryName_data.Text = companyInfo.address?.countryName;
            cAddressPhone_data.Text = companyInfo.address?.phone;
            cEmail_data.Text = companyInfo.address?.email1;  

            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVat_data.Text = webObject.record.client.vatNumber;
            AddressName_data.Text = webObject.record.billAddress?.name;
            AddressStreet1_data.Text = webObject.record.billAddress?.street1;
            AddressCity_data.Text = webObject.record.billAddress?.city;
            AddressCountryName_data.Text = webObject.record.billAddress?.countryName;
            AddressPhone_data.Text = webObject.record.billAddress?.phone;
            Email_data.Text= webObject.record.billAddress?.email1;

            docRef_data.Text = webObject.record.trxHeader.reference;
            clientRef_data.Text = webObject.record.trxHeader.clientRef;
            currency_data.Text = webObject.record.trxHeader.currencyName;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);

            description_data.Text = webObject.record.trxHeader.description;

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            discount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            vat_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            netPrice_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            printSignature_lbl.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1030.SA103";
        }
    }
}