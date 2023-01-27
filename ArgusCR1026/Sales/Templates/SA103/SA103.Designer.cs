
using System;
using System.Drawing.Printing;

namespace ArgusCR1026.Sales.Templates.SA103
{
    partial class SA103
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SA103));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.InvoiceItemSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.InvoiceReceiptSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.goldAmountInWords_data = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotal2_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.subtotal_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vatAmount2_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.vatAmount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.amount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.amount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.amountInWords_data = new DevExpress.XtraReports.UI.XRLabel();
            this.text_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientSig_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientName2_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.cName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cSig_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.sPSig_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.spName2_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.saPeName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sPeSig_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.taxInvoice_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceInfo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plant_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plant_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.license_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.licenseNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.commercialRecord_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.crNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.address_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.address_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientInfo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientVATNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientVATNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.idNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.idNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.exhibitionManager_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.exhibitionManager_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cAddress_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.cAddress_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.QRCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.companyName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.taxNo_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.tamdeedVatNo_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.InvoiceItemsSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
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
            this.TopMargin.HeightF = 10F;
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
            this.xrTable1,
            this.goldAmountInWords_data,
            this.xrTable12,
            this.amountInWords_data,
            this.text_lbl,
            this.xrTable14,
            this.xrTable13,
            this.xrLabel1,
            this.xrTable2});
            this.ReportFooter.HeightF = 232.5499F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(309.875F, 92.3083F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(92.67303F, 25.4501F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.Text = "/  الوزن بالصافي";
            this.xrTableCell2.Weight = 1.022504587041452D;
            // 
            // goldAmountInWords_data
            // 
            this.goldAmountInWords_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.goldAmountInWords_data.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.goldAmountInWords_data.LocationFloat = new DevExpress.Utils.PointFloat(24.99985F, 92.3083F);
            this.goldAmountInWords_data.Multiline = true;
            this.goldAmountInWords_data.Name = "goldAmountInWords_data";
            this.goldAmountInWords_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.goldAmountInWords_data.SizeF = new System.Drawing.SizeF(284.8751F, 25.4501F);
            this.goldAmountInWords_data.StylePriority.UseBorders = false;
            this.goldAmountInWords_data.StylePriority.UseFont = false;
            this.goldAmountInWords_data.StylePriority.UsePadding = false;
            this.goldAmountInWords_data.StylePriority.UseTextAlignment = false;
            this.goldAmountInWords_data.Text = "goldAmountInWords_data";
            this.goldAmountInWords_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTable12
            // 
            this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable12.BorderWidth = 0.5F;
            this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(429.9393F, 12.5F);
            this.xrTable12.Name = "xrTable12";
            this.xrTable12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow19,
            this.xrTableRow8,
            this.xrTableRow9});
            this.xrTable12.SizeF = new System.Drawing.SizeF(372.16F, 74.7F);
            this.xrTable12.StylePriority.UseBorders = false;
            this.xrTable12.StylePriority.UseBorderWidth = false;
            this.xrTable12.StylePriority.UseTextAlignment = false;
            this.xrTable12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotal2_lbl,
            this.xrTableCell1,
            this.subtotal_data});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // subtotal2_lbl
            // 
            this.subtotal2_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotal2_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.subtotal2_lbl.Multiline = true;
            this.subtotal2_lbl.Name = "subtotal2_lbl";
            this.subtotal2_lbl.StylePriority.UseBackColor = false;
            this.subtotal2_lbl.StylePriority.UseFont = false;
            this.subtotal2_lbl.StylePriority.UseTextAlignment = false;
            this.subtotal2_lbl.Text = "إجمالي أجور الفاتورة بدون ضريبة القيمة المضافة";
            this.subtotal2_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.subtotal2_lbl.Weight = 5.5331555020276317D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "SAR";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 1.0017357414515979D;
            // 
            // subtotal_data
            // 
            this.subtotal_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subtotal_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.subtotal_data.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.subtotal_data.Multiline = true;
            this.subtotal_data.Name = "subtotal_data";
            this.subtotal_data.StylePriority.UseBackColor = false;
            this.subtotal_data.StylePriority.UseBorders = false;
            this.subtotal_data.StylePriority.UseFont = false;
            this.subtotal_data.StylePriority.UseTextAlignment = false;
            this.subtotal_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.subtotal_data.Weight = 2.6376405847446351D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vatAmount2_lbl,
            this.xrTableCell4,
            this.vatAmount_data});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // vatAmount2_lbl
            // 
            this.vatAmount2_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatAmount2_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.vatAmount2_lbl.Multiline = true;
            this.vatAmount2_lbl.Name = "vatAmount2_lbl";
            this.vatAmount2_lbl.StylePriority.UseBackColor = false;
            this.vatAmount2_lbl.StylePriority.UseFont = false;
            this.vatAmount2_lbl.StylePriority.UseTextAlignment = false;
            this.vatAmount2_lbl.Text = "ضريبة القيمة المضافة";
            this.vatAmount2_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.vatAmount2_lbl.Weight = 5.5331543346180343D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "SAR";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 1.0017371888877724D;
            // 
            // vatAmount_data
            // 
            this.vatAmount_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vatAmount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vatAmount_data.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.vatAmount_data.Multiline = true;
            this.vatAmount_data.Name = "vatAmount_data";
            this.vatAmount_data.StylePriority.UseBackColor = false;
            this.vatAmount_data.StylePriority.UseBorders = false;
            this.vatAmount_data.StylePriority.UseFont = false;
            this.vatAmount_data.StylePriority.UseTextAlignment = false;
            this.vatAmount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.vatAmount_data.Weight = 2.6376403474434413D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.amount_lbl,
            this.xrTableCell5,
            this.amount_data});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // amount_lbl
            // 
            this.amount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.amount_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.amount_lbl.Multiline = true;
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.StylePriority.UseBackColor = false;
            this.amount_lbl.StylePriority.UseFont = false;
            this.amount_lbl.StylePriority.UseTextAlignment = false;
            this.amount_lbl.Text = "إجمالي أجور الفاتورة شاملة ضريبة القيمة المضافة";
            this.amount_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.amount_lbl.Weight = 5.53315257020054D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "SAR";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 1.00174018158265D;
            // 
            // amount_data
            // 
            this.amount_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.amount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.amount_data.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.amount_data.Multiline = true;
            this.amount_data.Name = "amount_data";
            this.amount_data.StylePriority.UseBackColor = false;
            this.amount_data.StylePriority.UseBorders = false;
            this.amount_data.StylePriority.UseFont = false;
            this.amount_data.StylePriority.UseTextAlignment = false;
            this.amount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.amount_data.Weight = 2.6376389926636095D;
            // 
            // amountInWords_data
            // 
            this.amountInWords_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.amountInWords_data.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.amountInWords_data.LocationFloat = new DevExpress.Utils.PointFloat(402.548F, 92.3083F);
            this.amountInWords_data.Multiline = true;
            this.amountInWords_data.Name = "amountInWords_data";
            this.amountInWords_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.amountInWords_data.SizeF = new System.Drawing.SizeF(346.8703F, 25.4501F);
            this.amountInWords_data.StylePriority.UseBorders = false;
            this.amountInWords_data.StylePriority.UseFont = false;
            this.amountInWords_data.StylePriority.UsePadding = false;
            this.amountInWords_data.StylePriority.UseTextAlignment = false;
            this.amountInWords_data.Text = "amountInWords_data";
            this.amountInWords_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // text_lbl
            // 
            this.text_lbl.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_lbl.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 130.8835F);
            this.text_lbl.Multiline = true;
            this.text_lbl.Name = "text_lbl";
            this.text_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.text_lbl.SizeF = new System.Drawing.SizeF(777.0995F, 21.45831F);
            this.text_lbl.StylePriority.UseFont = false;
            this.text_lbl.StylePriority.UsePadding = false;
            this.text_lbl.StylePriority.UseTextAlignment = false;
            this.text_lbl.Text = resources.GetString("text_lbl.Text");
            this.text_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTable14
            // 
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(446.7049F, 152.3416F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow26,
            this.xrTableRow27,
            this.xrTableRow28});
            this.xrTable14.SizeF = new System.Drawing.SizeF(306.6504F, 80.20834F);
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientSig_lbl});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1D;
            // 
            // clientSig_lbl
            // 
            this.clientSig_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.clientSig_lbl.Multiline = true;
            this.clientSig_lbl.Name = "clientSig_lbl";
            this.clientSig_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.clientSig_lbl.StylePriority.UseFont = false;
            this.clientSig_lbl.StylePriority.UsePadding = false;
            this.clientSig_lbl.StylePriority.UseTextAlignment = false;
            this.clientSig_lbl.Text = "العمیل";
            this.clientSig_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.clientSig_lbl.Weight = 3.6563450720294846D;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientName2_data,
            this.cName_lbl});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1D;
            // 
            // clientName2_data
            // 
            this.clientName2_data.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.clientName2_data.Multiline = true;
            this.clientName2_data.Name = "clientName2_data";
            this.clientName2_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 8, 0, 100F);
            this.clientName2_data.StylePriority.UseFont = false;
            this.clientName2_data.StylePriority.UsePadding = false;
            this.clientName2_data.StylePriority.UseTextAlignment = false;
            this.clientName2_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.clientName2_data.Weight = 2.0300365269285887D;
            // 
            // cName_lbl
            // 
            this.cName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cName_lbl.Multiline = true;
            this.cName_lbl.Name = "cName_lbl";
            this.cName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 8, 0, 100F);
            this.cName_lbl.StylePriority.UseFont = false;
            this.cName_lbl.StylePriority.UsePadding = false;
            this.cName_lbl.Text = "/  اسم المستلم";
            this.cName_lbl.Weight = 1.0984472679738584D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.cSig_lbl});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell13.Weight = 2.0300365269285887D;
            // 
            // cSig_lbl
            // 
            this.cSig_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cSig_lbl.Multiline = true;
            this.cSig_lbl.Name = "cSig_lbl";
            this.cSig_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.cSig_lbl.StylePriority.UseFont = false;
            this.cSig_lbl.StylePriority.UsePadding = false;
            this.cSig_lbl.Text = "/  توقیع المستلم";
            this.cSig_lbl.Weight = 1.0984472679738584D;
            // 
            // xrTable13
            // 
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(63.5416F, 152.3416F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow25,
            this.xrTableRow23,
            this.xrTableRow24});
            this.xrTable13.SizeF = new System.Drawing.SizeF(271.4583F, 80.20834F);
            this.xrTable13.StylePriority.UseTextAlignment = false;
            this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.sPSig_lbl});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1D;
            // 
            // sPSig_lbl
            // 
            this.sPSig_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.sPSig_lbl.Multiline = true;
            this.sPSig_lbl.Name = "sPSig_lbl";
            this.sPSig_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.sPSig_lbl.StylePriority.UseFont = false;
            this.sPSig_lbl.StylePriority.UsePadding = false;
            this.sPSig_lbl.StylePriority.UseTextAlignment = false;
            this.sPSig_lbl.Text = "البائع";
            this.sPSig_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.sPSig_lbl.Weight = 2.9352735807014358D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.spName2_data,
            this.saPeName_lbl});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1D;
            // 
            // spName2_data
            // 
            this.spName2_data.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.spName2_data.Multiline = true;
            this.spName2_data.Name = "spName2_data";
            this.spName2_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 8, 0, 100F);
            this.spName2_data.StylePriority.UseFont = false;
            this.spName2_data.StylePriority.UsePadding = false;
            this.spName2_data.StylePriority.UseTextAlignment = false;
            this.spName2_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.spName2_data.Weight = 1.5960212119604662D;
            // 
            // saPeName_lbl
            // 
            this.saPeName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.saPeName_lbl.Multiline = true;
            this.saPeName_lbl.Name = "saPeName_lbl";
            this.saPeName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 8, 0, 100F);
            this.saPeName_lbl.StylePriority.UseFont = false;
            this.saPeName_lbl.StylePriority.UsePadding = false;
            this.saPeName_lbl.Text = "/  اسم البائع";
            this.saPeName_lbl.Weight = 0.86559619831093071D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.sPeSig_lbl});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 1.5960212119604662D;
            // 
            // sPeSig_lbl
            // 
            this.sPeSig_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.sPeSig_lbl.Multiline = true;
            this.sPeSig_lbl.Name = "sPeSig_lbl";
            this.sPeSig_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.sPeSig_lbl.StylePriority.UseFont = false;
            this.sPeSig_lbl.StylePriority.UsePadding = false;
            this.sPeSig_lbl.Text = "/  توقیع البائع";
            this.sPeSig_lbl.Weight = 0.86559619831093071D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 117.7584F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(777.0995F, 13.12498F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "يلتزم العميل بسداد كمية الذهب الموضحة أعلاه كما هي بعيارة أو ما يعادله بالعيارات " +
    "المختلفة";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(749.4182F, 92.3083F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable2.SizeF = new System.Drawing.SizeF(52.68121F, 25.4501F);
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UsePadding = false;
            this.xrTableCell25.Text = "/  المبلغ";
            this.xrTableCell25.Weight = 1.022504587041452D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrTable4,
            this.xrTable5,
            this.QRCode,
            this.xrTable15,
            this.xrPageInfo1,
            this.xrLabel2,
            this.xrLabel3,
            this.logo_data});
            this.ReportHeader.HeightF = 311.6309F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.taxInvoice_lbl});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(335F, 76.04163F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(140F, 47.91667F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // taxInvoice_lbl
            // 
            this.taxInvoice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taxInvoice_lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.taxInvoice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.taxInvoice_lbl.BorderWidth = 1F;
            this.taxInvoice_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.taxInvoice_lbl.LocationFloat = new DevExpress.Utils.PointFloat(3F, 3F);
            this.taxInvoice_lbl.Multiline = true;
            this.taxInvoice_lbl.Name = "taxInvoice_lbl";
            this.taxInvoice_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 10, 0, 100F);
            this.taxInvoice_lbl.SizeF = new System.Drawing.SizeF(134F, 41F);
            this.taxInvoice_lbl.StylePriority.UseBackColor = false;
            this.taxInvoice_lbl.StylePriority.UseBorderDashStyle = false;
            this.taxInvoice_lbl.StylePriority.UseBorders = false;
            this.taxInvoice_lbl.StylePriority.UseBorderWidth = false;
            this.taxInvoice_lbl.StylePriority.UseFont = false;
            this.taxInvoice_lbl.StylePriority.UsePadding = false;
            this.taxInvoice_lbl.StylePriority.UseTextAlignment = false;
            this.taxInvoice_lbl.Text = "فاتورة  ضريبية";
            this.taxInvoice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.BorderWidth = 0.5F;
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(24.99994F, 144.7917F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow31,
            this.xrTableRow1,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow32,
            this.xrTableRow34});
            this.xrTable4.SizeF = new System.Drawing.SizeF(310F, 154.3808F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseBorderWidth = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceInfo_lbl});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 1D;
            // 
            // invoiceInfo_lbl
            // 
            this.invoiceInfo_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.invoiceInfo_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.invoiceInfo_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.invoiceInfo_lbl.Multiline = true;
            this.invoiceInfo_lbl.Name = "invoiceInfo_lbl";
            this.invoiceInfo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.invoiceInfo_lbl.StylePriority.UseBackColor = false;
            this.invoiceInfo_lbl.StylePriority.UseBorders = false;
            this.invoiceInfo_lbl.StylePriority.UseFont = false;
            this.invoiceInfo_lbl.StylePriority.UsePadding = false;
            this.invoiceInfo_lbl.StylePriority.UseTextAlignment = false;
            this.invoiceInfo_lbl.Text = "بيانات فاتورة المبيعات الضريبية";
            this.invoiceInfo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.invoiceInfo_lbl.Weight = 3.4555553838615527D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_data});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reference_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.StylePriority.UsePadding = false;
            this.reference_lbl.StylePriority.UseTextAlignment = false;
            this.reference_lbl.Text = "رقم الفاتورة";
            this.reference_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.reference_lbl.Weight = 0.83678080929578857D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reference_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseFont = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.StylePriority.UseTextAlignment = false;
            this.reference_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.reference_data.Weight = 2.618774574565764D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_lbl,
            this.date_data});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.StylePriority.UseTextAlignment = false;
            this.date_lbl.Text = "تاریخ الفاتورة";
            this.date_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.date_lbl.Weight = 0.83678082310346558D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.date_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseFont = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.StylePriority.UseTextAlignment = false;
            this.date_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.date_data.Weight = 2.6187745607580881D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plant_lbl,
            this.plant_data});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // plant_lbl
            // 
            this.plant_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plant_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.plant_lbl.Multiline = true;
            this.plant_lbl.Name = "plant_lbl";
            this.plant_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.plant_lbl.StylePriority.UseBackColor = false;
            this.plant_lbl.StylePriority.UseFont = false;
            this.plant_lbl.StylePriority.UsePadding = false;
            this.plant_lbl.StylePriority.UseTextAlignment = false;
            this.plant_lbl.Text = "الفرع";
            this.plant_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.plant_lbl.Weight = 0.83678082310346558D;
            // 
            // plant_data
            // 
            this.plant_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plant_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plant_data.Multiline = true;
            this.plant_data.Name = "plant_data";
            this.plant_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.plant_data.StylePriority.UseBackColor = false;
            this.plant_data.StylePriority.UseFont = false;
            this.plant_data.StylePriority.UsePadding = false;
            this.plant_data.StylePriority.UseTextAlignment = false;
            this.plant_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.plant_data.Weight = 2.6187745607580881D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.license_lbl,
            this.licenseNo_data,
            this.commercialRecord_lbl,
            this.crNo_data});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 1D;
            // 
            // license_lbl
            // 
            this.license_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.license_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.license_lbl.Multiline = true;
            this.license_lbl.Name = "license_lbl";
            this.license_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.license_lbl.StylePriority.UseBackColor = false;
            this.license_lbl.StylePriority.UseFont = false;
            this.license_lbl.StylePriority.UsePadding = false;
            this.license_lbl.StylePriority.UseTextAlignment = false;
            this.license_lbl.Text = "ترخيص";
            this.license_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.license_lbl.Weight = 0.83678082310346569D;
            // 
            // licenseNo_data
            // 
            this.licenseNo_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.licenseNo_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseNo_data.Multiline = true;
            this.licenseNo_data.Name = "licenseNo_data";
            this.licenseNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.licenseNo_data.StylePriority.UseBackColor = false;
            this.licenseNo_data.StylePriority.UseFont = false;
            this.licenseNo_data.StylePriority.UsePadding = false;
            this.licenseNo_data.StylePriority.UseTextAlignment = false;
            this.licenseNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.licenseNo_data.Weight = 1.1579901612815455D;
            // 
            // commercialRecord_lbl
            // 
            this.commercialRecord_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.commercialRecord_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.commercialRecord_lbl.Multiline = true;
            this.commercialRecord_lbl.Name = "commercialRecord_lbl";
            this.commercialRecord_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.commercialRecord_lbl.StylePriority.UseBackColor = false;
            this.commercialRecord_lbl.StylePriority.UseFont = false;
            this.commercialRecord_lbl.StylePriority.UsePadding = false;
            this.commercialRecord_lbl.StylePriority.UseTextAlignment = false;
            this.commercialRecord_lbl.Text = "س ت\r\n";
            this.commercialRecord_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.commercialRecord_lbl.Weight = 0.40492027388387331D;
            // 
            // crNo_data
            // 
            this.crNo_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crNo_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crNo_data.Multiline = true;
            this.crNo_data.Name = "crNo_data";
            this.crNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.crNo_data.StylePriority.UseBackColor = false;
            this.crNo_data.StylePriority.UseFont = false;
            this.crNo_data.StylePriority.UsePadding = false;
            this.crNo_data.StylePriority.UseTextAlignment = false;
            this.crNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.crNo_data.Weight = 1.0558641255926689D;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.address_lbl,
            this.address_data});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 1D;
            // 
            // address_lbl
            // 
            this.address_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.address_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.address_lbl.Multiline = true;
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.address_lbl.StylePriority.UseBackColor = false;
            this.address_lbl.StylePriority.UseFont = false;
            this.address_lbl.StylePriority.UsePadding = false;
            this.address_lbl.StylePriority.UseTextAlignment = false;
            this.address_lbl.Text = "العنوان";
            this.address_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.address_lbl.Weight = 0.83678081910515456D;
            // 
            // address_data
            // 
            this.address_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.address_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_data.Multiline = true;
            this.address_data.Name = "address_data";
            this.address_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.address_data.StylePriority.UseBackColor = false;
            this.address_data.StylePriority.UseFont = false;
            this.address_data.StylePriority.UsePadding = false;
            this.address_data.StylePriority.UseTextAlignment = false;
            this.address_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.address_data.Weight = 2.6187745647563991D;
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.BorderWidth = 0.5F;
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(475F, 144.7917F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow15});
            this.xrTable5.SizeF = new System.Drawing.SizeF(327.0995F, 154.3808F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseBorderWidth = false;
            this.xrTable5.StylePriority.UsePadding = false;
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientInfo_lbl});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // clientInfo_lbl
            // 
            this.clientInfo_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientInfo_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientInfo_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.clientInfo_lbl.Multiline = true;
            this.clientInfo_lbl.Name = "clientInfo_lbl";
            this.clientInfo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.clientInfo_lbl.StylePriority.UseBackColor = false;
            this.clientInfo_lbl.StylePriority.UseBorders = false;
            this.clientInfo_lbl.StylePriority.UseFont = false;
            this.clientInfo_lbl.StylePriority.UsePadding = false;
            this.clientInfo_lbl.StylePriority.UseTextAlignment = false;
            this.clientInfo_lbl.Text = "بيانات العميل";
            this.clientInfo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clientInfo_lbl.Weight = 12.813004979254291D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientName_data,
            this.clientRef_data,
            this.clientName_lbl});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // clientName_data
            // 
            this.clientName_data.BackColor = System.Drawing.Color.White;
            this.clientName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientName_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName_data.Multiline = true;
            this.clientName_data.Name = "clientName_data";
            this.clientName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clientName_data.StylePriority.UseBackColor = false;
            this.clientName_data.StylePriority.UseBorders = false;
            this.clientName_data.StylePriority.UseFont = false;
            this.clientName_data.StylePriority.UsePadding = false;
            this.clientName_data.StylePriority.UseTextAlignment = false;
            this.clientName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clientName_data.Weight = 11.267080055873285D;
            // 
            // clientRef_data
            // 
            this.clientRef_data.BackColor = System.Drawing.Color.White;
            this.clientRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.clientRef_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRef_data.Multiline = true;
            this.clientRef_data.Name = "clientRef_data";
            this.clientRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 3, 0, 0, 100F);
            this.clientRef_data.StylePriority.UseBackColor = false;
            this.clientRef_data.StylePriority.UseBorders = false;
            this.clientRef_data.StylePriority.UseFont = false;
            this.clientRef_data.StylePriority.UsePadding = false;
            this.clientRef_data.StylePriority.UseTextAlignment = false;
            this.clientRef_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clientRef_data.Weight = 5.5297651326292669D;
            // 
            // clientName_lbl
            // 
            this.clientName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientName_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.clientName_lbl.Multiline = true;
            this.clientName_lbl.Name = "clientName_lbl";
            this.clientName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.clientName_lbl.StylePriority.UseBackColor = false;
            this.clientName_lbl.StylePriority.UseFont = false;
            this.clientName_lbl.StylePriority.UsePadding = false;
            this.clientName_lbl.StylePriority.UseTextAlignment = false;
            this.clientName_lbl.Text = "اسم العمیل";
            this.clientName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clientName_lbl.Weight = 5.7011195804325849D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientVATNo_data,
            this.clientVATNo_lbl});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // clientVATNo_data
            // 
            this.clientVATNo_data.BackColor = System.Drawing.Color.White;
            this.clientVATNo_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientVATNo_data.Multiline = true;
            this.clientVATNo_data.Name = "clientVATNo_data";
            this.clientVATNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 4, 0, 0, 100F);
            this.clientVATNo_data.StylePriority.UseBackColor = false;
            this.clientVATNo_data.StylePriority.UseFont = false;
            this.clientVATNo_data.StylePriority.UsePadding = false;
            this.clientVATNo_data.StylePriority.UseTextAlignment = false;
            this.clientVATNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clientVATNo_data.Weight = 16.796840993882469D;
            // 
            // clientVATNo_lbl
            // 
            this.clientVATNo_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientVATNo_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.clientVATNo_lbl.Multiline = true;
            this.clientVATNo_lbl.Name = "clientVATNo_lbl";
            this.clientVATNo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.clientVATNo_lbl.StylePriority.UseBackColor = false;
            this.clientVATNo_lbl.StylePriority.UseFont = false;
            this.clientVATNo_lbl.StylePriority.UsePadding = false;
            this.clientVATNo_lbl.StylePriority.UseTextAlignment = false;
            this.clientVATNo_lbl.Text = "رقم الضریبة";
            this.clientVATNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clientVATNo_lbl.Weight = 5.70112365460896D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.idNo_data,
            this.idNo_lbl});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // idNo_data
            // 
            this.idNo_data.BackColor = System.Drawing.Color.White;
            this.idNo_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNo_data.Multiline = true;
            this.idNo_data.Name = "idNo_data";
            this.idNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.idNo_data.StylePriority.UseBackColor = false;
            this.idNo_data.StylePriority.UseFont = false;
            this.idNo_data.StylePriority.UsePadding = false;
            this.idNo_data.StylePriority.UseTextAlignment = false;
            this.idNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.idNo_data.Weight = 16.796840935758485D;
            // 
            // idNo_lbl
            // 
            this.idNo_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idNo_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.idNo_lbl.Multiline = true;
            this.idNo_lbl.Name = "idNo_lbl";
            this.idNo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.idNo_lbl.StylePriority.UseBackColor = false;
            this.idNo_lbl.StylePriority.UseFont = false;
            this.idNo_lbl.StylePriority.UsePadding = false;
            this.idNo_lbl.StylePriority.UseTextAlignment = false;
            this.idNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.idNo_lbl.Weight = 5.7011237127329375D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.exhibitionManager_data,
            this.exhibitionManager_lbl});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // exhibitionManager_data
            // 
            this.exhibitionManager_data.BackColor = System.Drawing.Color.White;
            this.exhibitionManager_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhibitionManager_data.Multiline = true;
            this.exhibitionManager_data.Name = "exhibitionManager_data";
            this.exhibitionManager_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.exhibitionManager_data.StylePriority.UseBackColor = false;
            this.exhibitionManager_data.StylePriority.UseFont = false;
            this.exhibitionManager_data.StylePriority.UsePadding = false;
            this.exhibitionManager_data.StylePriority.UseTextAlignment = false;
            this.exhibitionManager_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.exhibitionManager_data.Weight = 16.796841012971225D;
            // 
            // exhibitionManager_lbl
            // 
            this.exhibitionManager_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exhibitionManager_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.exhibitionManager_lbl.Multiline = true;
            this.exhibitionManager_lbl.Name = "exhibitionManager_lbl";
            this.exhibitionManager_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.exhibitionManager_lbl.StylePriority.UseBackColor = false;
            this.exhibitionManager_lbl.StylePriority.UseFont = false;
            this.exhibitionManager_lbl.StylePriority.UsePadding = false;
            this.exhibitionManager_lbl.StylePriority.UseTextAlignment = false;
            this.exhibitionManager_lbl.Text = "المستلم";
            this.exhibitionManager_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.exhibitionManager_lbl.Weight = 5.7011236355202026D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cAddress_data,
            this.cAddress_lbl});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // cAddress_data
            // 
            this.cAddress_data.BackColor = System.Drawing.Color.White;
            this.cAddress_data.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress_data.Multiline = true;
            this.cAddress_data.Name = "cAddress_data";
            this.cAddress_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.cAddress_data.StylePriority.UseBackColor = false;
            this.cAddress_data.StylePriority.UseFont = false;
            this.cAddress_data.StylePriority.UsePadding = false;
            this.cAddress_data.StylePriority.UseTextAlignment = false;
            this.cAddress_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.cAddress_data.Weight = 16.796845188292984D;
            // 
            // cAddress_lbl
            // 
            this.cAddress_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cAddress_lbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.cAddress_lbl.Multiline = true;
            this.cAddress_lbl.Name = "cAddress_lbl";
            this.cAddress_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.cAddress_lbl.StylePriority.UseBackColor = false;
            this.cAddress_lbl.StylePriority.UseFont = false;
            this.cAddress_lbl.StylePriority.UsePadding = false;
            this.cAddress_lbl.StylePriority.UseTextAlignment = false;
            this.cAddress_lbl.Text = "العنوان";
            this.cAddress_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.cAddress_lbl.Weight = 5.7011194601984432D;
            // 
            // QRCode
            // 
            this.QRCode.Alignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.QRCode.LocationFloat = new DevExpress.Utils.PointFloat(335F, 170.5218F);
            this.QRCode.Name = "QRCode";
            this.QRCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.QRCode.ShowText = false;
            this.QRCode.SizeF = new System.Drawing.SizeF(114.066F, 102.8548F);
            this.QRCode.StylePriority.UsePadding = false;
            this.QRCode.StylePriority.UseTextAlignment = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            this.QRCode.Symbology = qrCodeGenerator1;
            // 
            // xrTable15
            // 
            this.xrTable15.BackColor = System.Drawing.Color.White;
            this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(487.375F, 54.79166F);
            this.xrTable15.Name = "xrTable15";
            this.xrTable15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow29,
            this.xrTableRow30});
            this.xrTable15.SizeF = new System.Drawing.SizeF(314.7245F, 69.16665F);
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
            this.taxNo_data.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.taxNo_data.Multiline = true;
            this.taxNo_data.Name = "taxNo_data";
            this.taxNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.taxNo_data.StylePriority.UseBorders = false;
            this.taxNo_data.StylePriority.UseFont = false;
            this.taxNo_data.StylePriority.UsePadding = false;
            this.taxNo_data.StylePriority.UseTextAlignment = false;
            this.taxNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.taxNo_data.Weight = 0.9078339691862265D;
            // 
            // tamdeedVatNo_lbl
            // 
            this.tamdeedVatNo_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tamdeedVatNo_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tamdeedVatNo_lbl.Multiline = true;
            this.tamdeedVatNo_lbl.Name = "tamdeedVatNo_lbl";
            this.tamdeedVatNo_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 6, 0, 100F);
            this.tamdeedVatNo_lbl.StylePriority.UseBorders = false;
            this.tamdeedVatNo_lbl.StylePriority.UseFont = false;
            this.tamdeedVatNo_lbl.StylePriority.UsePadding = false;
            this.tamdeedVatNo_lbl.StylePriority.UseTextAlignment = false;
            this.tamdeedVatNo_lbl.Text = "رقم ضریبة القیمة المضافة";
            this.tamdeedVatNo_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tamdeedVatNo_lbl.Weight = 1.0921660308137735D;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(356.8761F, 273.3766F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(92.18991F, 22.75705F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel2.BorderWidth = 0.5F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(335F, 144.7917F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(140F, 2.083336F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel3.BorderWidth = 0.5F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(335F, 296.1335F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(140F, 3.038879F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(24.99989F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(298.9583F, 123.9583F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // InvoiceItemsSubReports
            // 
            this.InvoiceItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(24.99994F, 0F);
            this.InvoiceItemsSubReports.Name = "InvoiceItemsSubReports";
            this.InvoiceItemsSubReports.ReportSource = new ArgusCR1026.Sales.Templates.SA103.InvoiceItemsSubReports();
            this.InvoiceItemsSubReports.SizeF = new System.Drawing.SizeF(777.0995F, 23F);
            // 
            // MetalSubReports
            // 
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(24.99994F, 12.5F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1026.Sales.Templates.SA103.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(777.0995F, 23F);
            // 
            // SA103
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 10, 10);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
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
        private DevExpress.XtraReports.UI.XRLabel taxInvoice_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow31;
        private DevExpress.XtraReports.UI.XRTableCell invoiceInfo_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell plant_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plant_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow32;
        private DevExpress.XtraReports.UI.XRTableCell license_lbl;
        private DevExpress.XtraReports.UI.XRTableCell licenseNo_data;
        private DevExpress.XtraReports.UI.XRTableCell commercialRecord_lbl;
        private DevExpress.XtraReports.UI.XRTableCell crNo_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow34;
        private DevExpress.XtraReports.UI.XRTableCell address_lbl;
        private DevExpress.XtraReports.UI.XRTableCell address_data;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell clientInfo_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell clientName_data;
        private DevExpress.XtraReports.UI.XRTableCell clientRef_data;
        private DevExpress.XtraReports.UI.XRTableCell clientName_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell clientVATNo_data;
        private DevExpress.XtraReports.UI.XRTableCell clientVATNo_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell idNo_data;
        private DevExpress.XtraReports.UI.XRTableCell idNo_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell exhibitionManager_data;
        private DevExpress.XtraReports.UI.XRTableCell exhibitionManager_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell cAddress_data;
        private DevExpress.XtraReports.UI.XRTableCell cAddress_lbl;
        private DevExpress.XtraReports.UI.XRBarCode QRCode;
        private DevExpress.XtraReports.UI.XRTable xrTable15;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow29;
        private DevExpress.XtraReports.UI.XRTableCell companyName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow30;
        private DevExpress.XtraReports.UI.XRTableCell taxNo_data;
        private DevExpress.XtraReports.UI.XRTableCell tamdeedVatNo_lbl;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRTable xrTable12;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow19;
        private DevExpress.XtraReports.UI.XRTableCell subtotal2_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell subtotal_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount2_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell amount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell amount_data;
        private DevExpress.XtraReports.UI.XRLabel amountInWords_data;
        private DevExpress.XtraReports.UI.XRLabel text_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable14;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow26;
        private DevExpress.XtraReports.UI.XRTableCell clientSig_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow27;
        private DevExpress.XtraReports.UI.XRTableCell clientName2_data;
        private DevExpress.XtraReports.UI.XRTableCell cName_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell cSig_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable13;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow25;
        private DevExpress.XtraReports.UI.XRTableCell sPSig_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow23;
        private DevExpress.XtraReports.UI.XRTableCell spName2_data;
        private DevExpress.XtraReports.UI.XRTableCell saPeName_lbl;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell sPeSig_lbl;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRLabel goldAmountInWords_data;
    }
}
