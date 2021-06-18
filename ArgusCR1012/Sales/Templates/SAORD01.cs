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
            SharedClasses.JsonProtocol.GetStructure<OrderPrintLayout> webObject = deserializeGet<OrderPrintLayout>();

            //if (webObject)

            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.header.clientName;
            reference_data.Text = webObject.record.header.reference;
            //date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            billAddressName_data.Text = webObject.record.billAddress?.name;
            billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            //subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            //vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            //amount_data.Text = webObject.record.header.amount.ToString("N2");

            spName_data.Text = webObject.record.header.spName;
            //spCellPhone_data.Text = webObject.record.header.spCellPhone;

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
            xrTableCell14.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA102";
        }
    }
}
