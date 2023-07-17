using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Collections.Generic;

namespace ArgusCR1035.Sales
{
    public partial class SA104 : ArgusRPT.BaseReport
    {
        public SA104()
        {
            InitializeComponent();
        }
        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;

            SharedClasses.JsonProtocol.GetStructure<ReturnPrintView> webObject = deserializeGet<ReturnPrintView>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;

            if (companyInfo.address != null)
            {
                addressName_data.Text = companyInfo.address.name;
                addressStreet_data.Text = companyInfo.address.street1;
                addressMobile_data.Text = companyInfo.address.phone;
                addressEmail_data.Text = companyInfo.address.email1;
            }
            companyName_data.Text = companyInfo.name;
            taxNo_data.Text = companyInfo.taxNo;

            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientAddress_data.Text = webObject.record.billAddress?.street1;
            clientVATNo_data.Text = webObject.record.client.vatNumber;

            seqNo_data.Text = webObject.record.trxHeader.reference;
            datee_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            phoneNumber_data.Text = webObject.record.billAddress?.phone;
            cellphone_data.Text = webObject.record.salesPerson?.cellPhone;

            invoiceRef_data.Text = webObject.record.trxHeader.invoiceRef;

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);
            QRCode.Text = new KSAeInvoiceQrCode(companyInfo.name, companyInfo.taxNo, (DateTime)webObject.record.trxHeader.date, webObject.record.trxHeader.amount.ToString(), webObject.record.trxHeader.vatAmount.ToString()).ToBase64();
            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            ArgusDS.Sales.ReturnItemView obj = ((List<ArgusDS.Sales.ReturnItemView>)DataSource)[e.CurrentRow];

            double netUnitPrice = obj.unitPrice - (obj.mdValue ?? 0);
            unitPrice_data.Text = netUnitPrice.ToString("N2");
            base.OnDataSourceRowChanged(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1035.SA103";
        }
    }
}