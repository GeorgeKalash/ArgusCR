
namespace ArgusCR1031.Purchase.PU103
{
    partial class InvoiceItemsSubReports
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.sku_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.vtAmount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.mdAmount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.extendedPrice_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.notes_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.sku_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.weight_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vtAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.mdAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.extendedPrice_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.notes_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TotalQuantity_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 28.54166F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(737.2083F, 28.54166F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.sku_data,
            this.itemName_data,
            this.qty_data,
            this.xrTableCell2,
            this.unitPrice_data,
            this.vtAmount_data,
            this.mdAmount_data,
            this.extendedPrice_data,
            this.notes_data});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // sku_data
            // 
            this.sku_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sku_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sku]")});
            this.sku_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.sku_data.Multiline = true;
            this.sku_data.Name = "sku_data";
            this.sku_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.sku_data.StylePriority.UseBorders = false;
            this.sku_data.StylePriority.UseFont = false;
            this.sku_data.StylePriority.UsePadding = false;
            this.sku_data.StylePriority.UseTextAlignment = false;
            this.sku_data.Text = "sku_data";
            this.sku_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.sku_data.Weight = 1.207824300285804D;
            // 
            // itemName_data
            // 
            this.itemName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemName_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemName]")});
            this.itemName_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.itemName_data.Multiline = true;
            this.itemName_data.Name = "itemName_data";
            this.itemName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.itemName_data.StylePriority.UseBorders = false;
            this.itemName_data.StylePriority.UseFont = false;
            this.itemName_data.StylePriority.UsePadding = false;
            this.itemName_data.StylePriority.UseTextAlignment = false;
            this.itemName_data.Text = "itemName_data";
            this.itemName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.itemName_data.Weight = 2.0862415547253574D;
            // 
            // qty_data
            // 
            this.qty_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.qty_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")});
            this.qty_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.qty_data.Multiline = true;
            this.qty_data.Name = "qty_data";
            this.qty_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.qty_data.StylePriority.UseBorders = false;
            this.qty_data.StylePriority.UseFont = false;
            this.qty_data.StylePriority.UsePadding = false;
            this.qty_data.StylePriority.UseTextAlignment = false;
            this.qty_data.Text = "qty_data";
            this.qty_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.qty_data.TextFormatString = "{0:n2}";
            this.qty_data.Weight = 0.60391202423111934D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[weight]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.TextFormatString = "{0:n2}";
            this.xrTableCell2.Weight = 0.60391202423111934D;
            // 
            // unitPrice_data
            // 
            this.unitPrice_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[unitPrice]")});
            this.unitPrice_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.unitPrice_data.Multiline = true;
            this.unitPrice_data.Name = "unitPrice_data";
            this.unitPrice_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.unitPrice_data.StylePriority.UseBorders = false;
            this.unitPrice_data.StylePriority.UseFont = false;
            this.unitPrice_data.StylePriority.UsePadding = false;
            this.unitPrice_data.StylePriority.UseTextAlignment = false;
            this.unitPrice_data.Text = "unitPrice_data";
            this.unitPrice_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPrice_data.TextFormatString = "{0:n2}";
            this.unitPrice_data.Weight = 0.76861568632832089D;
            // 
            // vtAmount_data
            // 
            this.vtAmount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vtAmount_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vatAmount]")});
            this.vtAmount_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.vtAmount_data.Multiline = true;
            this.vtAmount_data.Name = "vtAmount_data";
            this.vtAmount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.vtAmount_data.StylePriority.UseBorders = false;
            this.vtAmount_data.StylePriority.UseFont = false;
            this.vtAmount_data.StylePriority.UsePadding = false;
            this.vtAmount_data.StylePriority.UseTextAlignment = false;
            this.vtAmount_data.Text = "vtAmount_data";
            this.vtAmount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.vtAmount_data.TextFormatString = "{0:n2}";
            this.vtAmount_data.Weight = 0.7686156494974542D;
            // 
            // mdAmount_data
            // 
            this.mdAmount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.mdAmount_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[mdAmount]")});
            this.mdAmount_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.mdAmount_data.Multiline = true;
            this.mdAmount_data.Name = "mdAmount_data";
            this.mdAmount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.mdAmount_data.StylePriority.UseBorders = false;
            this.mdAmount_data.StylePriority.UseFont = false;
            this.mdAmount_data.StylePriority.UsePadding = false;
            this.mdAmount_data.StylePriority.UseTextAlignment = false;
            this.mdAmount_data.Text = "mdAmount_data";
            this.mdAmount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.mdAmount_data.TextFormatString = "{0:n2}";
            this.mdAmount_data.Weight = 0.84137999980271216D;
            // 
            // extendedPrice_data
            // 
            this.extendedPrice_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.extendedPrice_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[extendedPrice]")});
            this.extendedPrice_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.extendedPrice_data.Multiline = true;
            this.extendedPrice_data.Name = "extendedPrice_data";
            this.extendedPrice_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.extendedPrice_data.StylePriority.UseBorders = false;
            this.extendedPrice_data.StylePriority.UseFont = false;
            this.extendedPrice_data.StylePriority.UsePadding = false;
            this.extendedPrice_data.StylePriority.UseTextAlignment = false;
            this.extendedPrice_data.Text = "extendedPrice_data";
            this.extendedPrice_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.extendedPrice_data.TextFormatString = "{0:n2}";
            this.extendedPrice_data.Weight = 0.86055263782078451D;
            // 
            // notes_data
            // 
            this.notes_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.notes_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[notes]")});
            this.notes_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.notes_data.Multiline = true;
            this.notes_data.Name = "notes_data";
            this.notes_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.notes_data.StylePriority.UseBorders = false;
            this.notes_data.StylePriority.UseFont = false;
            this.notes_data.StylePriority.UsePadding = false;
            this.notes_data.StylePriority.UseTextAlignment = false;
            this.notes_data.Text = "notes_data";
            this.notes_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.notes_data.Weight = 1.1199823827885624D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 28.54166F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(737.2083F, 28.54166F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.sku_lbl,
            this.itemName_lbl,
            this.qty_lbl,
            this.weight_lbl,
            this.unitPrice_lbl,
            this.vtAmount_lbl,
            this.mdAmount_lbl,
            this.extendedPrice_lbl,
            this.notes_lbl});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // sku_lbl
            // 
            this.sku_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sku_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sku_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sku_lbl.Multiline = true;
            this.sku_lbl.Name = "sku_lbl";
            this.sku_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.sku_lbl.StylePriority.UseBackColor = false;
            this.sku_lbl.StylePriority.UseBorders = false;
            this.sku_lbl.StylePriority.UseFont = false;
            this.sku_lbl.StylePriority.UsePadding = false;
            this.sku_lbl.StylePriority.UseTextAlignment = false;
            this.sku_lbl.Text = "sku_lbl";
            this.sku_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.sku_lbl.Weight = 1.1677212691571128D;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemName_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_lbl.Multiline = true;
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.itemName_lbl.StylePriority.UseBackColor = false;
            this.itemName_lbl.StylePriority.UseBorders = false;
            this.itemName_lbl.StylePriority.UseFont = false;
            this.itemName_lbl.StylePriority.UsePadding = false;
            this.itemName_lbl.StylePriority.UseTextAlignment = false;
            this.itemName_lbl.Text = "itemName_lbl";
            this.itemName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemName_lbl.Weight = 2.0169730474278094D;
            // 
            // qty_lbl
            // 
            this.qty_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qty_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.qty_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_lbl.Multiline = true;
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.qty_lbl.StylePriority.UseBackColor = false;
            this.qty_lbl.StylePriority.UseBorders = false;
            this.qty_lbl.StylePriority.UseFont = false;
            this.qty_lbl.StylePriority.UsePadding = false;
            this.qty_lbl.StylePriority.UseTextAlignment = false;
            this.qty_lbl.Text = "qty_lbl";
            this.qty_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.qty_lbl.Weight = 0.58386065599635162D;
            // 
            // weight_lbl
            // 
            this.weight_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weight_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.weight_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_lbl.Multiline = true;
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.weight_lbl.StylePriority.UseBackColor = false;
            this.weight_lbl.StylePriority.UseBorders = false;
            this.weight_lbl.StylePriority.UseFont = false;
            this.weight_lbl.StylePriority.UsePadding = false;
            this.weight_lbl.StylePriority.UseTextAlignment = false;
            this.weight_lbl.Text = "weight_lbl";
            this.weight_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.weight_lbl.Weight = 0.58386065599635162D;
            // 
            // unitPrice_lbl
            // 
            this.unitPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitPrice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_lbl.Multiline = true;
            this.unitPrice_lbl.Name = "unitPrice_lbl";
            this.unitPrice_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.unitPrice_lbl.StylePriority.UseBackColor = false;
            this.unitPrice_lbl.StylePriority.UseBorders = false;
            this.unitPrice_lbl.StylePriority.UseFont = false;
            this.unitPrice_lbl.StylePriority.UsePadding = false;
            this.unitPrice_lbl.StylePriority.UseTextAlignment = false;
            this.unitPrice_lbl.Text = "unitPrice_lbl";
            this.unitPrice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.unitPrice_lbl.Weight = 0.74309534272385558D;
            // 
            // vtAmount_lbl
            // 
            this.vtAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vtAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vtAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtAmount_lbl.Multiline = true;
            this.vtAmount_lbl.Name = "vtAmount_lbl";
            this.vtAmount_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.vtAmount_lbl.StylePriority.UseBackColor = false;
            this.vtAmount_lbl.StylePriority.UseBorders = false;
            this.vtAmount_lbl.StylePriority.UseFont = false;
            this.vtAmount_lbl.StylePriority.UsePadding = false;
            this.vtAmount_lbl.StylePriority.UseTextAlignment = false;
            this.vtAmount_lbl.Text = "vtAmount_lbl";
            this.vtAmount_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.vtAmount_lbl.Weight = 0.74309536647540264D;
            // 
            // mdAmount_lbl
            // 
            this.mdAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mdAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.mdAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdAmount_lbl.Multiline = true;
            this.mdAmount_lbl.Name = "mdAmount_lbl";
            this.mdAmount_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.mdAmount_lbl.StylePriority.UseBackColor = false;
            this.mdAmount_lbl.StylePriority.UseBorders = false;
            this.mdAmount_lbl.StylePriority.UseFont = false;
            this.mdAmount_lbl.StylePriority.UsePadding = false;
            this.mdAmount_lbl.StylePriority.UseTextAlignment = false;
            this.mdAmount_lbl.Text = "mdAmount_lbl";
            this.mdAmount_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.mdAmount_lbl.Weight = 0.8134443700062618D;
            // 
            // extendedPrice_lbl
            // 
            this.extendedPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.extendedPrice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.extendedPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedPrice_lbl.Multiline = true;
            this.extendedPrice_lbl.Name = "extendedPrice_lbl";
            this.extendedPrice_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.extendedPrice_lbl.StylePriority.UseBackColor = false;
            this.extendedPrice_lbl.StylePriority.UseBorders = false;
            this.extendedPrice_lbl.StylePriority.UseFont = false;
            this.extendedPrice_lbl.StylePriority.UsePadding = false;
            this.extendedPrice_lbl.StylePriority.UseTextAlignment = false;
            this.extendedPrice_lbl.Text = "extendedPrice_lbl";
            this.extendedPrice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.extendedPrice_lbl.Weight = 0.83198103675411839D;
            // 
            // notes_lbl
            // 
            this.notes_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notes_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.notes_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_lbl.Multiline = true;
            this.notes_lbl.Name = "notes_lbl";
            this.notes_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.notes_lbl.StylePriority.UseBackColor = false;
            this.notes_lbl.StylePriority.UseBorders = false;
            this.notes_lbl.StylePriority.UseFont = false;
            this.notes_lbl.StylePriority.UsePadding = false;
            this.notes_lbl.StylePriority.UseTextAlignment = false;
            this.notes_lbl.Text = "notes_lbl";
            this.notes_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.notes_lbl.Weight = 1.08279618718634D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.ReportFooter.HeightF = 39.79149F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 12.5F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
            this.xrTable6.SizeF = new System.Drawing.SizeF(737.2083F, 27.29149F);
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TotalQuantity_lbl,
            this.xrTableCell6});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // TotalQuantity_lbl
            // 
            this.TotalQuantity_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalQuantity_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TotalQuantity_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.TotalQuantity_lbl.Multiline = true;
            this.TotalQuantity_lbl.Name = "TotalQuantity_lbl";
            this.TotalQuantity_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.TotalQuantity_lbl.StylePriority.UseBackColor = false;
            this.TotalQuantity_lbl.StylePriority.UseBorders = false;
            this.TotalQuantity_lbl.StylePriority.UseFont = false;
            this.TotalQuantity_lbl.StylePriority.UsePadding = false;
            this.TotalQuantity_lbl.Text = "TotalQuantity_lbl";
            this.TotalQuantity_lbl.Weight = 2.0019561788476317D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([qty])")});
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell6.Summary = xrSummary1;
            this.xrTableCell6.Text = "xrTableCell3";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.TextFormatString = "{0:n2}";
            this.xrTableCell6.Weight = 0.35765543796845328D;
            this.xrTableCell6.WordWrap = false;
            // 
            // InvoiceItemsSubReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 89, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell sku_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell qty_lbl;
        private DevExpress.XtraReports.UI.XRTableCell weight_lbl;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vtAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell mdAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell extendedPrice_lbl;
        private DevExpress.XtraReports.UI.XRTableCell notes_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell sku_data;
        private DevExpress.XtraReports.UI.XRTableCell itemName_data;
        private DevExpress.XtraReports.UI.XRTableCell qty_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice_data;
        private DevExpress.XtraReports.UI.XRTableCell vtAmount_data;
        private DevExpress.XtraReports.UI.XRTableCell mdAmount_data;
        private DevExpress.XtraReports.UI.XRTableCell extendedPrice_data;
        private DevExpress.XtraReports.UI.XRTableCell notes_data;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell TotalQuantity_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    }
}
