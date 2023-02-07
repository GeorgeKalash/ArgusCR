using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials
{
    public partial class FI401M2 : ArgusRPT.BaseReport
    {
        public FI401M2 ()
        {
            InitializeComponent();
        }

        protected override string reportName()
        {
            return title_lbl.Text;
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Financials.Reports.FI401DualBaseMetal> obj = deserializeGet<ArgusDS.Financials.Reports.FI401DualBaseMetal>();
            DataSource = obj.record.statementOfAccount;
            crossTab.DataSource = obj.record.statementOfAccount;
            if (Parameters.Count > 0)
            {
                fiscalYear_param.Text = Parameters[0].Value.ToString();
                startDate_param.Text = Parameters[1].Value.ToString();
                endDate_param.Text = Parameters[2].Value.ToString();
                account_param.Text = Parameters[3].Value.ToString();
            }
            balanceNonMetal_data.Text = obj.record.baseCurrencyRef;
            balanceBaseMetal_data.Text = obj.record.baseMetalCurrencyRef;

            printSignature.Text = reportSignature();
            base.OnBeforePrint(e);
        }
        protected override void labelsText()
        {
            title_lbl.Text = labelText(0);

            fiscalYear_lbl.Text = labelText(1);
            startDate_lbl.Text = labelText(2);
            endDate_lbl.Text = labelText(3);
            account_lbl.Text = labelText(4);

            date_lbl.Text = labelText(5);
            reference_lbl.Text = labelText(6);
            functionName_lbl.Text = labelText(7);
            plantRef_lbl.Text = labelText(8);
            grandTotal_lbl.Text = labelText(9);
        }
        protected override string dictionaryStore()
        {
            return "CR1029.FI401M2";
        }
    }
}