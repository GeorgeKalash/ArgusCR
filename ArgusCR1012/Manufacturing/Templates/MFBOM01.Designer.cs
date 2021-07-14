
namespace ArgusCR1012.Manufacturing.Templates
{
    partial class MFBOM01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bomTitle_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.tamdeedTitle_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.masagTitle_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.billOfMaterial_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.status_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.status_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.name_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.name_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.version_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.version_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.type_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.type_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.bomQty_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.bomQty_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lineNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.sku_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lineNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.sku_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.pageNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.bomTitle_lbl,
            this.tamdeedTitle_lbl,
            this.masagTitle_lbl,
            this.xrTable1});
            this.ReportHeader.HeightF = 288.5417F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // bomTitle_lbl
            // 
            this.bomTitle_lbl.AutoWidth = true;
            this.bomTitle_lbl.BackColor = System.Drawing.Color.SteelBlue;
            this.bomTitle_lbl.BorderColor = System.Drawing.Color.Black;
            this.bomTitle_lbl.BorderWidth = 0F;
            this.bomTitle_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.bomTitle_lbl.ForeColor = System.Drawing.Color.White;
            this.bomTitle_lbl.LocationFloat = new DevExpress.Utils.PointFloat(602.3182F, 25F);
            this.bomTitle_lbl.Multiline = true;
            this.bomTitle_lbl.Name = "bomTitle_lbl";
            this.bomTitle_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.bomTitle_lbl.SizeF = new System.Drawing.SizeF(221.197F, 69.04665F);
            this.bomTitle_lbl.StylePriority.UseBackColor = false;
            this.bomTitle_lbl.StylePriority.UseBorderColor = false;
            this.bomTitle_lbl.StylePriority.UseBorderWidth = false;
            this.bomTitle_lbl.StylePriority.UseFont = false;
            this.bomTitle_lbl.StylePriority.UseForeColor = false;
            this.bomTitle_lbl.StylePriority.UseTextAlignment = false;
            this.bomTitle_lbl.Text = "Bill Of Materials";
            this.bomTitle_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tamdeedTitle_lbl
            // 
            this.tamdeedTitle_lbl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tamdeedTitle_lbl.Font = new System.Drawing.Font("Times New Roman", 15.38F, System.Drawing.FontStyle.Bold);
            this.tamdeedTitle_lbl.ForeColor = System.Drawing.Color.White;
            this.tamdeedTitle_lbl.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 62.5F);
            this.tamdeedTitle_lbl.Multiline = true;
            this.tamdeedTitle_lbl.Name = "tamdeedTitle_lbl";
            this.tamdeedTitle_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tamdeedTitle_lbl.SizeF = new System.Drawing.SizeF(564.8182F, 31.54665F);
            this.tamdeedTitle_lbl.StylePriority.UseBackColor = false;
            this.tamdeedTitle_lbl.StylePriority.UseFont = false;
            this.tamdeedTitle_lbl.StylePriority.UseForeColor = false;
            this.tamdeedTitle_lbl.StylePriority.UseTextAlignment = false;
            this.tamdeedTitle_lbl.Text = "(Tamdeed)";
            this.tamdeedTitle_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // masagTitle_lbl
            // 
            this.masagTitle_lbl.BackColor = System.Drawing.Color.Azure;
            this.masagTitle_lbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.masagTitle_lbl.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 25F);
            this.masagTitle_lbl.Multiline = true;
            this.masagTitle_lbl.Name = "masagTitle_lbl";
            this.masagTitle_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.masagTitle_lbl.SizeF = new System.Drawing.SizeF(564.8182F, 37.5F);
            this.masagTitle_lbl.StylePriority.UseBackColor = false;
            this.masagTitle_lbl.StylePriority.UseFont = false;
            this.masagTitle_lbl.StylePriority.UseTextAlignment = false;
            this.masagTitle_lbl.Text = "Masag Factory For Plastic Industries";
            this.masagTitle_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 125F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(788.3333F, 154.3749F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.billOfMaterial_lbl});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // billOfMaterial_lbl
            // 
            this.billOfMaterial_lbl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.billOfMaterial_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.billOfMaterial_lbl.Multiline = true;
            this.billOfMaterial_lbl.Name = "billOfMaterial_lbl";
            this.billOfMaterial_lbl.StylePriority.UseBackColor = false;
            this.billOfMaterial_lbl.StylePriority.UseFont = false;
            this.billOfMaterial_lbl.Text = "Bill Of Material";
            this.billOfMaterial_lbl.Weight = 14.024999523346262D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_data,
            this.status_lbl,
            this.status_data});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.Azure;
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.Text = "Reference:";
            this.reference_lbl.Weight = 1.2100508732667241D;
            // 
            // reference_data
            // 
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Text = "reference_data";
            this.reference_data.Weight = 2.7242452160540109D;
            // 
            // status_lbl
            // 
            this.status_lbl.BackColor = System.Drawing.Color.Azure;
            this.status_lbl.Multiline = true;
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.StylePriority.UseBackColor = false;
            this.status_lbl.Text = "Status:";
            this.status_lbl.Weight = 1.8681527990856726D;
            // 
            // status_data
            // 
            this.status_data.Multiline = true;
            this.status_data.Name = "status_data";
            this.status_data.Text = "status_data";
            this.status_data.Weight = 2.2961990075698417D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.name_lbl,
            this.name_data,
            this.version_lbl,
            this.version_data});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // name_lbl
            // 
            this.name_lbl.BackColor = System.Drawing.Color.Azure;
            this.name_lbl.Multiline = true;
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.StylePriority.UseBackColor = false;
            this.name_lbl.Text = "Name:";
            this.name_lbl.Weight = 1.2100508732667241D;
            // 
            // name_data
            // 
            this.name_data.Multiline = true;
            this.name_data.Name = "name_data";
            this.name_data.Text = "name_data";
            this.name_data.Weight = 2.7242449025430684D;
            // 
            // version_lbl
            // 
            this.version_lbl.BackColor = System.Drawing.Color.Azure;
            this.version_lbl.Multiline = true;
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.StylePriority.UseBackColor = false;
            this.version_lbl.Text = "Version:\r\n";
            this.version_lbl.Weight = 1.8681531125966153D;
            // 
            // version_data
            // 
            this.version_data.Multiline = true;
            this.version_data.Name = "version_data";
            this.version_data.Text = "version_data";
            this.version_data.Weight = 2.2961990075698417D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.type_lbl,
            this.type_data,
            this.date_lbl,
            this.date_data});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // type_lbl
            // 
            this.type_lbl.BackColor = System.Drawing.Color.Azure;
            this.type_lbl.Multiline = true;
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.StylePriority.UseBackColor = false;
            this.type_lbl.Text = "Type:";
            this.type_lbl.Weight = 1.2100508732667241D;
            // 
            // type_data
            // 
            this.type_data.Multiline = true;
            this.type_data.Name = "type_data";
            this.type_data.Text = "type_data";
            this.type_data.Weight = 2.7242452160540105D;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.Azure;
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.Text = "Date:";
            this.date_lbl.Weight = 1.868152799085673D;
            // 
            // date_data
            // 
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Text = "date_data";
            this.date_data.Weight = 2.2961990075698417D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_lbl,
            this.description_data,
            this.bomQty_lbl,
            this.bomQty_data});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.Azure;
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.StylePriority.UseBackColor = false;
            this.description_lbl.Text = "Description:";
            this.description_lbl.Weight = 1.2100510969048401D;
            // 
            // description_data
            // 
            this.description_data.Multiline = true;
            this.description_data.Name = "description_data";
            this.description_data.Text = "description_data";
            this.description_data.Weight = 2.7242444939337291D;
            // 
            // bomQty_lbl
            // 
            this.bomQty_lbl.BackColor = System.Drawing.Color.Azure;
            this.bomQty_lbl.Multiline = true;
            this.bomQty_lbl.Name = "bomQty_lbl";
            this.bomQty_lbl.StylePriority.UseBackColor = false;
            this.bomQty_lbl.Text = "Quantity:";
            this.bomQty_lbl.Weight = 1.8681535969709049D;
            // 
            // bomQty_data
            // 
            this.bomQty_data.Multiline = true;
            this.bomQty_data.Name = "bomQty_data";
            this.bomQty_data.Text = "bomQty_data";
            this.bomQty_data.Weight = 2.2961987081667754D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.Detail.HeightF = 40.83328F;
            this.Detail.Name = "Detail";
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 0F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(788.3333F, 40.00003F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lineNo_data,
            this.sku_data,
            this.itemName_data,
            this.qty_data});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // lineNo_data
            // 
            this.lineNo_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineNo_data.Multiline = true;
            this.lineNo_data.Name = "lineNo_data";
            this.lineNo_data.StylePriority.UseBorders = false;
            this.lineNo_data.StylePriority.UseTextAlignment = false;
            this.lineNo_data.Text = "lineNo";
            this.lineNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineNo_data.Weight = 0.61146814342657763D;
            // 
            // sku_data
            // 
            this.sku_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sku_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sku]")});
            this.sku_data.Multiline = true;
            this.sku_data.Name = "sku_data";
            this.sku_data.StylePriority.UseBorders = false;
            this.sku_data.StylePriority.UseTextAlignment = false;
            this.sku_data.Text = "sku";
            this.sku_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.sku_data.Weight = 1.1074536119912193D;
            // 
            // itemName_data
            // 
            this.itemName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemName_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemName]")});
            this.itemName_data.Multiline = true;
            this.itemName_data.Name = "itemName_data";
            this.itemName_data.StylePriority.UseBorders = false;
            this.itemName_data.StylePriority.UseTextAlignment = false;
            this.itemName_data.Text = "name";
            this.itemName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.itemName_data.Weight = 2.1585785769907888D;
            // 
            // qty_data
            // 
            this.qty_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.qty_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")});
            this.qty_data.Multiline = true;
            this.qty_data.Name = "qty_data";
            this.qty_data.StylePriority.UseBorders = false;
            this.qty_data.StylePriority.UseTextAlignment = false;
            this.qty_data.Text = "quantity";
            this.qty_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.qty_data.Weight = 1.0943149911547572D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.PageHeader.HeightF = 42.50002F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.Azure;
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(788.3334F, 42.50002F);
            this.xrTable3.StylePriority.UseBackColor = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lineNo_lbl,
            this.sku_lbl,
            this.itemName_lbl,
            this.qty_lbl});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // lineNo_lbl
            // 
            this.lineNo_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineNo_lbl.Multiline = true;
            this.lineNo_lbl.Name = "lineNo_lbl";
            this.lineNo_lbl.StylePriority.UseBorders = false;
            this.lineNo_lbl.StylePriority.UseTextAlignment = false;
            this.lineNo_lbl.Text = "lineNo";
            this.lineNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineNo_lbl.Weight = 0.41864051796024471D;
            // 
            // sku_lbl
            // 
            this.sku_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sku_lbl.Multiline = true;
            this.sku_lbl.Name = "sku_lbl";
            this.sku_lbl.StylePriority.UseBorders = false;
            this.sku_lbl.StylePriority.UseTextAlignment = false;
            this.sku_lbl.Text = "SKU";
            this.sku_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.sku_lbl.Weight = 0.75821603125863013D;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemName_lbl.Multiline = true;
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.StylePriority.UseBorders = false;
            this.itemName_lbl.StylePriority.UseTextAlignment = false;
            this.itemName_lbl.Text = "Name";
            this.itemName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.itemName_lbl.Weight = 1.477866769192246D;
            // 
            // qty_lbl
            // 
            this.qty_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.qty_lbl.Multiline = true;
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.StylePriority.UseBorders = false;
            this.qty_lbl.StylePriority.UseTextAlignment = false;
            this.qty_lbl.Text = "Quantity";
            this.qty_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.qty_lbl.Weight = 0.7492211710950033D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageNumber_lbl,
            this.printSignature_lbl});
            this.ReportFooter.HeightF = 32.49995F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // pageNumber_lbl
            // 
            this.pageNumber_lbl.BackColor = System.Drawing.Color.PowderBlue;
            this.pageNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(725F, 0F);
            this.pageNumber_lbl.Name = "pageNumber_lbl";
            this.pageNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageNumber_lbl.SizeF = new System.Drawing.SizeF(98.51514F, 23F);
            this.pageNumber_lbl.StylePriority.UseBackColor = false;
            this.pageNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pageNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pageNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(150F, 0F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(447.0301F, 23.00002F);
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // MFBOM01
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.PageHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 100, 100);
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell sku_data;
        private DevExpress.XtraReports.UI.XRTableCell itemName_data;
        private DevExpress.XtraReports.UI.XRTableCell qty_data;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell sku_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell qty_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell billOfMaterial_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableCell status_lbl;
        private DevExpress.XtraReports.UI.XRTableCell status_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell name_lbl;
        private DevExpress.XtraReports.UI.XRTableCell name_data;
        private DevExpress.XtraReports.UI.XRTableCell version_lbl;
        private DevExpress.XtraReports.UI.XRTableCell version_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell type_lbl;
        private DevExpress.XtraReports.UI.XRTableCell type_data;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell description_lbl;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.XRTableCell lineNo_data;
        private DevExpress.XtraReports.UI.XRTableCell lineNo_lbl;
        private DevExpress.XtraReports.UI.XRTableCell bomQty_lbl;
        private DevExpress.XtraReports.UI.XRTableCell bomQty_data;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pageNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.XRLabel tamdeedTitle_lbl;
        private DevExpress.XtraReports.UI.XRLabel masagTitle_lbl;
        private DevExpress.XtraReports.UI.XRLabel bomTitle_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
    }
}
