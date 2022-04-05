
namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    partial class MF105
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.IssueOfMaterialsSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.IssueOfMaterialsSubReport = new DevExpress.XtraReports.UI.XRSubreport();
            this.OverheadsSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.CategorySubReport = new DevExpress.XtraReports.UI.XRSubreport();
            this.workSheet_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.remarks_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.weightBefore_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.weightAfter_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.orderNum_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.orderTo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.labor_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 38F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 24.79167F;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.IssueOfMaterialsSubBand,
            this.OverheadsSubBand});
            // 
            // IssueOfMaterialsSubBand
            // 
            this.IssueOfMaterialsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.IssueOfMaterialsSubReport});
            this.IssueOfMaterialsSubBand.HeightF = 23F;
            this.IssueOfMaterialsSubBand.KeepTogether = true;
            this.IssueOfMaterialsSubBand.Name = "IssueOfMaterialsSubBand";
            // 
            // IssueOfMaterialsSubReport
            // 
            this.IssueOfMaterialsSubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.IssueOfMaterialsSubReport.Name = "IssueOfMaterialsSubReport";
            this.IssueOfMaterialsSubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF105.IssueOfMaterialsSubReport();
            this.IssueOfMaterialsSubReport.SizeF = new System.Drawing.SizeF(1138.083F, 23F);
            // 
            // OverheadsSubBand
            // 
            this.OverheadsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CategorySubReport});
            this.OverheadsSubBand.HeightF = 23F;
            this.OverheadsSubBand.KeepTogether = true;
            this.OverheadsSubBand.Name = "OverheadsSubBand";
            // 
            // CategorySubReport
            // 
            this.CategorySubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.CategorySubReport.Name = "CategorySubReport";
            this.CategorySubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF105.CategorySubReport();
            this.CategorySubReport.SizeF = new System.Drawing.SizeF(1138.083F, 23F);
            // 
            // workSheet_lbl
            // 
            this.workSheet_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.workSheet_lbl.LocationFloat = new DevExpress.Utils.PointFloat(437.5001F, 0F);
            this.workSheet_lbl.Multiline = true;
            this.workSheet_lbl.Name = "workSheet_lbl";
            this.workSheet_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.workSheet_lbl.SizeF = new System.Drawing.SizeF(298.9583F, 29.16667F);
            this.workSheet_lbl.StylePriority.UseFont = false;
            this.workSheet_lbl.StylePriority.UseTextAlignment = false;
            this.workSheet_lbl.Text = "MZR - WorkSheet";
            this.workSheet_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.printSignature_lbl,
            this.pagesNumber_lbl});
            this.PageFooter.HeightF = 39.16677F;
            this.PageFooter.Name = "PageFooter";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 12.5F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(676.2528F, 23.00002F);
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(1037.5F, 12.5F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(110.5834F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.workSheet_lbl});
            this.ReportHeader.HeightF = 236F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrTable4,
            this.xrTable3,
            this.xrTable2,
            this.xrTable1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 47.41667F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(1138.083F, 165.625F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(26.45833F, 90.625F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(200F, 65F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(794.7496F, 10.00001F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable4.SizeF = new System.Drawing.SizeF(333.3334F, 63.54166F);
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.remarks_lbl,
            this.xrTableCell14});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 2.5416664473215906D;
            // 
            // remarks_lbl
            // 
            this.remarks_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.remarks_lbl.BorderWidth = 2F;
            this.remarks_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks_lbl.Multiline = true;
            this.remarks_lbl.Name = "remarks_lbl";
            this.remarks_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.remarks_lbl.StylePriority.UseBorders = false;
            this.remarks_lbl.StylePriority.UseBorderWidth = false;
            this.remarks_lbl.StylePriority.UseFont = false;
            this.remarks_lbl.StylePriority.UsePadding = false;
            this.remarks_lbl.Text = "Remarks:";
            this.remarks_lbl.Weight = 0.327666266070646D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.BorderWidth = 2F;
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseBorderWidth = false;
            this.xrTableCell14.Weight = 1.1777101042670557D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(593.1251F, 10.00001F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable3.SizeF = new System.Drawing.SizeF(149.7944F, 25F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_lbl,
            this.xrTableCell12});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // date_lbl
            // 
            this.date_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.date_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.date_lbl.StylePriority.UseBorders = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.Text = "Date:";
            this.date_lbl.Weight = 0.51075266192036284D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.Weight = 0.99462370841733883D;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(474.3749F, 49.58334F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTable2.SizeF = new System.Drawing.SizeF(239.5834F, 50.00001F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.weightBefore_lbl,
            this.xrTableCell8});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // weightBefore_lbl
            // 
            this.weightBefore_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.weightBefore_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBefore_lbl.Multiline = true;
            this.weightBefore_lbl.Name = "weightBefore_lbl";
            this.weightBefore_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.weightBefore_lbl.StylePriority.UseBorders = false;
            this.weightBefore_lbl.StylePriority.UseFont = false;
            this.weightBefore_lbl.StylePriority.UsePadding = false;
            this.weightBefore_lbl.Text = "Weight Before:";
            this.weightBefore_lbl.Weight = 0.63356417113170937D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.Weight = 0.87181219920599229D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.weightAfter_lbl,
            this.xrTableCell10});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // weightAfter_lbl
            // 
            this.weightAfter_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.weightAfter_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.weightAfter_lbl.Multiline = true;
            this.weightAfter_lbl.Name = "weightAfter_lbl";
            this.weightAfter_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.weightAfter_lbl.StylePriority.UseBorders = false;
            this.weightAfter_lbl.StylePriority.UseFont = false;
            this.weightAfter_lbl.StylePriority.UsePadding = false;
            this.weightAfter_lbl.Text = "Weight After:";
            this.weightAfter_lbl.Weight = 0.63356419572006406D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.Weight = 0.8718121746176376D;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 10.00001F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(291.6667F, 75.00001F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.orderNum_lbl,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // orderNum_lbl
            // 
            this.orderNum_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.orderNum_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNum_lbl.Multiline = true;
            this.orderNum_lbl.Name = "orderNum_lbl";
            this.orderNum_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.orderNum_lbl.StylePriority.UseBorders = false;
            this.orderNum_lbl.StylePriority.UseFont = false;
            this.orderNum_lbl.StylePriority.UsePadding = false;
            this.orderNum_lbl.Text = "Order Num:";
            this.orderNum_lbl.Weight = 0.51075266192036284D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.Weight = 0.99462370841733883D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.orderTo_lbl,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // orderTo_lbl
            // 
            this.orderTo_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.orderTo_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.orderTo_lbl.Multiline = true;
            this.orderTo_lbl.Name = "orderTo_lbl";
            this.orderTo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.orderTo_lbl.StylePriority.UseBorders = false;
            this.orderTo_lbl.StylePriority.UseFont = false;
            this.orderTo_lbl.StylePriority.UsePadding = false;
            this.orderTo_lbl.Text = "Order To:";
            this.orderTo_lbl.Weight = 0.51075258316532257D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.Weight = 0.99462378717237909D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.labor_lbl,
            this.xrTableCell6});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // labor_lbl
            // 
            this.labor_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.labor_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.labor_lbl.Multiline = true;
            this.labor_lbl.Name = "labor_lbl";
            this.labor_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.labor_lbl.StylePriority.UseBorders = false;
            this.labor_lbl.StylePriority.UseFont = false;
            this.labor_lbl.StylePriority.UsePadding = false;
            this.labor_lbl.Text = "Labor:";
            this.labor_lbl.Weight = 0.51075266192036284D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.Weight = 0.99462370841733883D;
            // 
            // MF105
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 38, 10);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel workSheet_lbl;
        private DevExpress.XtraReports.UI.SubBand IssueOfMaterialsSubBand;
        private DevExpress.XtraReports.UI.SubBand OverheadsSubBand;
        private DevExpress.XtraReports.UI.XRSubreport CategorySubReport;
        private DevExpress.XtraReports.UI.XRSubreport IssueOfMaterialsSubReport;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell orderNum_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell orderTo_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell labor_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell remarks_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell weightBefore_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell weightAfter_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
    }
}
