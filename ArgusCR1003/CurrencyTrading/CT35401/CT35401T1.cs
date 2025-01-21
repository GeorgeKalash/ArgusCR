using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.CurrencyTrading.CT35401
{
    public partial class CT35401T1 : ArgusRPT.BaseReport
    {
        public CT35401T1()
        {
            InitializeComponent();
        }
        public override void setSessionInfo(Dictionary<string, string> _reportHeaders)
        {
            base.setSessionInfo(_reportHeaders);
            ((ArgusRPT.BaseReport)(OperationSubReports.ReportSource)).setSessionInfo(sessionInfo);
            ((ArgusRPT.BaseReport)(ReceiptsSubReports.ReportSource)).setSessionInfo(sessionInfo);
            initSubReports();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Trading.Report.CT101> webObject = deserializeGet<ArgusCT_DS.Trading.Report.CT101>();

            date_data.Text = webObject.record.header.date.ToString("dd/MM/yyyy"); ;
            type_data.Text = webObject.record.header.functionName;

            cashier_data.Text = webObject.record.header.cashAccountRef;
            branch_data.Text = webObject.record.header.plantRef;
                
            nationality_data.Text = webObject.record.header.nationalityName;
            name_data.Text = webObject.record.header.clientName;
            id_data.Text = webObject.record.header.idNo;

            ((OperationSubReport)(OperationSubReports.ReportSource)).data = webObject.record.items;
            ((ReceiptsSubReports)(ReceiptsSubReports.ReportSource)).data = webObject.record.receipts;

            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.CT35401T1";
        }
    }
}