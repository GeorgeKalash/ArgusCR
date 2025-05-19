using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1010.Sales
{
    public partial class SA51302 : ArgusRPT.BaseReport
    {
        public SA51302()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<OrderPrintLayout> webObject = deserializeGet<OrderPrintLayout>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;

            clientName_data.Text = webObject.record.header.clientName;
           // clientVATNo_data.Text = webObject.record.client.vatNumber;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            reference_data.Text = webObject.record.header.reference;
            date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.header.subtotal.ToString("N0");

            if (webObject?.record?.header?.tdPct != null)
            {
                tdPer_data.Text = webObject.record.header.tdPct.Value.ToString("N0");
            }
            else
            {
                tdPer_data.Text = "0";
            }

            tdAmount_data.Text = webObject.record.header.tdAmount?.ToString("N0") ?? "0";
            vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N0");
            amount_data.Text = webObject.record.header.amount.ToString("N0");

            airsi_data.Text = webObject.record.header.miscAmount.ToString("N0") ?? "0";

            decimal TotalAPayer = (webObject.record.header.amount) + (webObject.record.header.miscAmount);
            totalAPayer_data.Text = TotalAPayer.ToString("N0");

            volume_data.Text = webObject.record.header.volume.ToString();
            poids_data.Text = webObject.record.header.weight.ToString();

            description_data.Text = webObject.record.header.description;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1010.SA51302";
        }
    }
}