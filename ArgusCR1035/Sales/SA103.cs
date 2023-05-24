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

            logo_data.ImageUrl = companyInfo.logoUrl;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.client.vatNumber;

            seqNo_data.Text = webObject.record.trxHeader.reference;
            datee_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            phoneNumber_data.Text = webObject.record.companyInfo.address?.phone;
            cellphone_data.Text = webObject.record.salesPerson?.cellPhone;

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);
            goldAmountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.sumPureMetalQty, 4, 2);
            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.trxHeader.date, webObject.record.trxHeader.amount.ToString(), webObject.record.trxHeader.vatAmount.ToString()).ToBase64();

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }


        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            ArgusDS.Sales.ItemView obj = ((List<ArgusDS.Sales.ItemView>)DataSource)[e.CurrentRow];
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

