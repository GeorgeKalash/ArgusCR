
namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    partial class OverheadsSubReport
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
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.cost_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.extendedCost_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.overheads_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.qty_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.cost_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.extendedCost_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
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
            this.Detail.HeightF = 22.91667F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(27.08333F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(773.25F, 22.91667F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemRef_data,
            this.itemName_data,
            this.qty_data,
            this.cost_data,
            this.extendedCost_data});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // itemRef_data
            // 
            this.itemRef_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.itemRef_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[overheadRef]")});
            this.itemRef_data.Font = new System.Drawing.Font("Arial", 9.75F);
            this.itemRef_data.Multiline = true;
            this.itemRef_data.Name = "itemRef_data";
            this.itemRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 3, 0, 100F);
            this.itemRef_data.StylePriority.UseBorders = false;
            this.itemRef_data.StylePriority.UseFont = false;
            this.itemRef_data.StylePriority.UsePadding = false;
            this.itemRef_data.StylePriority.UseTextAlignment = false;
            this.itemRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.itemRef_data.Weight = 0.95113318290373539D;
            // 
            // itemName_data
            // 
            this.itemName_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.itemName_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[overheadName]")});
            this.itemName_data.Font = new System.Drawing.Font("Arial", 9.75F);
            this.itemName_data.Multiline = true;
            this.itemName_data.Name = "itemName_data";
            this.itemName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 3, 0, 100F);
            this.itemName_data.StylePriority.UseBorders = false;
            this.itemName_data.StylePriority.UseFont = false;
            this.itemName_data.StylePriority.UsePadding = false;
            this.itemName_data.StylePriority.UseTextAlignment = false;
            this.itemName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.itemName_data.Weight = 2.1949227795863351D;
            // 
            // qty_data
            // 
            this.qty_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.qty_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[units]")});
            this.qty_data.Font = new System.Drawing.Font("Arial", 9.75F);
            this.qty_data.Multiline = true;
            this.qty_data.Name = "qty_data";
            this.qty_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.qty_data.StylePriority.UseBorders = false;
            this.qty_data.StylePriority.UseFont = false;
            this.qty_data.StylePriority.UsePadding = false;
            this.qty_data.StylePriority.UseTextAlignment = false;
            this.qty_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.qty_data.TextFormatString = "{0:n2}";
            this.qty_data.Weight = 0.73164067727150128D;
            // 
            // cost_data
            // 
            this.cost_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cost_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[unitCost]")});
            this.cost_data.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cost_data.Multiline = true;
            this.cost_data.Name = "cost_data";
            this.cost_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.cost_data.StylePriority.UseBorders = false;
            this.cost_data.StylePriority.UseFont = false;
            this.cost_data.StylePriority.UsePadding = false;
            this.cost_data.StylePriority.UseTextAlignment = false;
            this.cost_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.cost_data.TextFormatString = "{0:n2}";
            this.cost_data.Weight = 0.73164151469489291D;
            // 
            // extendedCost_data
            // 
            this.extendedCost_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.extendedCost_data.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")});
            this.extendedCost_data.Font = new System.Drawing.Font("Arial", 9.75F);
            this.extendedCost_data.Multiline = true;
            this.extendedCost_data.Name = "extendedCost_data";
            this.extendedCost_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.extendedCost_data.StylePriority.UseBorders = false;
            this.extendedCost_data.StylePriority.UseFont = false;
            this.extendedCost_data.StylePriority.UsePadding = false;
            this.extendedCost_data.StylePriority.UseTextAlignment = false;
            this.extendedCost_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.extendedCost_data.TextFormatString = "{0:n2}";
            this.extendedCost_data.Weight = 0.7316404886216934D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.overheads_lbl});
            this.ReportHeader.HeightF = 63.54167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // overheads_lbl
            // 
            this.overheads_lbl.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.overheads_lbl.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            this.overheads_lbl.Multiline = true;
            this.overheads_lbl.Name = "overheads_lbl";
            this.overheads_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.overheads_lbl.SizeF = new System.Drawing.SizeF(216.6667F, 23F);
            this.overheads_lbl.StylePriority.UseFont = false;
            this.overheads_lbl.StylePriority.UseTextAlignment = false;
            this.overheads_lbl.Text = "overheads_lbl";
            this.overheads_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 22.91667F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(27.08333F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(773.25F, 22.91667F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemRef_lbl,
            this.itemName_lbl,
            this.qty_lbl,
            this.cost_lbl,
            this.extendedCost_lbl});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // itemRef_lbl
            // 
            this.itemRef_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemRef_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.itemRef_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.itemRef_lbl.Multiline = true;
            this.itemRef_lbl.Name = "itemRef_lbl";
            this.itemRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F);
            this.itemRef_lbl.StylePriority.UseBackColor = false;
            this.itemRef_lbl.StylePriority.UseBorders = false;
            this.itemRef_lbl.StylePriority.UseFont = false;
            this.itemRef_lbl.StylePriority.UsePadding = false;
            this.itemRef_lbl.StylePriority.UseTextAlignment = false;
            this.itemRef_lbl.Text = "Overhead Ref";
            this.itemRef_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemRef_lbl.Weight = 0.89793373972145907D;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemName_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.itemName_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.itemName_lbl.Multiline = true;
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F);
            this.itemName_lbl.StylePriority.UseBackColor = false;
            this.itemName_lbl.StylePriority.UseBorders = false;
            this.itemName_lbl.StylePriority.UseFont = false;
            this.itemName_lbl.StylePriority.UsePadding = false;
            this.itemName_lbl.StylePriority.UseTextAlignment = false;
            this.itemName_lbl.Text = "Overhead Name";
            this.itemName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemName_lbl.Weight = 2.0721547817870456D;
            // 
            // qty_lbl
            // 
            this.qty_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qty_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.qty_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.qty_lbl.Multiline = true;
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F);
            this.qty_lbl.StylePriority.UseBackColor = false;
            this.qty_lbl.StylePriority.UseBorders = false;
            this.qty_lbl.StylePriority.UseFont = false;
            this.qty_lbl.StylePriority.UsePadding = false;
            this.qty_lbl.StylePriority.UseTextAlignment = false;
            this.qty_lbl.Text = "Units";
            this.qty_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.qty_lbl.Weight = 0.69071821817484025D;
            // 
            // cost_lbl
            // 
            this.cost_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cost_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cost_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cost_lbl.Multiline = true;
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F);
            this.cost_lbl.StylePriority.UseBackColor = false;
            this.cost_lbl.StylePriority.UseBorders = false;
            this.cost_lbl.StylePriority.UseFont = false;
            this.cost_lbl.StylePriority.UsePadding = false;
            this.cost_lbl.StylePriority.UseTextAlignment = false;
            this.cost_lbl.Text = "Unit Cost";
            this.cost_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.cost_lbl.Weight = 0.69071821817484025D;
            // 
            // extendedCost_lbl
            // 
            this.extendedCost_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.extendedCost_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.extendedCost_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.extendedCost_lbl.Multiline = true;
            this.extendedCost_lbl.Name = "extendedCost_lbl";
            this.extendedCost_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 3, 0, 100F);
            this.extendedCost_lbl.StylePriority.UseBackColor = false;
            this.extendedCost_lbl.StylePriority.UseBorders = false;
            this.extendedCost_lbl.StylePriority.UseFont = false;
            this.extendedCost_lbl.StylePriority.UsePadding = false;
            this.extendedCost_lbl.StylePriority.UseTextAlignment = false;
            this.extendedCost_lbl.Text = "Amount";
            this.extendedCost_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.extendedCost_lbl.Weight = 0.69071822221327328D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.ReportFooter.HeightF = 22.91667F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(482.5594F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(317.774F, 22.91667F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([units])")});
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell3.Summary = xrSummary1;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell3.TextFormatString = "{0:n2}";
            this.xrTableCell3.Weight = 0.73164067727150128D;
            this.xrTableCell3.WordWrap = false;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([unitCost])")});
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell4.Summary = xrSummary2;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell4.TextFormatString = "{0:n2}";
            this.xrTableCell4.Weight = 0.73164151469489291D;
            this.xrTableCell4.WordWrap = false;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount])")});
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 3, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell5.Summary = xrSummary3;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell5.TextFormatString = "{0:n2}";
            this.xrTableCell5.Weight = 0.7316404886216934D;
            this.xrTableCell5.WordWrap = false;
            // 
            // OverheadsSubReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel overheads_lbl;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell itemRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell qty_lbl;
        private DevExpress.XtraReports.UI.XRTableCell cost_lbl;
        private DevExpress.XtraReports.UI.XRTableCell extendedCost_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell itemRef_data;
        private DevExpress.XtraReports.UI.XRTableCell itemName_data;
        private DevExpress.XtraReports.UI.XRTableCell qty_data;
        private DevExpress.XtraReports.UI.XRTableCell cost_data;
        private DevExpress.XtraReports.UI.XRTableCell extendedCost_data;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
    }
}
