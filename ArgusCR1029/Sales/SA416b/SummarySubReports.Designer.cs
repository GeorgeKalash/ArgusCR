
namespace ArgusCR1029.Sales.SA416b
{
    partial class SummarySubReports
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
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.vatAmount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.amount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.G18_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.G21_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.laborPrice_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.netSalesAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vatAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalWithVat_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalCost_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.grossProfit_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
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
            this.Detail.HeightF = 20.8334F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.BorderWidth = 0.5F;
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable3.SizeF = new System.Drawing.SizeF(720.4904F, 20.8334F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseBorderWidth = false;
            this.xrTable3.StylePriority.UseFont = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell10,
            this.xrTableCell26,
            this.xrTableCell11,
            this.xrTableCell12,
            this.vatAmount_data,
            this.amount_data,
            this.xrTableCell23,
            this.xrTableCell4});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.BorderWidth = 1F;
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[metalRef]")});
            this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseBorderWidth = false;
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UsePadding = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell25.Weight = 0.5311926165731341D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.BorderWidth = 1F;
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")});
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseBorderWidth = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.TextFormatString = "{0:n2}";
            this.xrTableCell10.Weight = 0.53119253632070407D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.BorderWidth = 1F;
            this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[baseQty21]")});
            this.xrTableCell26.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseBorderWidth = false;
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.StylePriority.UsePadding = false;
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell26.TextFormatString = "{0:n2}";
            this.xrTableCell26.Weight = 0.53119244666667109D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.BorderWidth = 1F;
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")});
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseBorderWidth = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell11.TextFormatString = "{0:n2}";
            this.xrTableCell11.Weight = 0.48799395514056892D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.BorderWidth = 1F;
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[netSalesAmount]")});
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseBorderWidth = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell12.TextFormatString = "{0:n2}";
            this.xrTableCell12.Weight = 0.531192287654916D;
            // 
            // vatAmount_data
            // 
            this.vatAmount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vatAmount_data.BorderWidth = 1F;
            this.vatAmount_data.CanGrow = false;
            this.vatAmount_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vatAmount]")});
            this.vatAmount_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.vatAmount_data.Name = "vatAmount_data";
            this.vatAmount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.vatAmount_data.StylePriority.UseBorders = false;
            this.vatAmount_data.StylePriority.UseBorderWidth = false;
            this.vatAmount_data.StylePriority.UseFont = false;
            this.vatAmount_data.StylePriority.UsePadding = false;
            this.vatAmount_data.StylePriority.UseTextAlignment = false;
            this.vatAmount_data.Text = "vatAmount_data";
            this.vatAmount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.vatAmount_data.TextFormatString = "{0:n2}";
            this.vatAmount_data.Weight = 0.46479367000760308D;
            this.vatAmount_data.WordWrap = false;
            // 
            // amount_data
            // 
            this.amount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.amount_data.BorderWidth = 1F;
            this.amount_data.CanGrow = false;
            this.amount_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]+[vatAmount]")});
            this.amount_data.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.amount_data.Name = "amount_data";
            this.amount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.amount_data.StylePriority.UseBorders = false;
            this.amount_data.StylePriority.UseBorderWidth = false;
            this.amount_data.StylePriority.UseFont = false;
            this.amount_data.StylePriority.UsePadding = false;
            this.amount_data.StylePriority.UseTextAlignment = false;
            this.amount_data.Text = "amount_data";
            this.amount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.amount_data.TextFormatString = "{0:n2}";
            this.amount_data.Weight = 0.46479382975559286D;
            this.amount_data.WordWrap = false;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.BorderWidth = 1F;
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cogs]")});
            this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseBorderWidth = false;
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UsePadding = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell23.TextFormatString = "{0:n2}";
            this.xrTableCell23.Weight = 0.46479310679161D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.BorderWidth = 1F;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[grossProfit]")});
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseBorderWidth = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.TextFormatString = "{0:n2}";
            this.xrTableCell4.Weight = 0.46479339522346019D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable8
            // 
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.BorderWidth = 0.5F;
            this.xrTable8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow18});
            this.xrTable8.SizeF = new System.Drawing.SizeF(720.4904F, 25F);
            this.xrTable8.StylePriority.UseBorders = false;
            this.xrTable8.StylePriority.UseBorderWidth = false;
            this.xrTable8.StylePriority.UseFont = false;
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.G18_lbl,
            this.G21_lbl,
            this.xrTableCell5,
            this.laborPrice_lbl,
            this.netSalesAmount_lbl,
            this.vatAmount_lbl,
            this.totalWithVat_lbl,
            this.totalCost_lbl,
            this.grossProfit_lbl});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // G18_lbl
            // 
            this.G18_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.G18_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.G18_lbl.BorderWidth = 1F;
            this.G18_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.G18_lbl.Multiline = true;
            this.G18_lbl.Name = "G18_lbl";
            this.G18_lbl.StylePriority.UseBackColor = false;
            this.G18_lbl.StylePriority.UseBorders = false;
            this.G18_lbl.StylePriority.UseBorderWidth = false;
            this.G18_lbl.StylePriority.UseFont = false;
            this.G18_lbl.Text = "Metal";
            this.G18_lbl.Weight = 0.74510953506213173D;
            // 
            // G21_lbl
            // 
            this.G21_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.G21_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.G21_lbl.BorderWidth = 1F;
            this.G21_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.G21_lbl.Multiline = true;
            this.G21_lbl.Name = "G21_lbl";
            this.G21_lbl.StylePriority.UseBackColor = false;
            this.G21_lbl.StylePriority.UseBorders = false;
            this.G21_lbl.StylePriority.UseBorderWidth = false;
            this.G21_lbl.StylePriority.UseFont = false;
            this.G21_lbl.Text = "Qty";
            this.G21_lbl.Weight = 0.74510951848346885D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.BorderWidth = 1F;
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseBorderWidth = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = "Base Qty 21";
            this.xrTableCell5.Weight = 0.74510951848346885D;
            // 
            // laborPrice_lbl
            // 
            this.laborPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.laborPrice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.laborPrice_lbl.BorderWidth = 1F;
            this.laborPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.laborPrice_lbl.Multiline = true;
            this.laborPrice_lbl.Name = "laborPrice_lbl";
            this.laborPrice_lbl.StylePriority.UseBackColor = false;
            this.laborPrice_lbl.StylePriority.UseBorders = false;
            this.laborPrice_lbl.StylePriority.UseBorderWidth = false;
            this.laborPrice_lbl.StylePriority.UseFont = false;
            this.laborPrice_lbl.Text = "Sales Amount";
            this.laborPrice_lbl.Weight = 0.684514513586934D;
            // 
            // netSalesAmount_lbl
            // 
            this.netSalesAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.netSalesAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.netSalesAmount_lbl.BorderWidth = 1F;
            this.netSalesAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.netSalesAmount_lbl.Multiline = true;
            this.netSalesAmount_lbl.Name = "netSalesAmount_lbl";
            this.netSalesAmount_lbl.StylePriority.UseBackColor = false;
            this.netSalesAmount_lbl.StylePriority.UseBorders = false;
            this.netSalesAmount_lbl.StylePriority.UseBorderWidth = false;
            this.netSalesAmount_lbl.StylePriority.UseFont = false;
            this.netSalesAmount_lbl.Text = "Net Sales Amount";
            this.netSalesAmount_lbl.Weight = 0.7451094795622325D;
            // 
            // vatAmount_lbl
            // 
            this.vatAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vatAmount_lbl.BorderWidth = 1F;
            this.vatAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.vatAmount_lbl.Multiline = true;
            this.vatAmount_lbl.Name = "vatAmount_lbl";
            this.vatAmount_lbl.StylePriority.UseBackColor = false;
            this.vatAmount_lbl.StylePriority.UseBorders = false;
            this.vatAmount_lbl.StylePriority.UseBorderWidth = false;
            this.vatAmount_lbl.StylePriority.UseFont = false;
            this.vatAmount_lbl.Text = "Vat Amount";
            this.vatAmount_lbl.Weight = 0.65197081734568874D;
            // 
            // totalWithVat_lbl
            // 
            this.totalWithVat_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalWithVat_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.totalWithVat_lbl.BorderWidth = 1F;
            this.totalWithVat_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.totalWithVat_lbl.Multiline = true;
            this.totalWithVat_lbl.Name = "totalWithVat_lbl";
            this.totalWithVat_lbl.StylePriority.UseBackColor = false;
            this.totalWithVat_lbl.StylePriority.UseBorders = false;
            this.totalWithVat_lbl.StylePriority.UseBorderWidth = false;
            this.totalWithVat_lbl.StylePriority.UseFont = false;
            this.totalWithVat_lbl.Text = "Total With Vat";
            this.totalWithVat_lbl.Weight = 0.65197080188421119D;
            // 
            // totalCost_lbl
            // 
            this.totalCost_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalCost_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.totalCost_lbl.BorderWidth = 1F;
            this.totalCost_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.totalCost_lbl.Multiline = true;
            this.totalCost_lbl.Name = "totalCost_lbl";
            this.totalCost_lbl.StylePriority.UseBackColor = false;
            this.totalCost_lbl.StylePriority.UseBorders = false;
            this.totalCost_lbl.StylePriority.UseBorderWidth = false;
            this.totalCost_lbl.StylePriority.UseFont = false;
            this.totalCost_lbl.Text = "Total Cost";
            this.totalCost_lbl.Weight = 0.65197080611895175D;
            // 
            // grossProfit_lbl
            // 
            this.grossProfit_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grossProfit_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.grossProfit_lbl.BorderWidth = 1F;
            this.grossProfit_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.grossProfit_lbl.Multiline = true;
            this.grossProfit_lbl.Name = "grossProfit_lbl";
            this.grossProfit_lbl.StylePriority.UseBackColor = false;
            this.grossProfit_lbl.StylePriority.UseBorders = false;
            this.grossProfit_lbl.StylePriority.UseBorderWidth = false;
            this.grossProfit_lbl.StylePriority.UseFont = false;
            this.grossProfit_lbl.Text = "Gross Profit";
            this.grossProfit_lbl.Weight = 0.65197085887348116D;
            // 
            // SummarySubReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 827;
            this.PageWidth = 1299;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Plus;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow18;
        private DevExpress.XtraReports.UI.XRTableCell G18_lbl;
        private DevExpress.XtraReports.UI.XRTableCell G21_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell laborPrice_lbl;
        private DevExpress.XtraReports.UI.XRTableCell netSalesAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell totalWithVat_lbl;
        private DevExpress.XtraReports.UI.XRTableCell totalCost_lbl;
        private DevExpress.XtraReports.UI.XRTableCell grossProfit_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_data;
        private DevExpress.XtraReports.UI.XRTableCell amount_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    }
}
