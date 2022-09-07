using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;

namespace ArgusCR1012.Sales.Templates
{
    public partial class SAQTN01 : ArgusRPT.BaseReport
    {
        int itemsCounter = 1;
        public SAQTN01()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<QuotationPrintLayout> webObject = deserializeGet<QuotationPrintLayout>();

            //if (webObject)

            DataSource = webObject.record.items;

            clientName_data.Text = webObject.record.header.clientName;
            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            billAddressName_data.Text = webObject.record.billAddress?.name;
            billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.header.amount.ToString("N2");

            spName_data.Text = webObject.record.header.spName;
            spCellPhone_data.Text = webObject.record.header.spCellPhone;

            if (webObject.record.header.deliveryDate != null)
                deliveryDate_data.Text = ((DateTime) webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal) webObject.record.header.amount, 2, Convert.ToInt16(sessionInfo.languageId));

            if (webObject.record.header.expiryDate != null)
                validity_data.Text = string.Format("{0} days: {1}", webObject.record.header.validity, ((DateTime)webObject.record.header.expiryDate).ToString(sessionInfo.dateFormat));

            if (webObject.record.shipAddress != null)
            {
                shipToAddress_data.Text = string.Format("{0}\\r\\n{1}\\r\\n{2}", webObject.record.shipAddress.street1, webObject.record.shipAddress.street2, webObject.record.shipAddress.city);
            }

            base.OnBeforePrint(e);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            lineNo.Text = itemsCounter.ToString();
            ++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override void labelsText()
        {
            qt_lbl.Text = labelText(0);
            customer_lbl.Text = labelText(1);
            contactName_lbl.Text = labelText(2);
            contactNo_lbl.Text = labelText(3);
            ref_lbl.Text = labelText(4);
            refNo_lbl.Text = labelText(5);
            date_lbl.Text = labelText(6);
            salesP_lbl.Text = labelText(7);
            contactNo2_lbl.Text = labelText(8);
            itemNo_lbl.Text = labelText(9);
            pcNo_lbl.Text = labelText(10);
            dpd_lbl.Text = labelText(11);
            //qty_lbl.Text = labelText(12);
            //up_lbl.Text = labelText(13);
            //totalAm_lbl.Text = labelText(14);
            totalAmInWords_lbl.Text = labelText(15);

            subtotal_lbl.Text = labelText(16);
            vat_lbl.Text = labelText(17);
            totalSR_lbl.Text = labelText(18);
            SDI_lbl.Text = labelText(19);
            dd_lbl.Text = labelText(20);
            dTo_lbl.Text = labelText(21);
            shippingMode_lbl.Text = labelText(22);
            paymentTerms_lbl.Text = labelText(23);
            validity_lbl.Text = labelText(24);
            remarks_lbl.Text = labelText(25);
            customerAcc_lbl.Text = labelText(26);
            authSig_lbl.Text = labelText(27);
            dateSeal_lbl.Text = labelText(28);
            prepBy_lbl.Text = labelText(29);
            appBy_lbl.Text = labelText(30);
            recBy_lbl.Text = labelText(31);
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\SA101";
        }
        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
