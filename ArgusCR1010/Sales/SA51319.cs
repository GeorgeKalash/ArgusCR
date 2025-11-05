using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1010.Sales
{
    public partial class SA51319 : ArgusRPT.BaseReport
    {
        public SA51319()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {

            SharedClasses.JsonProtocol.GetStructure<ReturnPrintView> webObject = deserializeGet<ReturnPrintView>();
            DataSource = webObject.record.items;

            logo_data.ImageUrl = companyInfo.logoUrl;

            clientName_data.Text = webObject.record.trxHeader.clientName;
            clientVATNo_data.Text = webObject.record.client.vatNumber;
            cAddress_data.Text = webObject.record.billAddress?.street1;

            reference_data.Text = webObject.record.trxHeader.reference;
            date_data.Text = webObject.record.trxHeader.date.ToString(sessionInfo.dateFormat);

            subtotal_data.Text = webObject.record.trxHeader.subtotal.ToString("N0");

            if (webObject?.record?.trxHeader?.tdPct != null)
            {
                tdPer_data.Text = webObject.record.trxHeader.tdPct.Value.ToString("N0");
            }
            else
            {
                tdPer_data.Text = "0";
            }

            tdAmount_data.Text = webObject.record.trxHeader.tdAmount?.ToString("N0") ?? "0";
            vatAmount_data.Text = webObject.record.trxHeader.vatAmount.ToString("N0");
            amount_data.Text = webObject.record.trxHeader.amount.ToString("N0");

            airsi_data.Text = webObject.record.trxHeader.miscAmount?.ToString("N0") ?? "0";

            decimal TotalAPayer = (webObject.record.trxHeader.amount) + (webObject.record.trxHeader.miscAmount ?? 0);
            totalAPayer_data.Text = TotalAPayer.ToString("N0");

        //    volume_data.Text = webObject.record.trxHeader.volume.ToString();
            poids_data.Text = webObject.record.trxHeader.weight.ToString();
            description_data.Text = webObject.record.trxHeader.description;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1010.SA51319";
        }
    }
}