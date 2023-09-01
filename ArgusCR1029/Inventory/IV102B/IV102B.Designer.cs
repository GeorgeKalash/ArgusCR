
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Inventory.IV102B
{
    partial class IV102B
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
            this.TransferSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.TransferSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.InvoiceReceiptSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.companyName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.taxNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.tamdeedVatNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.fromSiteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.fromSiteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.toSiteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.toSiteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TransferSubBand
            // 
            this.TransferSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.TransferSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TransferSubReports});
            this.TransferSubBand.HeightF = 23F;
            this.TransferSubBand.Name = "TransferSubBand";
            // 
            // TransferSubReports
            // 
            this.TransferSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0F);
            this.TransferSubReports.Name = "TransferSubReports";
            this.TransferSubReports.ReportSource = new ArgusCR1029.Inventory.IV102B.TransferSubReports();
            this.TransferSubReports.SizeF = new System.Drawing.SizeF(777.0995F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.TransferSubBand,
            this.InvoiceReceiptSubBand});
            // 
            // InvoiceReceiptSubBand
            // 
            this.InvoiceReceiptSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.MetalSubReports});
            this.InvoiceReceiptSubBand.HeightF = 35.5F;
            this.InvoiceReceiptSubBand.Name = "InvoiceReceiptSubBand";
            // 
            // MetalSubReports
            // 
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25F, 12.5F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1029.Inventory.IV102B.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(777.0994F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35.91666F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 108.2986F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15,
            this.xrTable3,
            this.xrTable1,
            this.xrPageInfo1,
            this.logo_data});
            this.ReportHeader.HeightF = 187.7361F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable15
            // 
            this.xrTable15.BackColor = System.Drawing.Color.White;
            this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(478F, 0F);
            this.xrTable15.Name = "xrTable15";
            this.xrTable15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow29,
            this.xrTableRow30});
            this.xrTable15.SizeF = new System.Drawing.SizeF(324.0995F, 69.16666F);
            this.xrTable15.StylePriority.UseBackColor = false;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.companyName_data});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 1D;
            // 
            // companyName_data
            // 
            this.companyName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.companyName_data.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.companyName_data.Multiline = true;
            this.companyName_data.Name = "companyName_data";
            this.companyName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 9, 0, 100F);
            this.companyName_data.StylePriority.UseBorders = false;
            this.companyName_data.StylePriority.UseFont = false;
            this.companyName_data.StylePriority.UsePadding = false;
            this.companyName_data.StylePriority.UseTextAlignment = false;
            this.companyName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.companyName_data.Weight = 2D;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.taxNo_data,
            this.tamdeedVatNo_lbl});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 1D;
            // 
            // taxNo_data
            // 
            this.taxNo_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.taxNo_data.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.taxNo_data.Multiline = true;
            this.taxNo_data.Name = "taxNo_data";
            this.taxNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.taxNo_data.StylePriority.UseBorders = false;
            this.taxNo_data.StylePriority.UseFont = false;
            this.taxNo_data.StylePriority.UsePadding = false;
            this.taxNo_data.StylePriority.UseTextAlignment = false;
            this.taxNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.taxNo_data.Weight = 1.1838466440293447D;
            // 
            // tamdeedVatNo_lbl
            // 
            this.tamdeedVatNo_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tamdeedVatNo_lbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tamdeedVatNo_lbl.Multiline = true;
            this.tamdeedVatNo_lbl.Name = "tamdeedVatNo_lbl";
            this.tamdeedVatNo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.tamdeedVatNo_lbl.StylePriority.UseBorders = false;
            this.tamdeedVatNo_lbl.StylePriority.UseFont = false;
            this.tamdeedVatNo_lbl.StylePriority.UsePadding = false;
            this.tamdeedVatNo_lbl.StylePriority.UseTextAlignment = false;
            this.tamdeedVatNo_lbl.Text = "رقم الضریبي";
            this.tamdeedVatNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tamdeedVatNo_lbl.Weight = 0.81615335597065541D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(474.9999F, 112.5F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow1});
            this.xrTable3.SizeF = new System.Drawing.SizeF(327.0995F, 59.0278F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.fromSiteName_data,
            this.fromSiteRef_data,
            this.xrTableCell8});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // fromSiteName_data
            // 
            this.fromSiteName_data.BackColor = System.Drawing.Color.White;
            this.fromSiteName_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.fromSiteName_data.Multiline = true;
            this.fromSiteName_data.Name = "fromSiteName_data";
            this.fromSiteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.fromSiteName_data.StylePriority.UseBackColor = false;
            this.fromSiteName_data.StylePriority.UseBorders = false;
            this.fromSiteName_data.StylePriority.UsePadding = false;
            this.fromSiteName_data.StylePriority.UseTextAlignment = false;
            this.fromSiteName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.fromSiteName_data.Weight = 1.2221806923197629D;
            // 
            // fromSiteRef_data
            // 
            this.fromSiteRef_data.BackColor = System.Drawing.Color.White;
            this.fromSiteRef_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.fromSiteRef_data.Multiline = true;
            this.fromSiteRef_data.Name = "fromSiteRef_data";
            this.fromSiteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.fromSiteRef_data.StylePriority.UseBackColor = false;
            this.fromSiteRef_data.StylePriority.UseBorders = false;
            this.fromSiteRef_data.StylePriority.UsePadding = false;
            this.fromSiteRef_data.StylePriority.UseTextAlignment = false;
            this.fromSiteRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.fromSiteRef_data.Weight = 0.46396297825263788D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.White;
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 5, 4, 0, 100F);
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "من ";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell8.Weight = 0.21262728791514302D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.toSiteName_data,
            this.toSiteRef_data,
            this.xrTableCell9});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // toSiteName_data
            // 
            this.toSiteName_data.BackColor = System.Drawing.Color.White;
            this.toSiteName_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.toSiteName_data.Multiline = true;
            this.toSiteName_data.Name = "toSiteName_data";
            this.toSiteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.toSiteName_data.StylePriority.UseBackColor = false;
            this.toSiteName_data.StylePriority.UseBorders = false;
            this.toSiteName_data.StylePriority.UsePadding = false;
            this.toSiteName_data.StylePriority.UseTextAlignment = false;
            this.toSiteName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.toSiteName_data.Weight = 1.2221804623150867D;
            // 
            // toSiteRef_data
            // 
            this.toSiteRef_data.BackColor = System.Drawing.Color.White;
            this.toSiteRef_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.toSiteRef_data.Multiline = true;
            this.toSiteRef_data.Name = "toSiteRef_data";
            this.toSiteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.toSiteRef_data.StylePriority.UseBackColor = false;
            this.toSiteRef_data.StylePriority.UseBorders = false;
            this.toSiteRef_data.StylePriority.UsePadding = false;
            this.toSiteRef_data.StylePriority.UseTextAlignment = false;
            this.toSiteRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.toSiteRef_data.Weight = 0.46396314274226313D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.White;
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 5, 4, 0, 100F);
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "الى";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell9.Weight = 0.21262729912615516D;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 112.5F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow8});
            this.xrTable1.SizeF = new System.Drawing.SizeF(331.5197F, 59.02778F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_data,
            this.xrTableCell2});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reference_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.StylePriority.UseTextAlignment = false;
            this.reference_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.reference_data.Weight = 1.5861646468351411D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.White;
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 5, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "رقم ";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 0.35322919795337809D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_data,
            this.xrTableCell7});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.date_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.StylePriority.UseTextAlignment = false;
            this.date_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.date_data.Weight = 1.5861644683069855D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.White;
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 5, 4, 0, 100F);
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "التاريخ";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.35322937648153374D;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(370.0011F, 148.7707F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(89.06491F, 22.75706F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0.9652774F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(103.4999F, 100.5F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // IV102B
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 36, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRSubreport TransferSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand TransferSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell fromSiteName_data;
        private DevExpress.XtraReports.UI.XRTableCell fromSiteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell toSiteName_data;
        private DevExpress.XtraReports.UI.XRTableCell toSiteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTable xrTable15;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow29;
        private DevExpress.XtraReports.UI.XRTableCell companyName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow30;
        private DevExpress.XtraReports.UI.XRTableCell taxNo_data;
        private DevExpress.XtraReports.UI.XRTableCell tamdeedVatNo_lbl;
    }
}
