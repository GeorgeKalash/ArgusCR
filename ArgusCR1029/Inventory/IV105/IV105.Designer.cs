
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory.IV105
{
    partial class IV105
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
            this.InvoiceItemSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.InvoiceReceiptSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.dtName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.fromSiteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.toSiteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.fromSiteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.toSiteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.transferSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // InvoiceItemSubBand
            // 
            this.InvoiceItemSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.InvoiceItemSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.transferSubReports});
            this.InvoiceItemSubBand.HeightF = 23F;
            this.InvoiceItemSubBand.KeepTogether = true;
            this.InvoiceItemSubBand.Name = "InvoiceItemSubBand";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.InvoiceItemSubBand,
            this.InvoiceReceiptSubBand});
            // 
            // InvoiceReceiptSubBand
            // 
            this.InvoiceReceiptSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.MetalSubReports});
            this.InvoiceReceiptSubBand.HeightF = 35.5F;
            this.InvoiceReceiptSubBand.KeepTogether = true;
            this.InvoiceReceiptSubBand.Name = "InvoiceReceiptSubBand";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 30F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.ReportFooter.HeightF = 37.5F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(89.02905F, 12.5F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable6.SizeF = new System.Drawing.SizeF(730.9709F, 25F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_data,
            this.xrTableCell3});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.StylePriority.UseBorders = false;
            this.xrTableRow14.Weight = 1D;
            // 
            // description_data
            // 
            this.description_data.BackColor = System.Drawing.Color.White;
            this.description_data.BorderColor = System.Drawing.Color.Black;
            this.description_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.description_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.description_data.Multiline = true;
            this.description_data.Name = "description_data";
            this.description_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.description_data.StylePriority.UseBackColor = false;
            this.description_data.StylePriority.UseBorderColor = false;
            this.description_data.StylePriority.UseBorders = false;
            this.description_data.StylePriority.UseFont = false;
            this.description_data.StylePriority.UsePadding = false;
            this.description_data.StylePriority.UseTextAlignment = false;
            this.description_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.description_data.TextFormatString = "{0:n2}";
            this.description_data.Weight = 12.425857737832743D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.title_lbl,
            this.xrTable1,
            this.xrTable3,
            this.logo_data});
            this.ReportHeader.HeightF = 285.5892F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // title_lbl
            // 
            this.title_lbl.BackColor = System.Drawing.Color.Black;
            this.title_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.title_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 134.375F);
            this.title_lbl.Multiline = true;
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 7, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(810F, 37.5F);
            this.title_lbl.StylePriority.UseBackColor = false;
            this.title_lbl.StylePriority.UseBorders = false;
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UseForeColor = false;
            this.title_lbl.StylePriority.UsePadding = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "درافت تحويل بالسريال";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 171.875F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4});
            this.xrTable1.SizeF = new System.Drawing.SizeF(391.4286F, 88.5417F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.dtName_data,
            this.xrTableCell5});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // dtName_data
            // 
            this.dtName_data.BackColor = System.Drawing.Color.White;
            this.dtName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_data.Multiline = true;
            this.dtName_data.Name = "dtName_data";
            this.dtName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.dtName_data.StylePriority.UseBackColor = false;
            this.dtName_data.StylePriority.UseBorders = false;
            this.dtName_data.StylePriority.UsePadding = false;
            this.dtName_data.StylePriority.UseTextAlignment = false;
            this.dtName_data.Text = "dtName_data";
            this.dtName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.dtName_data.Weight = 1.2810955096964567D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_data,
            this.xrTableCell6});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reference_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.StylePriority.UseTextAlignment = false;
            this.reference_data.Text = "reference_data";
            this.reference_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.reference_data.Weight = 1.2810955128018384D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_data,
            this.xrTableCell7});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.date_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.StylePriority.UseTextAlignment = false;
            this.date_data.Text = "date_data";
            this.date_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.date_data.Weight = 1.2810955128018384D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(401.4286F, 171.875F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable3.SizeF = new System.Drawing.SizeF(418.5714F, 59.0278F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.fromSiteName_data,
            this.fromSiteRef_data,
            this.xrTableCell1});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // fromSiteName_data
            // 
            this.fromSiteName_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fromSiteName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.fromSiteName_data.Multiline = true;
            this.fromSiteName_data.Name = "fromSiteName_data";
            this.fromSiteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.fromSiteName_data.StylePriority.UseBackColor = false;
            this.fromSiteName_data.StylePriority.UseBorders = false;
            this.fromSiteName_data.StylePriority.UsePadding = false;
            this.fromSiteName_data.StylePriority.UseTextAlignment = false;
            this.fromSiteName_data.Text = "fromSiteName_data";
            this.fromSiteName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.fromSiteName_data.Weight = 0.83477157737903707D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.toSiteName_data,
            this.toSiteRef_data,
            this.xrTableCell2});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // toSiteName_data
            // 
            this.toSiteName_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toSiteName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.toSiteName_data.Multiline = true;
            this.toSiteName_data.Name = "toSiteName_data";
            this.toSiteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.toSiteName_data.StylePriority.UseBackColor = false;
            this.toSiteName_data.StylePriority.UseBorders = false;
            this.toSiteName_data.StylePriority.UsePadding = false;
            this.toSiteName_data.StylePriority.UseTextAlignment = false;
            this.toSiteName_data.Text = "toSiteName_data";
            this.toSiteName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.toSiteName_data.Weight = 0.83477155350492616D;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(297.7083F, 123.9583F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pagesNumber_lbl,
            this.printSignature_lbl});
            this.PageFooter.HeightF = 32.99997F;
            this.PageFooter.Name = "PageFooter";
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.White;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(712.3101F, 9.999974F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(107.6899F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 9.999974F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(625.9621F, 23F);
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature_lbl";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "من الموقع";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.Weight = 0.55431473739722248D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "إلى الموقع";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 0.55431438925878262D;
            // 
            // fromSiteRef_data
            // 
            this.fromSiteRef_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fromSiteRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.fromSiteRef_data.Multiline = true;
            this.fromSiteRef_data.Name = "fromSiteRef_data";
            this.fromSiteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.fromSiteRef_data.StylePriority.UseBackColor = false;
            this.fromSiteRef_data.StylePriority.UseBorders = false;
            this.fromSiteRef_data.StylePriority.UsePadding = false;
            this.fromSiteRef_data.StylePriority.UseTextAlignment = false;
            this.fromSiteRef_data.Text = "fromSiteRef_data";
            this.fromSiteRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.fromSiteRef_data.Weight = 0.54441620999879758D;
            // 
            // toSiteRef_data
            // 
            this.toSiteRef_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toSiteRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.toSiteRef_data.Multiline = true;
            this.toSiteRef_data.Name = "toSiteRef_data";
            this.toSiteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.toSiteRef_data.StylePriority.UseBackColor = false;
            this.toSiteRef_data.StylePriority.UseBorders = false;
            this.toSiteRef_data.StylePriority.UsePadding = false;
            this.toSiteRef_data.StylePriority.UseTextAlignment = false;
            this.toSiteRef_data.Text = "toSiteRef_data";
            this.toSiteRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.toSiteRef_data.Weight = 0.5444165267140012D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "نوع الوثيقة";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.Weight = 0.61886631845437645D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "مرجع الوثيقة";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.Weight = 0.61886631534899461D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "تاريخ النشر";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.61886631534899461D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.White;
            this.xrTableCell3.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "الوصف";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 2.4405463716618576D;
            // 
            // transferSubReports
            // 
            this.transferSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.transferSubReports.Name = "transferSubReports";
            this.transferSubReports.ReportSource = new ArgusCR1029.Inventory.IV105.transferSubReports();
            this.transferSubReports.SizeF = new System.Drawing.SizeF(810F, 23F);
            // 
            // MetalSubReports
            // 
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 12.5F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1029.Inventory.IV105.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(810F, 23F);
            // 
            // IV105
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.ReportHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 30, 10);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRSubreport transferSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand InvoiceItemSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell dtName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell fromSiteName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell toSiteName_data;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.XRTableCell fromSiteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell toSiteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    }
}
