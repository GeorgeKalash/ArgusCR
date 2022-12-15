using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using ArgusDS.Inventory;
using System.Collections.Generic;
using System.Linq;

namespace ArgusCR1012.Sales.Templates
{
    public partial class SA104 : ArgusRPT.BaseReport
    {
  
      public SA104()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            const int BPIDC_VAT = 2;

            SharedClasses.JsonProtocol.GetStructure<ReturnPrintView> webObject = deserializeGet<ReturnPrintView>();
            DataSource = webObject.record.items;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            reference_data.Text = webObject.record.trxHeader.reference;

            if (webObject.record.logTime != null)
            {
                date_data.Text = ((DateTime)webObject.record.logTime).ToString(sessionInfo.dateFormat) + " " + ((DateTime)webObject.record.logTime).ToString("HH:mm");
            }
            plant_data.Text = webObject.record.trxHeader.plantName;
            licenseNo_data.Text = webObject.record.companyInfo.licenseNo;
            crNo_data.Text = webObject.record.companyInfo.crNo;
            address_data.Text = webObject.record.companyInfo.address?.street1;
            spName_data.Text = webObject.record.salesPerson?.name;
            cellPhone_data.Text = webObject.record.salesPerson?.cellPhone;

            clientRef_data.Text = webObject.record.client.reference;
            clientName_data.Text = webObject.record.client.name;

            if (webObject.record.masterIDs != null)
            {
                ArgusDS.BusinessPartners.MasterIDNumberView vatID = webObject.record.masterIDs.FirstOrDefault(x => x.incId == BPIDC_VAT);
                if (vatID != null)
                    clientVATNo_data.Text = vatID.idNum;
            }



            if (webObject.record.bpDefaultIDCategoryId != null)
            {
                ArgusDS.BusinessPartners.MasterIDNumberView otherID = webObject.record.masterIDs.FirstOrDefault(x => x.incId == webObject.record.bpDefaultIDCategoryId);
                if (otherID != null)
                {
                    idNo_data.Text = otherID.idNum;
                    idNo_lbl.Text = otherID.incName;
                }
            }

            phoneNumber_data.Text = webObject.record.billAddress?.phone;
            cAddress_data.Text = webObject.record.billAddress?.street1;
          
            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N2");
            tdAmount_data.Text = webObject.record.trxHeader.tdAmount.ToString();
            double TotalAmountNonSubjectToTax = webObject.record.trxHeader.subtotal - (webObject.record.trxHeader.tdAmount ?? 0);
            totalSub_data.Text = TotalAmountNonSubjectToTax.ToString("N2");
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N2");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N2");

            amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.trxHeader.amount, 2, 2);

            description_data.Text = webObject.record.trxHeader.notes;
            invoiceRef_data.Text = webObject.record.trxHeader.invoiceRef;

            clientName2_data.Text = webObject.record.trxHeader.clientName;
            spName2_data.Text = webObject.record.trxHeader.spName;

            QRCode.Text = new KSAeInvoiceQrCode(webObject.record.companyInfo.name, webObject.record.companyInfo.taxNo, (DateTime)webObject.record.logTime, webObject.record.trxHeader.amount.ToString(), webObject.record.trxHeader.vatAmount.ToString()).ToBase64();
            base.OnBeforePrint(e);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            ArgusDS.Sales.ReturnItemView obj = ((List<ArgusDS.Sales.ReturnItemView>)DataSource)[e.CurrentRow];
            
            double netUnitPrice = obj.unitPrice - (obj.mdValue ?? 0);
            double epWithVAT = obj.extendedPrice + obj.vatAmount;

            unitPrice_data.Text = netUnitPrice.ToString("N2");

            extendedPriceWithVAT_data.Text = epWithVAT.ToString("N2");

            base.OnDataSourceRowChanged(e);
        }

        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "CR1012.SA104";
        }
    }
}

