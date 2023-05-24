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

namespace ArgusCR1035.Sales
{
    public partial class SA103 : ArgusRPT.BaseReport
    {
        public SA103()
        {
            InitializeComponent();
        }
        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<TrxPrintView> webObject = deserializeGet<TrxPrintView>();
            DataSource = webObject.record.items;
            
            base.OnBeforePrint(e);
        }


        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "";
        }
    }
}

