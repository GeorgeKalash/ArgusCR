using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

//public class Assembly : Activity
//{
//    public int? plantId { get; set; }
//    public int bomId { get; set; }
//    public int itemId { get; set; }
//    public int siteId { get; set; }
//    public int rmSiteId { get; set; }
//    public double qty { get; set; }
//    public double rmCost { get; set; }
//    public string notes { get; set; }

//}

//public class AssemblyView : Assembly
//{
//    public string bomName, sku, itemName, siteName, rmSiteName, plantName, dtName;
//}

//public class AssemblyComponent
//{
//    public int assemblyId { get; set; }
//    public short seqNo { get; set; }
//    public int itemId { get; set; }
//    public int siteId { get; set; }
//    public double designQty { get; set; }
//    public double qty { get; set; }
//    public double cost { get; set; }

//}

//public class AssemblyComponentView : AssemblyComponent
//{
//    public string sku, itemName;
//}

namespace ArgusCR1012.Manufacturing.Templates
{
    public partial class MFASM01 : Reports.BaseReport
    {
        public MFASM01()
        {
            InitializeComponent();
        }

    }
}
