using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
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

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusDS.Manufacturing.Reports.AssemblyPrintView> webObject = deserializeGet<ArgusDS.Manufacturing.Reports.AssemblyPrintView>();

            //if (webObject)

            DataSource = webObject.record.items;

            dtName_data.Text = webObject.record.header.dtName;
            //reference_data.Text = webObject.record.header.reference;
            //date_data.Text = webObject.record.header.date.ToString(sessionInfo.dateFormat);

            //billAddressName_data.Text = webObject.record.billAddress?.name;
            //billAddressPhone_data.Text = webObject.record.billAddress?.phone;

            //subtotal_data.Text = webObject.record.header.subtotal.ToString("N2");
            //vatAmount_data.Text = webObject.record.header.vatAmount.ToString("N2");
            //amount_data.Text = webObject.record.header.amount.ToString("N2");

            //spName_data.Text = webObject.record.header.spName;
            //spCellPhone_data.Text = webObject.record.header.spCellPhone;

            //if (webObject.record.header.deliveryDate != null)
            //    deliveryDate_data.Text = ((DateTime)webObject.record.header.deliveryDate).ToString(sessionInfo.dateFormat);

            //amountInWords_data.Text = SharedClasses.NumberToWords.multiLingualNumberInText((decimal)webObject.record.header.amount, 2, Convert.ToInt16(sessionInfo.languageId));

            //if (webObject.record.header.expiryDate != null)
            //    validity_data.Text = string.Format("{0} days: {1}", webObject.record.header.validity, ((DateTime)webObject.record.header.expiryDate).ToString(sessionInfo.dateFormat));

            //if (webObject.record.shipAddress != null)
            //{
            //    shipToAddress_data.Text = string.Format("{0}\\r\\n{1}\\r\\n{2}", webObject.record.shipAddress.street1, webObject.record.shipAddress.street2, webObject.record.shipAddress.city);
            //}

            base.OnBeforePrint(e);
        }

        protected override void OnDataSourceRowChanged(DataSourceRowEventArgs e)
        {
            //lineNo.Text = itemsCounter.ToString();
            //++itemsCounter;
            base.OnDataSourceRowChanged(e);
        }
        protected override void labelsText()
        {
        }

        protected override string dictionaryStore()
        {
            return "Custom\\R1012\\MF102";
        }

    }
}
