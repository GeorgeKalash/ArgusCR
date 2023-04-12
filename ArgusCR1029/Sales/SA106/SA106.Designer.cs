
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales.SA106
{
    partial class SA106
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
            this.InvoiceItemsSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.InvoiceReceiptSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotal_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vat_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.total_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.description_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.site_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.siteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.siteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.currency_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.currency_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.salesPerson_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.salesPerson_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.dtName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.taxInvoice_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.client_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // InvoiceItemSubBand
            // 
            this.InvoiceItemSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.InvoiceItemSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.InvoiceItemsSubReports});
            this.InvoiceItemSubBand.HeightF = 23F;
            this.InvoiceItemSubBand.KeepTogether = true;
            this.InvoiceItemSubBand.Name = "InvoiceItemSubBand";
            // 
            // InvoiceItemsSubReports
            // 
            this.InvoiceItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.InvoiceItemsSubReports.Name = "InvoiceItemsSubReports";
            this.InvoiceItemsSubReports.ReportSource = new ArgusCR1029.Sales.SA106.InvoiceItemsSubReports();
            this.InvoiceItemsSubReports.SizeF = new System.Drawing.SizeF(810F, 23F);
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
            // MetalSubReports
            // 
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 12.5F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1029.Sales.SA106.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(809.9999F, 23F);
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
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrTable6});
            this.ReportFooter.HeightF = 77.49996F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(500.2599F, 12.5F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8,
            this.xrTableRow12,
            this.xrTableRow13});
            this.xrTable5.SizeF = new System.Drawing.SizeF(319.74F, 64.99996F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseFont = false;
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotal_data,
            this.xrTableCell1});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.StylePriority.UseBorders = false;
            this.xrTableRow8.Weight = 1D;
            // 
            // subtotal_data
            // 
            this.subtotal_data.BackColor = System.Drawing.Color.White;
            this.subtotal_data.BorderColor = System.Drawing.Color.Black;
            this.subtotal_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.subtotal_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.subtotal_data.Multiline = true;
            this.subtotal_data.Name = "subtotal_data";
            this.subtotal_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.subtotal_data.StylePriority.UseBackColor = false;
            this.subtotal_data.StylePriority.UseBorderColor = false;
            this.subtotal_data.StylePriority.UseBorders = false;
            this.subtotal_data.StylePriority.UseFont = false;
            this.subtotal_data.StylePriority.UsePadding = false;
            this.subtotal_data.StylePriority.UseTextAlignment = false;
            this.subtotal_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.subtotal_data.TextFormatString = "{0:n2}";
            this.subtotal_data.Weight = 5.7755913129841616D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "اجمالى اجور بدون الضريبة";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 3.6458029473128186D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vat_data,
            this.xrTableCell2});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.StylePriority.UseBorders = false;
            this.xrTableRow12.Weight = 1D;
            // 
            // vat_data
            // 
            this.vat_data.BackColor = System.Drawing.Color.White;
            this.vat_data.BorderColor = System.Drawing.Color.Black;
            this.vat_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.vat_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.vat_data.Multiline = true;
            this.vat_data.Name = "vat_data";
            this.vat_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.vat_data.StylePriority.UseBackColor = false;
            this.vat_data.StylePriority.UseBorderColor = false;
            this.vat_data.StylePriority.UseBorders = false;
            this.vat_data.StylePriority.UseFont = false;
            this.vat_data.StylePriority.UsePadding = false;
            this.vat_data.StylePriority.UseTextAlignment = false;
            this.vat_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vat_data.TextFormatString = "{0:n2}";
            this.vat_data.Weight = 5.7755895145343485D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell2.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "مبلغ الضريبه";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 3.6458047457626312D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.total_data,
            this.xrTableCell3});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.StylePriority.UseBorders = false;
            this.xrTableRow13.Weight = 1D;
            // 
            // total_data
            // 
            this.total_data.BackColor = System.Drawing.Color.White;
            this.total_data.BorderColor = System.Drawing.Color.Black;
            this.total_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.total_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.total_data.Multiline = true;
            this.total_data.Name = "total_data";
            this.total_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.total_data.StylePriority.UseBackColor = false;
            this.total_data.StylePriority.UseBorderColor = false;
            this.total_data.StylePriority.UseBorders = false;
            this.total_data.StylePriority.UseFont = false;
            this.total_data.StylePriority.UsePadding = false;
            this.total_data.StylePriority.UseTextAlignment = false;
            this.total_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.total_data.TextFormatString = "{0:n2}";
            this.total_data.Weight = 5.7755877160845355D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell3.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
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
            this.xrTableCell3.Text = "اجمالى الاجور مع الضريبه";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 3.6458065442124443D;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 12.5F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable6.SizeF = new System.Drawing.SizeF(433.5859F, 25F);
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
            this.description_lbl});
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
            this.description_data.Weight = 5.3660663565573445D;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.White;
            this.description_lbl.BorderColor = System.Drawing.Color.Black;
            this.description_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.description_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.description_lbl.StylePriority.UseBackColor = false;
            this.description_lbl.StylePriority.UseBorderColor = false;
            this.description_lbl.StylePriority.UseBorders = false;
            this.description_lbl.StylePriority.UseFont = false;
            this.description_lbl.StylePriority.UsePadding = false;
            this.description_lbl.StylePriority.UseTextAlignment = false;
            this.description_lbl.Text = "الملاحظات";
            this.description_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.description_lbl.Weight = 0.86269385607648275D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrTable2,
            this.taxInvoice_lbl,
            this.logo_data,
            this.xrTable3,
            this.xrTable1});
            this.ReportHeader.HeightF = 246.8391F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(426.5239F, 147.0833F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7});
            this.xrTable3.SizeF = new System.Drawing.SizeF(393.4761F, 66.40628F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.site_lbl,
            this.siteRef_data,
            this.siteName_data});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // site_lbl
            // 
            this.site_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.site_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.site_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.site_lbl.Multiline = true;
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.site_lbl.StylePriority.UseBackColor = false;
            this.site_lbl.StylePriority.UseBorders = false;
            this.site_lbl.StylePriority.UseFont = false;
            this.site_lbl.StylePriority.UsePadding = false;
            this.site_lbl.Text = "الموقع";
            this.site_lbl.Weight = 0.50842533086277208D;
            // 
            // siteRef_data
            // 
            this.siteRef_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siteRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.siteRef_data.Multiline = true;
            this.siteRef_data.Name = "siteRef_data";
            this.siteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.siteRef_data.StylePriority.UseBackColor = false;
            this.siteRef_data.StylePriority.UseBorders = false;
            this.siteRef_data.StylePriority.UsePadding = false;
            this.siteRef_data.Weight = 0.6830490198717929D;
            // 
            // siteName_data
            // 
            this.siteName_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siteName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.siteName_data.Multiline = true;
            this.siteName_data.Name = "siteName_data";
            this.siteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.siteName_data.StylePriority.UseBackColor = false;
            this.siteName_data.StylePriority.UseBorders = false;
            this.siteName_data.StylePriority.UsePadding = false;
            this.siteName_data.Weight = 0.9486792744764887D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.currency_lbl,
            this.currency_data});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // currency_lbl
            // 
            this.currency_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currency_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.currency_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.currency_lbl.Multiline = true;
            this.currency_lbl.Name = "currency_lbl";
            this.currency_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.currency_lbl.StylePriority.UseBackColor = false;
            this.currency_lbl.StylePriority.UseBorders = false;
            this.currency_lbl.StylePriority.UseFont = false;
            this.currency_lbl.StylePriority.UsePadding = false;
            this.currency_lbl.Text = "العملة";
            this.currency_lbl.Weight = 0.50842563878793889D;
            // 
            // currency_data
            // 
            this.currency_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.currency_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.currency_data.Multiline = true;
            this.currency_data.Name = "currency_data";
            this.currency_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.currency_data.StylePriority.UseBackColor = false;
            this.currency_data.StylePriority.UseBorders = false;
            this.currency_data.StylePriority.UsePadding = false;
            this.currency_data.Weight = 1.6317279864231149D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.salesPerson_lbl,
            this.salesPerson_data});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // salesPerson_lbl
            // 
            this.salesPerson_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesPerson_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.salesPerson_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.salesPerson_lbl.Multiline = true;
            this.salesPerson_lbl.Name = "salesPerson_lbl";
            this.salesPerson_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.salesPerson_lbl.StylePriority.UseBackColor = false;
            this.salesPerson_lbl.StylePriority.UseBorders = false;
            this.salesPerson_lbl.StylePriority.UseFont = false;
            this.salesPerson_lbl.StylePriority.UsePadding = false;
            this.salesPerson_lbl.Text = "مندوب المبيعات";
            this.salesPerson_lbl.Weight = 0.50842528687346256D;
            // 
            // salesPerson_data
            // 
            this.salesPerson_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salesPerson_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.salesPerson_data.Multiline = true;
            this.salesPerson_data.Name = "salesPerson_data";
            this.salesPerson_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.salesPerson_data.StylePriority.UseBackColor = false;
            this.salesPerson_data.StylePriority.UseBorders = false;
            this.salesPerson_data.StylePriority.UsePadding = false;
            this.salesPerson_data.Weight = 1.6317283383375913D;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 147.0833F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4});
            this.xrTable1.SizeF = new System.Drawing.SizeF(380.2962F, 66.40628F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.dtName_lbl,
            this.dtName_data});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // dtName_lbl
            // 
            this.dtName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtName_lbl.Multiline = true;
            this.dtName_lbl.Name = "dtName_lbl";
            this.dtName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.dtName_lbl.StylePriority.UseBackColor = false;
            this.dtName_lbl.StylePriority.UseBorders = false;
            this.dtName_lbl.StylePriority.UseFont = false;
            this.dtName_lbl.StylePriority.UsePadding = false;
            this.dtName_lbl.Text = "نوع الوثيقة";
            this.dtName_lbl.Weight = 0.45573236651609256D;
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
            this.dtName_data.Weight = 1.7026925434302858D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_data});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reference_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.StylePriority.UseBorders = false;
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.StylePriority.UsePadding = false;
            this.reference_lbl.Text = "المرجع";
            this.reference_lbl.Weight = 0.45573236651609245D;
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
            this.reference_data.Weight = 1.7026925434302858D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_lbl,
            this.date_data});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.StylePriority.UseBorders = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.Text = "تاريخ النشر";
            this.date_lbl.Weight = 0.45573236651609245D;
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
            this.date_data.Weight = 1.7026925434302858D;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(136.46F, 114.58F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // taxInvoice_lbl
            // 
            this.taxInvoice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taxInvoice_lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.taxInvoice_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.taxInvoice_lbl.BorderWidth = 1F;
            this.taxInvoice_lbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.taxInvoice_lbl.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 125F);
            this.taxInvoice_lbl.Multiline = true;
            this.taxInvoice_lbl.Name = "taxInvoice_lbl";
            this.taxInvoice_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.taxInvoice_lbl.SizeF = new System.Drawing.SizeF(807.5F, 22.08336F);
            this.taxInvoice_lbl.StylePriority.UseBackColor = false;
            this.taxInvoice_lbl.StylePriority.UseBorderDashStyle = false;
            this.taxInvoice_lbl.StylePriority.UseBorders = false;
            this.taxInvoice_lbl.StylePriority.UseBorderWidth = false;
            this.taxInvoice_lbl.StylePriority.UseFont = false;
            this.taxInvoice_lbl.StylePriority.UsePadding = false;
            this.taxInvoice_lbl.StylePriority.UseTextAlignment = false;
            this.taxInvoice_lbl.Text = "درافت فاتورة بالسريال";
            this.taxInvoice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(185.9398F, 213.4896F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
            this.xrTable2.SizeF = new System.Drawing.SizeF(206.8563F, 22.13542F);
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientName_data});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // clientName_data
            // 
            this.clientName_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientName_data.Multiline = true;
            this.clientName_data.Name = "clientName_data";
            this.clientName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.clientName_data.StylePriority.UseBackColor = false;
            this.clientName_data.StylePriority.UseBorders = false;
            this.clientName_data.StylePriority.UsePadding = false;
            this.clientName_data.Weight = 2D;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 213.4896F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable4.SizeF = new System.Drawing.SizeF(173.4398F, 22.13543F);
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.client_lbl,
            this.clientRef_data});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // client_lbl
            // 
            this.client_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.client_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.client_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.client_lbl.Multiline = true;
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.client_lbl.StylePriority.UseBackColor = false;
            this.client_lbl.StylePriority.UseBorders = false;
            this.client_lbl.StylePriority.UseFont = false;
            this.client_lbl.StylePriority.UsePadding = false;
            this.client_lbl.Text = "العميل";
            this.client_lbl.Weight = 0.41498720359412627D;
            // 
            // clientRef_data
            // 
            this.clientRef_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientRef_data.Multiline = true;
            this.clientRef_data.Name = "clientRef_data";
            this.clientRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.clientRef_data.StylePriority.UseBackColor = false;
            this.clientRef_data.StylePriority.UseBorders = false;
            this.clientRef_data.StylePriority.UsePadding = false;
            this.clientRef_data.Weight = 0.48138556150058676D;
            // 
            // SA106
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRSubreport InvoiceItemsSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand InvoiceItemSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell site_lbl;
        private DevExpress.XtraReports.UI.XRTableCell siteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell siteName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell currency_lbl;
        private DevExpress.XtraReports.UI.XRTableCell currency_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_lbl;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_data;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell dtName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell dtName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell subtotal_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell vat_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell total_data;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell description_lbl;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRLabel taxInvoice_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell clientName_data;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell client_lbl;
        private DevExpress.XtraReports.UI.XRTableCell clientRef_data;
    }
}
