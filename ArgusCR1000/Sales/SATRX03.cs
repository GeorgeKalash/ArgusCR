﻿using System.Drawing.Printing;
using ArgusDS.Sales.Reports;

namespace ArgusCR1000.Sales.Templates
{
    public partial class SATRX03 : ArgusRPT.BaseReport
    {
        public SATRX03()
        {
            InitializeComponent();            
        }
        protected override string dictionaryStore()
        {
            return "CR1000.SATRX03";
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            DataSource = CreateDataSourceFromText();
            base.OnBeforePrint(e);
        }

        private void Detail_BeforePrint(object sender, PrintEventArgs e)
        {
        }
    }
}