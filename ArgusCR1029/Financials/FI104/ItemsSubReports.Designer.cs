﻿
namespace ArgusCR1029.Financials.FI104
{
    partial class ItemsSubReports
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.metal_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.sku_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.purity_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.labor_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalLabor_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.subtotal_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vatAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.extendedPrice_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
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
            this.xrTable3});
            this.Detail.HeightF = 24.99933F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable3.SizeF = new System.Drawing.SizeF(807F, 24.99933F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell8,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell9});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.White;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[metalRef]")});
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Metal";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.74328784649999158D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.White;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sku]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "SKU";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 0.99104990930627168D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.White;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[itemName]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Item Name";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell3.Weight = 1.8169257914486297D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.White;
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[purity]")});
            this.xrTableCell8.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell8.Weight = 0.743287115984834D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.White;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")});
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Qty";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell4.TextFormatString = "{0:n2}";
            this.xrTableCell4.Weight = 0.743287626757853D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.White;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditAmount]")});
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Labor";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.TextFormatString = "{0:n2}";
            this.xrTableCell5.Weight = 0.74328711209825482D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.White;
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalCredit]")});
            this.xrTableCell9.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell9.TextFormatString = "{0:n2}";
            this.xrTableCell9.Weight = 0.74328834573707925D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrTable2});
            this.PageHeader.HeightF = 68.74933F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable2.SizeF = new System.Drawing.SizeF(807F, 24.99933F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.metal_lbl,
            this.sku_lbl,
            this.itemName_lbl,
            this.purity_lbl,
            this.qty_lbl,
            this.labor_lbl,
            this.totalLabor_lbl});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // metal_lbl
            // 
            this.metal_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metal_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.metal_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.metal_lbl.Multiline = true;
            this.metal_lbl.Name = "metal_lbl";
            this.metal_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.metal_lbl.StylePriority.UseBackColor = false;
            this.metal_lbl.StylePriority.UseBorders = false;
            this.metal_lbl.StylePriority.UseFont = false;
            this.metal_lbl.StylePriority.UsePadding = false;
            this.metal_lbl.StylePriority.UseTextAlignment = false;
            this.metal_lbl.Text = "Metal";
            this.metal_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.metal_lbl.Weight = 0.72762984801181263D;
            // 
            // sku_lbl
            // 
            this.sku_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sku_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sku_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.sku_lbl.Multiline = true;
            this.sku_lbl.Name = "sku_lbl";
            this.sku_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.sku_lbl.StylePriority.UseBackColor = false;
            this.sku_lbl.StylePriority.UseBorders = false;
            this.sku_lbl.StylePriority.UseFont = false;
            this.sku_lbl.StylePriority.UsePadding = false;
            this.sku_lbl.StylePriority.UseTextAlignment = false;
            this.sku_lbl.Text = "SKU";
            this.sku_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.sku_lbl.Weight = 0.97017308066412467D;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemName_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.itemName_lbl.Multiline = true;
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.itemName_lbl.StylePriority.UseBackColor = false;
            this.itemName_lbl.StylePriority.UseBorders = false;
            this.itemName_lbl.StylePriority.UseFont = false;
            this.itemName_lbl.StylePriority.UsePadding = false;
            this.itemName_lbl.StylePriority.UseTextAlignment = false;
            this.itemName_lbl.Text = "Item Name";
            this.itemName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemName_lbl.Weight = 1.7786506535489481D;
            // 
            // purity_lbl
            // 
            this.purity_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purity_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.purity_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.purity_lbl.Multiline = true;
            this.purity_lbl.Name = "purity_lbl";
            this.purity_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.purity_lbl.StylePriority.UseBackColor = false;
            this.purity_lbl.StylePriority.UseBorders = false;
            this.purity_lbl.StylePriority.UseFont = false;
            this.purity_lbl.StylePriority.UsePadding = false;
            this.purity_lbl.StylePriority.UseTextAlignment = false;
            this.purity_lbl.Text = "Purity";
            this.purity_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.purity_lbl.Weight = 0.72762979621992763D;
            // 
            // qty_lbl
            // 
            this.qty_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qty_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.qty_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.qty_lbl.Multiline = true;
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.qty_lbl.StylePriority.UseBackColor = false;
            this.qty_lbl.StylePriority.UseBorders = false;
            this.qty_lbl.StylePriority.UseFont = false;
            this.qty_lbl.StylePriority.UsePadding = false;
            this.qty_lbl.StylePriority.UseTextAlignment = false;
            this.qty_lbl.Text = "Qty";
            this.qty_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.qty_lbl.Weight = 0.72762979384285731D;
            // 
            // labor_lbl
            // 
            this.labor_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labor_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.labor_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.labor_lbl.Multiline = true;
            this.labor_lbl.Name = "labor_lbl";
            this.labor_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.labor_lbl.StylePriority.UseBackColor = false;
            this.labor_lbl.StylePriority.UseBorders = false;
            this.labor_lbl.StylePriority.UseFont = false;
            this.labor_lbl.StylePriority.UsePadding = false;
            this.labor_lbl.StylePriority.UseTextAlignment = false;
            this.labor_lbl.Text = "Labor";
            this.labor_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.labor_lbl.Weight = 0.72762983413029358D;
            // 
            // totalLabor_lbl
            // 
            this.totalLabor_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalLabor_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.totalLabor_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.totalLabor_lbl.Multiline = true;
            this.totalLabor_lbl.Name = "totalLabor_lbl";
            this.totalLabor_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.totalLabor_lbl.StylePriority.UseBackColor = false;
            this.totalLabor_lbl.StylePriority.UseBorders = false;
            this.totalLabor_lbl.StylePriority.UseFont = false;
            this.totalLabor_lbl.StylePriority.UsePadding = false;
            this.totalLabor_lbl.StylePriority.UseTextAlignment = false;
            this.totalLabor_lbl.Text = "Total Labor";
            this.totalLabor_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.totalLabor_lbl.Weight = 0.727629895812238D;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable6.BorderWidth = 0.5F;
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.99933F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable6.SizeF = new System.Drawing.SizeF(755.2271F, 28.74962F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseBorderWidth = false;
            this.xrTable6.StylePriority.UseFont = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell12,
            this.unitPrice_lbl,
            this.subtotal_lbl,
            this.vatAmount_lbl,
            this.extendedPrice_lbl});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseBorders = false;
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "رقم الصنف";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 1.4896951664395934D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "اسم الصنف";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 1.8509385480897043D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "الوزن";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 0.81933225166791157D;
            // 
            // unitPrice_lbl
            // 
            this.unitPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitPrice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.unitPrice_lbl.Multiline = true;
            this.unitPrice_lbl.Name = "unitPrice_lbl";
            this.unitPrice_lbl.StylePriority.UseBackColor = false;
            this.unitPrice_lbl.StylePriority.UseBorders = false;
            this.unitPrice_lbl.StylePriority.UseFont = false;
            this.unitPrice_lbl.StylePriority.UseTextAlignment = false;
            this.unitPrice_lbl.Text = "أجرة الجرام";
            this.unitPrice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPrice_lbl.Weight = 0.81933222413203644D;
            // 
            // subtotal_lbl
            // 
            this.subtotal_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotal_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.subtotal_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.subtotal_lbl.Multiline = true;
            this.subtotal_lbl.Name = "subtotal_lbl";
            this.subtotal_lbl.StylePriority.UseBackColor = false;
            this.subtotal_lbl.StylePriority.UseBorders = false;
            this.subtotal_lbl.StylePriority.UseFont = false;
            this.subtotal_lbl.StylePriority.UseTextAlignment = false;
            this.subtotal_lbl.Text = "إجمالي الأجور قبل الضريبة";
            this.subtotal_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.subtotal_lbl.Weight = 1.0924429793396233D;
            // 
            // vatAmount_lbl
            // 
            this.vatAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vatAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.vatAmount_lbl.Multiline = true;
            this.vatAmount_lbl.Name = "vatAmount_lbl";
            this.vatAmount_lbl.StylePriority.UseBackColor = false;
            this.vatAmount_lbl.StylePriority.UseBorders = false;
            this.vatAmount_lbl.StylePriority.UseFont = false;
            this.vatAmount_lbl.StylePriority.UseTextAlignment = false;
            this.vatAmount_lbl.Text = "مبلغ الضریبة";
            this.vatAmount_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.vatAmount_lbl.Weight = 1.0924430057315704D;
            // 
            // extendedPrice_lbl
            // 
            this.extendedPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.extendedPrice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.extendedPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.extendedPrice_lbl.Multiline = true;
            this.extendedPrice_lbl.Name = "extendedPrice_lbl";
            this.extendedPrice_lbl.StylePriority.UseBackColor = false;
            this.extendedPrice_lbl.StylePriority.UseBorders = false;
            this.extendedPrice_lbl.StylePriority.UseFont = false;
            this.extendedPrice_lbl.StylePriority.UseTextAlignment = false;
            this.extendedPrice_lbl.Text = "إجمالي الأجوربعد الضريبة";
            this.extendedPrice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.extendedPrice_lbl.Weight = 1.1172716088298453D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "الصنف";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 1.4896951664395934D;
            // 
            // ItemsSubReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 19, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell metal_lbl;
        private DevExpress.XtraReports.UI.XRTableCell sku_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell purity_lbl;
        private DevExpress.XtraReports.UI.XRTableCell qty_lbl;
        private DevExpress.XtraReports.UI.XRTableCell labor_lbl;
        private DevExpress.XtraReports.UI.XRTableCell totalLabor_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice_lbl;
        private DevExpress.XtraReports.UI.XRTableCell subtotal_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell extendedPrice_lbl;
    }
}
