using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using ArgusDS.Sales.Reports;
using System.Linq;
using System.Collections.Generic;


namespace ArgusCR1012.Sales.Templates
{
    public partial class SAORD02 : ArgusRPT.BaseReport
    {
        public SAORD02()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            const int BPIDC_VAT = 2;

            SharedClasses.JsonProtocol.GetStructure<OrderPrintLayout> webObject = deserializeGet<OrderPrintLayout>();
            DataSource = webObject.record.items;

            companyName_data.Text = webObject.record.companyInfo.name;
            taxNo_data.Text = webObject.record.companyInfo.taxNo;

            clientRef_data.Text = webObject.record.header.clientRef;
            clientName_data.Text = webObject.record.header.clientName;
            if (webObject.record.masterIDs != null)
            {
                ArgusDS.BusinessPartners.MasterIDNumberView vatID = webObject.record.masterIDs.FirstOrDefault(x => x.incId == BPIDC_VAT);
                if (vatID != null)
                    clientVATNo_data.Text = vatID.idNum;
            }
            phoneNumber_data.Text = webObject.record.shipAddress?.phone;
            shipAddress_data.Text = webObject.record.shipAddress?.street1;

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);
            plant_data.Text = webObject.record.header.plantName;
            spName_data.Text = webObject.record.header.spName;

            deliveryOrders_data.Text = webObject.record.deliveryOrders;
            description_data.Text = webObject.record.header.description;

            spName2_data.Text = webObject.record.header.spName;

            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
            tamdeedVatNo_lbl.Text = labelText(0);
            salesOrder_lbl.Text = labelText(1);

            invoiceInfo_lbl.Text = labelText(2);
            reference_lbl.Text = labelText(3);
            date_lbl.Text = labelText(4);
            plant_lbl.Text = labelText(5);
            spName_lbl.Text = labelText(6);

            clientInfo_lbl.Text = labelText(7);
            clientName_lbl.Text = labelText(8);
            clientVATNo_lbl.Text = labelText(9);
            phoneNumber_lbl.Text = labelText(10);
            clientAddress_lbl.Text = labelText(11);

            sku_lbl.Text = labelText(12);
            itemName_lbl.Text = labelText(13);
            qty_lbl.Text = labelText(14);

            deliveryOrderRef_lbl.Text = labelText(15);
            description_lbl.Text = labelText(16);

            sPSig_lbl.Text = labelText(17);
            saPeName_lbl.Text = labelText(18);
            sPeSig_lbl.Text = labelText(19);
        }
        protected override string dictionaryStore()
        {
            return "CR1012.SA102B";
        }
    }
}