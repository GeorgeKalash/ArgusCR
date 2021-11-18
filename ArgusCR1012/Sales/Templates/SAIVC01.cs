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
       
            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);
            spName_data.Text = webObject.record.trxHeader.spName;

            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.trxHeader.clientVATNo;


            //spCellPhone_data.Text = webObject.record.trxHeader.spCellPhone;
            //date_data.Text = webObject.record.billAddress?.name;
            //billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            taxNo_data.Text = webObject.record.companyInfo.taxNo;
      
            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");
            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, Convert.ToInt16(sessionInfo.languageId));

            clientName2_data.Text = webObject.record.trxHeader.clientName;
            spName2_data.Text = webObject.record.trxHeader.spName;

            QRCode.Text = string.Format("\nالبائع:{0}", webObject.record.companyInfo?.name);
            QRCode.Text += string.Format("\nالرقم الضريبي:{0}", webObject.record.companyInfo?.taxNo);
            QRCode.Text += string.Format( "رقم الفاتورة:" + webObject.record.trxHeader.reference);
            QRCode.Text += string.Format("\nتاريخ الفاتورة:{0}", webObject.record.logTime);
            QRCode.Text += string.Format("\nإجمالي الضريبة:{0}", webObject.record.trxHeader.vatAmount.ToString("N2"));
            QRCode.Text += string.Format("\nإجمالي المبلغ:{0}", webObject.record.trxHeader.amount.ToString("N2"));


            //if (webObject.record.trxHeader.deliveryDate != null)
            //    deliveryDate_data.Text = ((DateTime)webObject.record.trxHeader.deliveryDate).ToString(sessionInfo.dateFormat);
        
            base.OnBeforePrint(e);
        }


        protected override void labelsText()
        {
            taxInvoice_lbl.Text = labelText(0);
          

        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA103";
        }

    }
}
