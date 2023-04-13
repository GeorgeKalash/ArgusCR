
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
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.companyName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientId_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
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
            this.InvoiceItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(55.20833F, 0F);
            this.InvoiceItemsSubReports.Name = "InvoiceItemsSubReports";
            this.InvoiceItemsSubReports.ReportSource = new ArgusCR1034.POS.Templates.PS101GLD.InvoiceItemsSubReports();
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
            this.InvoiceReceiptSubBand.HeightF = 33.00001F;
            this.InvoiceReceiptSubBand.KeepTogether = true;
            this.InvoiceReceiptSubBand.Name = "InvoiceReceiptSubBand";
            // 
            // InvoiceReceiptSubReports
            // 
            this.InvoiceReceiptSubReports.LocationFloat = new DevExpress.Utils.PointFloat(55.20797F, 10.00001F);
            this.InvoiceReceiptSubReports.Name = "InvoiceReceiptSubReports";
            this.InvoiceReceiptSubReports.ReportSource = new ArgusCR1034.POS.Templates.PS101GLD.InvoiceReceiptSubReports();
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
            this.xrTable1,
            this.xrTable3,
            this.title_lbl,
            this.xrTable4,
            this.xrTable6});
            this.ReportHeader.HeightF = 201.7017F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(482.4335F, 0F);
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
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(315.282F, 77.19032F);
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
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Arial", 10F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(55.20834F, 130.7641F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(714.5416F, 48.95832F);
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_data,
            this.xrTableCell2,
            this.clientName_data,
            this.clientName_lbl});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.White;
            this.date_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_data.CanGrow = false;
            this.date_data.Font = new System.Drawing.Font("Arial", 8F);
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UseFont = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.StylePriority.UseTextAlignment = false;
            this.date_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.date_data.Weight = 2.8384120181078756D;
            this.date_data.WordWrap = false;
            // 
            // clientName_data
            // 
            this.clientName_data.BackColor = System.Drawing.Color.White;
            this.clientName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientName_data.CanGrow = false;
            this.clientName_data.Font = new System.Drawing.Font("Arial", 8F);
            this.clientName_data.Multiline = true;
            this.clientName_data.Name = "clientName_data";
            this.clientName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.clientName_data.StylePriority.UseBackColor = false;
            this.clientName_data.StylePriority.UseBorders = false;
            this.clientName_data.StylePriority.UseFont = false;
            this.clientName_data.StylePriority.UsePadding = false;
            this.clientName_data.StylePriority.UseTextAlignment = false;
            this.clientName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.clientName_data.Weight = 1.8227440445560923D;
            this.clientName_data.WordWrap = false;
            // 
            // clientName_lbl
            // 
            this.clientName_lbl.BackColor = System.Drawing.Color.White;
            this.clientName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
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
            this.clientName_lbl.Weight = 1.0031642471843885D;
            this.clientName_lbl.WordWrap = false;
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(482.4336F, 30.54481F);
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
            this.xrTable2,
            this.clientSignature_lbl,
            this.spSignature_lbl,
            this.xrTable9});
            this.ReportFooter.HeightF = 147.45F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // clientSignature_lbl
            // 
            this.clientSignature_lbl.BackColor = System.Drawing.Color.White;
            this.clientSignature_lbl.CanGrow = false;
            this.clientSignature_lbl.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.clientSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(45.20856F, 96.00692F);
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
            this.spSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(659.7499F, 96.00692F);
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
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(45.20857F, 17.81252F);
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
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.clientId_data,
            this.xrTableCell1});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.White;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "تاريخ الفاتورة";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell4.Weight = 2.8384120536924D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.White;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.Weight = 3.3356799037178795D;
            // 
            // clientId_data
            // 
            this.clientId_data.BackColor = System.Drawing.Color.White;
            this.clientId_data.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.clientId_data.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.clientId_data.Multiline = true;
            this.clientId_data.Name = "clientId_data";
            this.clientId_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.clientId_data.StylePriority.UseBackColor = false;
            this.clientId_data.StylePriority.UseBorders = false;
            this.clientId_data.StylePriority.UseFont = false;
            this.clientId_data.StylePriority.UsePadding = false;
            this.clientId_data.StylePriority.UseTextAlignment = false;
            this.clientId_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.clientId_data.Weight = 1.8227439235332554D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.White;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = ":رمز العميل";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.Weight = 1.003164119056466D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.White;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 5, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 3.3356796901516446D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.White;
            this.reference_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_data.CanGrow = false;
            this.reference_data.Font = new System.Drawing.Font("Arial", 10F);
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 5, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UseFont = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.StylePriority.UseTextAlignment = false;
            this.reference_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.reference_data.Weight = 1.375D;
            this.reference_data.WordWrap = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_data});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(55.20834F, 87.08612F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(167.2881F, 27.08333F);
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(45.20856F, 54.72226F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(714.5414F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_data,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // description_data
            // 
            this.description_data.BackColor = System.Drawing.Color.White;
            this.description_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.description_data.Name = "description_data";
            this.description_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.description_data.StylePriority.UseBackColor = false;
            this.description_data.StylePriority.UseBorders = false;
            this.description_data.StylePriority.UsePadding = false;
            this.description_data.StylePriority.UseTextAlignment = false;
            this.description_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.description_data.Weight = 1.7142857641407341D;
            this.description_data.WordWrap = false;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 4, 0, 100F);
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "البيان";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.Weight = 0.28571423585926603D;
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
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
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
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableCell clientName_data;
        private DevExpress.XtraReports.UI.XRTableCell clientName_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell companyVatNo_data;
        private DevExpress.XtraReports.UI.XRTableCell companyVatNo_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell clientId_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    }
}
