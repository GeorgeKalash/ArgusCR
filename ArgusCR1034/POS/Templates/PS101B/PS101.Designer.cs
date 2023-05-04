
using System;
using System.Drawing.Printing;

namespace ArgusCR1034.POS.Templates.PS101B
{
    partial class PS101
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
            this.InvoiceReceiptSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.address_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.address_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.phoneNumber_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.phoneNumber_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.spName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.spName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plant_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.plant_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.companyName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.companyVatNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.companyVatNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.clientSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.spSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.amountInWords_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.total_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
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
            this.InvoiceItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(55.20886F, 0F);
            this.InvoiceItemsSubReports.Name = "InvoiceItemsSubReports";
            this.InvoiceItemsSubReports.ReportSource = new ArgusCR1034.POS.Templates.PS101B.InvoiceItemsSubReports();
            this.InvoiceItemsSubReports.SizeF = new System.Drawing.SizeF(714.5414F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.InvoiceItemSubBand,
            this.InvoiceReceiptSubBand});
            // 
            // InvoiceReceiptSubBand
            // 
            this.InvoiceReceiptSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.InvoiceReceiptSubReports});
            this.InvoiceReceiptSubBand.HeightF = 33.00004F;
            this.InvoiceReceiptSubBand.KeepTogether = true;
            this.InvoiceReceiptSubBand.Name = "InvoiceReceiptSubBand";
            // 
            // InvoiceReceiptSubReports
            // 
            this.InvoiceReceiptSubReports.LocationFloat = new DevExpress.Utils.PointFloat(55.20859F, 10.00004F);
            this.InvoiceReceiptSubReports.Name = "InvoiceReceiptSubReports";
            this.InvoiceReceiptSubReports.ReportSource = new ArgusCR1034.POS.Templates.PS101B.InvoiceReceiptSubReports();
            this.InvoiceReceiptSubReports.SizeF = new System.Drawing.SizeF(714.5416F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23.41666F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.logo_data,
            this.xrTable5,
            this.xrTable4,
            this.xrTable3,
            this.xrTable1,
            this.title_lbl,
            this.xrTable6});
            this.ReportHeader.HeightF = 275.0073F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(55.20834F, 9.999996F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(139.3388F, 132.2115F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrTable5
            // 
            this.xrTable5.Font = new System.Drawing.Font("Arial", 10F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(55.20834F, 226.5974F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(714.5416F, 24.47916F);
            this.xrTable5.StylePriority.UseFont = false;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.address_data,
            this.address_lbl,
            this.phoneNumber_data,
            this.phoneNumber_lbl,
            this.clientName_data,
            this.clientName_lbl});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // address_data
            // 
            this.address_data.BackColor = System.Drawing.Color.White;
            this.address_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.address_data.CanGrow = false;
            this.address_data.Font = new System.Drawing.Font("Arial", 8F);
            this.address_data.Name = "address_data";
            this.address_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.address_data.StylePriority.UseBackColor = false;
            this.address_data.StylePriority.UseBorders = false;
            this.address_data.StylePriority.UseFont = false;
            this.address_data.StylePriority.UsePadding = false;
            this.address_data.StylePriority.UseTextAlignment = false;
            this.address_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.address_data.Weight = 2.6439737603620213D;
            this.address_data.WordWrap = false;
            // 
            // address_lbl
            // 
            this.address_lbl.BackColor = System.Drawing.Color.White;
            this.address_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.address_lbl.CanGrow = false;
            this.address_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.address_lbl.StylePriority.UseBackColor = false;
            this.address_lbl.StylePriority.UseBorders = false;
            this.address_lbl.StylePriority.UseFont = false;
            this.address_lbl.StylePriority.UsePadding = false;
            this.address_lbl.StylePriority.UseTextAlignment = false;
            this.address_lbl.Text = ":العنوان";
            this.address_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.address_lbl.Weight = 0.7310263924805589D;
            this.address_lbl.WordWrap = false;
            // 
            // phoneNumber_data
            // 
            this.phoneNumber_data.BackColor = System.Drawing.Color.White;
            this.phoneNumber_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.phoneNumber_data.CanGrow = false;
            this.phoneNumber_data.Font = new System.Drawing.Font("Arial", 8F);
            this.phoneNumber_data.Name = "phoneNumber_data";
            this.phoneNumber_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.phoneNumber_data.StylePriority.UseBackColor = false;
            this.phoneNumber_data.StylePriority.UseBorders = false;
            this.phoneNumber_data.StylePriority.UseFont = false;
            this.phoneNumber_data.StylePriority.UsePadding = false;
            this.phoneNumber_data.StylePriority.UseTextAlignment = false;
            this.phoneNumber_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.phoneNumber_data.Weight = 1.2636914737542482D;
            this.phoneNumber_data.WordWrap = false;
            // 
            // phoneNumber_lbl
            // 
            this.phoneNumber_lbl.BackColor = System.Drawing.Color.White;
            this.phoneNumber_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.phoneNumber_lbl.CanGrow = false;
            this.phoneNumber_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.phoneNumber_lbl.Name = "phoneNumber_lbl";
            this.phoneNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.phoneNumber_lbl.StylePriority.UseBackColor = false;
            this.phoneNumber_lbl.StylePriority.UseBorders = false;
            this.phoneNumber_lbl.StylePriority.UseFont = false;
            this.phoneNumber_lbl.StylePriority.UsePadding = false;
            this.phoneNumber_lbl.StylePriority.UseTextAlignment = false;
            this.phoneNumber_lbl.Text = ":الجوال";
            this.phoneNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.phoneNumber_lbl.Weight = 0.84761490093825609D;
            this.phoneNumber_lbl.WordWrap = false;
            // 
            // clientName_data
            // 
            this.clientName_data.BackColor = System.Drawing.Color.White;
            this.clientName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientName_data.CanGrow = false;
            this.clientName_data.Font = new System.Drawing.Font("Arial", 8F);
            this.clientName_data.Name = "clientName_data";
            this.clientName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.clientName_data.StylePriority.UseBackColor = false;
            this.clientName_data.StylePriority.UseBorders = false;
            this.clientName_data.StylePriority.UseFont = false;
            this.clientName_data.StylePriority.UsePadding = false;
            this.clientName_data.StylePriority.UseTextAlignment = false;
            this.clientName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.clientName_data.Weight = 2.5136934724649151D;
            this.clientName_data.WordWrap = false;
            // 
            // clientName_lbl
            // 
            this.clientName_lbl.BackColor = System.Drawing.Color.White;
            this.clientName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientName_lbl.CanGrow = false;
            this.clientName_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.clientName_lbl.Name = "clientName_lbl";
            this.clientName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.clientName_lbl.StylePriority.UseBackColor = false;
            this.clientName_lbl.StylePriority.UseBorders = false;
            this.clientName_lbl.StylePriority.UseFont = false;
            this.clientName_lbl.StylePriority.UsePadding = false;
            this.clientName_lbl.StylePriority.UseTextAlignment = false;
            this.clientName_lbl.Text = ":اسم العميل";
            this.clientName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.clientName_lbl.Weight = 1D;
            this.clientName_lbl.WordWrap = false;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(55.20797F, 160.7295F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow12});
            this.xrTable4.SizeF = new System.Drawing.SizeF(243.3281F, 54.16666F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.spName_data,
            this.spName_lbl});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // spName_data
            // 
            this.spName_data.BackColor = System.Drawing.Color.White;
            this.spName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.spName_data.CanGrow = false;
            this.spName_data.Font = new System.Drawing.Font("Arial", 10F);
            this.spName_data.Name = "spName_data";
            this.spName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.spName_data.StylePriority.UseBackColor = false;
            this.spName_data.StylePriority.UseBorders = false;
            this.spName_data.StylePriority.UseFont = false;
            this.spName_data.StylePriority.UsePadding = false;
            this.spName_data.StylePriority.UseTextAlignment = false;
            this.spName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.spName_data.Weight = 1.375D;
            this.spName_data.WordWrap = false;
            // 
            // spName_lbl
            // 
            this.spName_lbl.BackColor = System.Drawing.Color.White;
            this.spName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.spName_lbl.CanGrow = false;
            this.spName_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.spName_lbl.Name = "spName_lbl";
            this.spName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 5, 0, 100F);
            this.spName_lbl.StylePriority.UseBackColor = false;
            this.spName_lbl.StylePriority.UseBorders = false;
            this.spName_lbl.StylePriority.UseFont = false;
            this.spName_lbl.StylePriority.UsePadding = false;
            this.spName_lbl.StylePriority.UseTextAlignment = false;
            this.spName_lbl.Text = "اسم البائع";
            this.spName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.spName_lbl.Weight = 0.625D;
            this.spName_lbl.WordWrap = false;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plant_data,
            this.plant_lbl});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // plant_data
            // 
            this.plant_data.BackColor = System.Drawing.Color.White;
            this.plant_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plant_data.CanGrow = false;
            this.plant_data.Font = new System.Drawing.Font("Arial", 10F);
            this.plant_data.Name = "plant_data";
            this.plant_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.plant_data.StylePriority.UseBackColor = false;
            this.plant_data.StylePriority.UseBorders = false;
            this.plant_data.StylePriority.UseFont = false;
            this.plant_data.StylePriority.UsePadding = false;
            this.plant_data.StylePriority.UseTextAlignment = false;
            this.plant_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.plant_data.Weight = 1.3749993896484374D;
            this.plant_data.WordWrap = false;
            // 
            // plant_lbl
            // 
            this.plant_lbl.BackColor = System.Drawing.Color.White;
            this.plant_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plant_lbl.CanGrow = false;
            this.plant_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.plant_lbl.Name = "plant_lbl";
            this.plant_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 5, 0, 100F);
            this.plant_lbl.StylePriority.UseBackColor = false;
            this.plant_lbl.StylePriority.UseBorders = false;
            this.plant_lbl.StylePriority.UseFont = false;
            this.plant_lbl.StylePriority.UsePadding = false;
            this.plant_lbl.StylePriority.UseTextAlignment = false;
            this.plant_lbl.Text = "الفرع";
            this.plant_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.plant_lbl.Weight = 0.62500061035156251D;
            this.plant_lbl.WordWrap = false;
            // 
            // xrTable3
            // 
            this.xrTable3.Font = new System.Drawing.Font("Arial", 10F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(525.8455F, 160.7295F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow11});
            this.xrTable3.SizeF = new System.Drawing.SizeF(243.9044F, 54.16664F);
            this.xrTable3.StylePriority.UseFont = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_data,
            this.reference_lbl});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.White;
            this.reference_data.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.reference_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_data.CanGrow = false;
            this.reference_data.Font = new System.Drawing.Font("Arial", 10F);
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseBorderDashStyle = false;
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UseFont = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.StylePriority.UseTextAlignment = false;
            this.reference_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.reference_data.Weight = 1.2364062532521074D;
            this.reference_data.WordWrap = false;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.White;
            this.reference_lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.reference_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_lbl.CanGrow = false;
            this.reference_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 5, 0, 100F);
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.StylePriority.UseBorderDashStyle = false;
            this.reference_lbl.StylePriority.UseBorders = false;
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.StylePriority.UsePadding = false;
            this.reference_lbl.StylePriority.UseTextAlignment = false;
            this.reference_lbl.Text = "رقم الفاتورة";
            this.reference_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.reference_lbl.Weight = 0.76359374674789271D;
            this.reference_lbl.WordWrap = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_data,
            this.date_lbl});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.White;
            this.date_data.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.date_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_data.CanGrow = false;
            this.date_data.Font = new System.Drawing.Font("Arial", 10F);
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseBorderDashStyle = false;
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UseFont = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.StylePriority.UseTextAlignment = false;
            this.date_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.date_data.Weight = 1.2364062532521074D;
            this.date_data.WordWrap = false;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.White;
            this.date_lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.date_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_lbl.CanGrow = false;
            this.date_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 5, 0, 100F);
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.StylePriority.UseBorderDashStyle = false;
            this.date_lbl.StylePriority.UseBorders = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.StylePriority.UseTextAlignment = false;
            this.date_lbl.Text = "التاريخ";
            this.date_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.date_lbl.Weight = 0.7635937467478926D;
            this.date_lbl.WordWrap = false;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(482.4333F, 9.999996F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(287.3163F, 30.54481F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.companyName_data});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // companyName_data
            // 
            this.companyName_data.BackColor = System.Drawing.Color.White;
            this.companyName_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.companyName_data.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.companyName_data.Multiline = true;
            this.companyName_data.Name = "companyName_data";
            this.companyName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.companyName_data.StylePriority.UseBackColor = false;
            this.companyName_data.StylePriority.UseBorders = false;
            this.companyName_data.StylePriority.UseFont = false;
            this.companyName_data.StylePriority.UsePadding = false;
            this.companyName_data.StylePriority.UseTextAlignment = false;
            this.companyName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.companyName_data.Weight = 1.5219041791973686D;
            // 
            // title_lbl
            // 
            this.title_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.title_lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.title_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.title_lbl.CanGrow = false;
            this.title_lbl.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(315.2823F, 105.2324F);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(175.5032F, 36.97915F);
            this.title_lbl.StylePriority.UseBackColor = false;
            this.title_lbl.StylePriority.UseBorderDashStyle = false;
            this.title_lbl.StylePriority.UseBorders = false;
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UsePadding = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "فاتورة شراء ذهب خام";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.title_lbl.WordWrap = false;
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(482.4333F, 40.54483F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(287.3163F, 28.75005F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.companyVatNo_data,
            this.companyVatNo_lbl});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // companyVatNo_data
            // 
            this.companyVatNo_data.BackColor = System.Drawing.Color.White;
            this.companyVatNo_data.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.companyVatNo_data.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.companyVatNo_data.Multiline = true;
            this.companyVatNo_data.Name = "companyVatNo_data";
            this.companyVatNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.companyVatNo_data.StylePriority.UseBackColor = false;
            this.companyVatNo_data.StylePriority.UseBorders = false;
            this.companyVatNo_data.StylePriority.UseFont = false;
            this.companyVatNo_data.StylePriority.UsePadding = false;
            this.companyVatNo_data.StylePriority.UseTextAlignment = false;
            this.companyVatNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.companyVatNo_data.Weight = 1.2862377587271623D;
            // 
            // companyVatNo_lbl
            // 
            this.companyVatNo_lbl.BackColor = System.Drawing.Color.White;
            this.companyVatNo_lbl.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.companyVatNo_lbl.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.companyVatNo_lbl.Multiline = true;
            this.companyVatNo_lbl.Name = "companyVatNo_lbl";
            this.companyVatNo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.companyVatNo_lbl.StylePriority.UseBackColor = false;
            this.companyVatNo_lbl.StylePriority.UseBorders = false;
            this.companyVatNo_lbl.StylePriority.UseFont = false;
            this.companyVatNo_lbl.StylePriority.UsePadding = false;
            this.companyVatNo_lbl.StylePriority.UseTextAlignment = false;
            this.companyVatNo_lbl.Text = ":الرقم الضريبي";
            this.companyVatNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.companyVatNo_lbl.Weight = 0.616787303314335D;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pagesNumber_lbl,
            this.printSignature_lbl});
            this.PageFooter.HeightF = 32.50002F;
            this.PageFooter.Name = "PageFooter";
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.White;
            this.pagesNumber_lbl.Font = new System.Drawing.Font("Arial", 7F);
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(667.7477F, 12.5F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(102.0022F, 20.00002F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseFont = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.BackColor = System.Drawing.Color.White;
            this.printSignature_lbl.Font = new System.Drawing.Font("Arial", 7F);
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(55.20833F, 12.5F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(519.0977F, 20.00002F);
            this.printSignature_lbl.StylePriority.UseBackColor = false;
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature_lbl";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.clientSignature_lbl,
            this.spSignature_lbl,
            this.xrTable9});
            this.ReportFooter.HeightF = 98.32433F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // clientSignature_lbl
            // 
            this.clientSignature_lbl.BackColor = System.Drawing.Color.White;
            this.clientSignature_lbl.CanGrow = false;
            this.clientSignature_lbl.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.clientSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(55.20797F, 48.78472F);
            this.clientSignature_lbl.Name = "clientSignature_lbl";
            this.clientSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.clientSignature_lbl.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.clientSignature_lbl.StylePriority.UseBackColor = false;
            this.clientSignature_lbl.StylePriority.UseFont = false;
            this.clientSignature_lbl.StylePriority.UsePadding = false;
            this.clientSignature_lbl.StylePriority.UseTextAlignment = false;
            this.clientSignature_lbl.Text = "توقيع العميل";
            this.clientSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.clientSignature_lbl.WordWrap = false;
            // 
            // spSignature_lbl
            // 
            this.spSignature_lbl.BackColor = System.Drawing.Color.White;
            this.spSignature_lbl.CanGrow = false;
            this.spSignature_lbl.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.spSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(669.7496F, 48.78472F);
            this.spSignature_lbl.Name = "spSignature_lbl";
            this.spSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.spSignature_lbl.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.spSignature_lbl.StylePriority.UseBackColor = false;
            this.spSignature_lbl.StylePriority.UseFont = false;
            this.spSignature_lbl.StylePriority.UsePadding = false;
            this.spSignature_lbl.StylePriority.UseTextAlignment = false;
            this.spSignature_lbl.Text = "توقيع البائع";
            this.spSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.spSignature_lbl.WordWrap = false;
            // 
            // xrTable9
            // 
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(55.20859F, 10.00002F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable9.SizeF = new System.Drawing.SizeF(714.5414F, 25F);
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.amountInWords_data,
            this.total_lbl});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // amountInWords_data
            // 
            this.amountInWords_data.BackColor = System.Drawing.Color.White;
            this.amountInWords_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.amountInWords_data.Name = "amountInWords_data";
            this.amountInWords_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.amountInWords_data.StylePriority.UseBackColor = false;
            this.amountInWords_data.StylePriority.UseBorders = false;
            this.amountInWords_data.StylePriority.UsePadding = false;
            this.amountInWords_data.StylePriority.UseTextAlignment = false;
            this.amountInWords_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.amountInWords_data.Weight = 1.7142857641407341D;
            this.amountInWords_data.WordWrap = false;
            // 
            // total_lbl
            // 
            this.total_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.total_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.total_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.total_lbl.StylePriority.UseBackColor = false;
            this.total_lbl.StylePriority.UseBorders = false;
            this.total_lbl.StylePriority.UseFont = false;
            this.total_lbl.StylePriority.UsePadding = false;
            this.total_lbl.StylePriority.UseTextAlignment = false;
            this.total_lbl.Text = "تفقيط وفق الريال";
            this.total_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.total_lbl.Weight = 0.28571423585926603D;
            // 
            // PS101
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 23, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel clientSignature_lbl;
        private DevExpress.XtraReports.UI.XRLabel spSignature_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable9;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell amountInWords_data;
        private DevExpress.XtraReports.UI.XRTableCell total_lbl;
        private DevExpress.XtraReports.UI.XRSubreport InvoiceItemsSubReports;
        private DevExpress.XtraReports.UI.XRSubreport InvoiceReceiptSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand InvoiceItemSubBand;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell companyName_data;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell companyVatNo_data;
        private DevExpress.XtraReports.UI.XRTableCell companyVatNo_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell spName_data;
        private DevExpress.XtraReports.UI.XRTableCell spName_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell plant_data;
        private DevExpress.XtraReports.UI.XRTableCell plant_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell address_data;
        private DevExpress.XtraReports.UI.XRTableCell address_lbl;
        private DevExpress.XtraReports.UI.XRTableCell phoneNumber_data;
        private DevExpress.XtraReports.UI.XRTableCell phoneNumber_lbl;
        private DevExpress.XtraReports.UI.XRTableCell clientName_data;
        private DevExpress.XtraReports.UI.XRTableCell clientName_lbl;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
    }
}
