
using System;
using System.Drawing.Printing;

namespace ArgusCR1024.Purchase.Templates.PU103GLD
{
    partial class PU103GLD
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
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.amount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.amount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vatAmount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vatAmount_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotal_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.subtotal_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.purchaseInvoice_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.dueDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.dueDate_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.dtName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.currencyName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.currencyName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.plantName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plantName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.pmName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.pmName_data = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
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
            this.InvoiceItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(44.37501F, 0F);
            this.InvoiceItemsSubReports.Name = "InvoiceItemsSubReports";
            this.InvoiceItemsSubReports.ReportSource = new ArgusCR1024.Purchase.Templates.PU103GLD.InvoiceItemsSubReports();
            this.InvoiceItemsSubReports.SizeF = new System.Drawing.SizeF(737.2083F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
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
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(44.37502F, 12.5F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1024.Purchase.Templates.PU103GLD.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(737.2082F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35.91666F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pagesNumber_lbl,
            this.printSignature_lbl});
            this.PageFooter.HeightF = 32.99999F;
            this.PageFooter.Name = "PageFooter";
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(683.0682F, 9.999974F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(98.5152F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(44.375F, 9.999974F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(600.7798F, 23.00002F);
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10,
            this.xrTable9,
            this.xrTable8});
            this.ReportFooter.HeightF = 98.97899F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable10
            // 
            this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(44.37501F, 72.93733F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable10.SizeF = new System.Drawing.SizeF(737.2083F, 26.04166F);
            this.xrTable10.StylePriority.UseBorders = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.amount_lbl,
            this.amount_data});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // amount_lbl
            // 
            this.amount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.amount_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.amount_lbl.Multiline = true;
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 6, 0, 100F);
            this.amount_lbl.StylePriority.UseBackColor = false;
            this.amount_lbl.StylePriority.UseFont = false;
            this.amount_lbl.StylePriority.UsePadding = false;
            this.amount_lbl.Text = "amount_lbl";
            this.amount_lbl.Weight = 2.3982691564135381D;
            // 
            // amount_data
            // 
            this.amount_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.amount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.amount_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.amount_data.Multiline = true;
            this.amount_data.Name = "amount_data";
            this.amount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.amount_data.StylePriority.UseBackColor = false;
            this.amount_data.StylePriority.UseBorders = false;
            this.amount_data.StylePriority.UseFont = false;
            this.amount_data.StylePriority.UsePadding = false;
            this.amount_data.StylePriority.UseTextAlignment = false;
            this.amount_data.Text = "amount_data";
            this.amount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.amount_data.TextFormatString = "{0:n2}";
            this.amount_data.Weight = 0.42845788578806271D;
            // 
            // xrTable9
            // 
            this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(44.37501F, 47.93739F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable9.SizeF = new System.Drawing.SizeF(737.2083F, 25F);
            this.xrTable9.StylePriority.UseBorders = false;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vatAmount_lbl,
            this.vatAmount_data});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // vatAmount_lbl
            // 
            this.vatAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatAmount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.vatAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.vatAmount_lbl.Multiline = true;
            this.vatAmount_lbl.Name = "vatAmount_lbl";
            this.vatAmount_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 6, 0, 100F);
            this.vatAmount_lbl.StylePriority.UseBackColor = false;
            this.vatAmount_lbl.StylePriority.UseBorders = false;
            this.vatAmount_lbl.StylePriority.UseFont = false;
            this.vatAmount_lbl.StylePriority.UsePadding = false;
            this.vatAmount_lbl.Text = "vatAmount_lbl";
            this.vatAmount_lbl.Weight = 4.7252404357992823D;
            // 
            // vatAmount_data
            // 
            this.vatAmount_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vatAmount_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.vatAmount_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.vatAmount_data.Multiline = true;
            this.vatAmount_data.Name = "vatAmount_data";
            this.vatAmount_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.vatAmount_data.StylePriority.UseBackColor = false;
            this.vatAmount_data.StylePriority.UseBorders = false;
            this.vatAmount_data.StylePriority.UseFont = false;
            this.vatAmount_data.StylePriority.UsePadding = false;
            this.vatAmount_data.StylePriority.UseTextAlignment = false;
            this.vatAmount_data.Text = "vatAmount_data";
            this.vatAmount_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.vatAmount_data.TextFormatString = "{0:n2}";
            this.vatAmount_data.Weight = 0.84417806675056051D;
            // 
            // xrTable8
            // 
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(44.375F, 21.89573F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable8.SizeF = new System.Drawing.SizeF(737.2083F, 26.04167F);
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotal_lbl,
            this.subtotal_data});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // subtotal_lbl
            // 
            this.subtotal_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotal_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.subtotal_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.subtotal_lbl.Multiline = true;
            this.subtotal_lbl.Name = "subtotal_lbl";
            this.subtotal_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 6, 0, 100F);
            this.subtotal_lbl.StylePriority.UseBackColor = false;
            this.subtotal_lbl.StylePriority.UseBorders = false;
            this.subtotal_lbl.StylePriority.UseFont = false;
            this.subtotal_lbl.StylePriority.UsePadding = false;
            this.subtotal_lbl.Text = "subtotal_lbl";
            this.subtotal_lbl.Weight = 5.5216141270111061D;
            // 
            // subtotal_data
            // 
            this.subtotal_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subtotal_data.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.subtotal_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.subtotal_data.Multiline = true;
            this.subtotal_data.Name = "subtotal_data";
            this.subtotal_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.subtotal_data.StylePriority.UseBackColor = false;
            this.subtotal_data.StylePriority.UseBorders = false;
            this.subtotal_data.StylePriority.UseFont = false;
            this.subtotal_data.StylePriority.UsePadding = false;
            this.subtotal_data.StylePriority.UseTextAlignment = false;
            this.subtotal_data.Text = "subtotal_data";
            this.subtotal_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.subtotal_data.TextFormatString = "{0:n2}";
            this.subtotal_data.Weight = 0.98645106770083046D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.purchaseInvoice_lbl,
            this.xrTable5,
            this.xrTable4,
            this.xrTable3});
            this.ReportHeader.HeightF = 249.4583F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // purchaseInvoice_lbl
            // 
            this.purchaseInvoice_lbl.BackColor = System.Drawing.Color.Black;
            this.purchaseInvoice_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.purchaseInvoice_lbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.purchaseInvoice_lbl.ForeColor = System.Drawing.Color.White;
            this.purchaseInvoice_lbl.LocationFloat = new DevExpress.Utils.PointFloat(44.375F, 0F);
            this.purchaseInvoice_lbl.Multiline = true;
            this.purchaseInvoice_lbl.Name = "purchaseInvoice_lbl";
            this.purchaseInvoice_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.purchaseInvoice_lbl.SizeF = new System.Drawing.SizeF(737.2083F, 39.58333F);
            this.purchaseInvoice_lbl.StylePriority.UseBackColor = false;
            this.purchaseInvoice_lbl.StylePriority.UseBorders = false;
            this.purchaseInvoice_lbl.StylePriority.UseFont = false;
            this.purchaseInvoice_lbl.StylePriority.UseForeColor = false;
            this.purchaseInvoice_lbl.StylePriority.UsePadding = false;
            this.purchaseInvoice_lbl.StylePriority.UseTextAlignment = false;
            this.purchaseInvoice_lbl.Text = "Purchase Invoice";
            this.purchaseInvoice_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(44.375F, 162.4999F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable5.SizeF = new System.Drawing.SizeF(368.6041F, 66.04172F);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_lbl,
            this.description_data});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.description_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.description_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.description_lbl.StylePriority.UseBackColor = false;
            this.description_lbl.StylePriority.UseBorders = false;
            this.description_lbl.StylePriority.UseFont = false;
            this.description_lbl.StylePriority.UsePadding = false;
            this.description_lbl.Text = "description_lbl";
            this.description_lbl.Weight = 0.99643681367246351D;
            // 
            // description_data
            // 
            this.description_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.description_data.Multiline = true;
            this.description_data.Name = "description_data";
            this.description_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.description_data.StylePriority.UseBorders = false;
            this.description_data.StylePriority.UsePadding = false;
            this.description_data.Text = "description_data";
            this.description_data.Weight = 1.9993298722190025D;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(412.9792F, 162.4999F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable4.SizeF = new System.Drawing.SizeF(368.6041F, 29.16673F);
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.dueDate_lbl,
            this.dueDate_data});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // dueDate_lbl
            // 
            this.dueDate_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dueDate_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dueDate_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.dueDate_lbl.Multiline = true;
            this.dueDate_lbl.Name = "dueDate_lbl";
            this.dueDate_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.dueDate_lbl.StylePriority.UseBackColor = false;
            this.dueDate_lbl.StylePriority.UseBorders = false;
            this.dueDate_lbl.StylePriority.UseFont = false;
            this.dueDate_lbl.StylePriority.UsePadding = false;
            this.dueDate_lbl.Text = "dueDate_lbl";
            this.dueDate_lbl.Weight = 1.0006818601647638D;
            // 
            // dueDate_data
            // 
            this.dueDate_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dueDate_data.Multiline = true;
            this.dueDate_data.Name = "dueDate_data";
            this.dueDate_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.dueDate_data.StylePriority.UseBorders = false;
            this.dueDate_data.StylePriority.UsePadding = false;
            this.dueDate_data.Text = "dueDate_data";
            this.dueDate_data.TextFormatString = "{0:dd/MM/yyyy}";
            this.dueDate_data.Weight = 2.0035631863275363D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(44.37501F, 39.58333F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable3.SizeF = new System.Drawing.SizeF(737.2083F, 122.9166F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.dtName_lbl,
            this.dtName_data,
            this.date_lbl,
            this.date_data});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // dtName_lbl
            // 
            this.dtName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtName_lbl.Multiline = true;
            this.dtName_lbl.Name = "dtName_lbl";
            this.dtName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.dtName_lbl.StylePriority.UseBackColor = false;
            this.dtName_lbl.StylePriority.UseBorders = false;
            this.dtName_lbl.StylePriority.UseFont = false;
            this.dtName_lbl.StylePriority.UsePadding = false;
            this.dtName_lbl.Text = "dtName_lbl";
            this.dtName_lbl.Weight = 0.66429131194483859D;
            // 
            // dtName_data
            // 
            this.dtName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_data.Multiline = true;
            this.dtName_data.Name = "dtName_data";
            this.dtName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.dtName_data.StylePriority.UseBorders = false;
            this.dtName_data.StylePriority.UsePadding = false;
            this.dtName_data.Text = "dtName_data";
            this.dtName_data.Weight = 1.3357086880551612D;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.StylePriority.UseBorders = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.Text = "date_lbl";
            this.date_lbl.Weight = 0.6642913269184807D;
            // 
            // date_data
            // 
            this.date_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.Text = "date_data";
            this.date_data.TextFormatString = "{0:dd/MM/yyyy}";
            this.date_data.Weight = 1.3357086730815195D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_data,
            this.currencyName_lbl,
            this.currencyName_data});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reference_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.StylePriority.UseBorders = false;
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.StylePriority.UsePadding = false;
            this.reference_lbl.Text = "reference_lbl";
            this.reference_lbl.Weight = 0.66429131194483859D;
            // 
            // reference_data
            // 
            this.reference_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.Text = "reference_data";
            this.reference_data.Weight = 1.3357086880551612D;
            // 
            // currencyName_lbl
            // 
            this.currencyName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currencyName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.currencyName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.currencyName_lbl.Multiline = true;
            this.currencyName_lbl.Name = "currencyName_lbl";
            this.currencyName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.currencyName_lbl.StylePriority.UseBackColor = false;
            this.currencyName_lbl.StylePriority.UseBorders = false;
            this.currencyName_lbl.StylePriority.UseFont = false;
            this.currencyName_lbl.StylePriority.UsePadding = false;
            this.currencyName_lbl.Text = "currencyName_lbl";
            this.currencyName_lbl.Weight = 0.6642913269184807D;
            // 
            // currencyName_data
            // 
            this.currencyName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.currencyName_data.Multiline = true;
            this.currencyName_data.Name = "currencyName_data";
            this.currencyName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.currencyName_data.StylePriority.UseBorders = false;
            this.currencyName_data.StylePriority.UsePadding = false;
            this.currencyName_data.Text = "currencyName_data";
            this.currencyName_data.Weight = 1.3357086730815193D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorRef_lbl,
            this.vendorRef_data,
            this.plantName_lbl,
            this.plantName_data});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // vendorRef_lbl
            // 
            this.vendorRef_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vendorRef_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vendorRef_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.vendorRef_lbl.Multiline = true;
            this.vendorRef_lbl.Name = "vendorRef_lbl";
            this.vendorRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.vendorRef_lbl.StylePriority.UseBackColor = false;
            this.vendorRef_lbl.StylePriority.UseBorders = false;
            this.vendorRef_lbl.StylePriority.UseFont = false;
            this.vendorRef_lbl.StylePriority.UsePadding = false;
            this.vendorRef_lbl.Text = "vendorRef_lbl";
            this.vendorRef_lbl.Weight = 0.66429131194483859D;
            // 
            // vendorRef_data
            // 
            this.vendorRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vendorRef_data.Multiline = true;
            this.vendorRef_data.Name = "vendorRef_data";
            this.vendorRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.vendorRef_data.StylePriority.UseBorders = false;
            this.vendorRef_data.StylePriority.UsePadding = false;
            this.vendorRef_data.Text = "vendorRef_data";
            this.vendorRef_data.Weight = 1.3357086880551612D;
            // 
            // plantName_lbl
            // 
            this.plantName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plantName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plantName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.plantName_lbl.Multiline = true;
            this.plantName_lbl.Name = "plantName_lbl";
            this.plantName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.plantName_lbl.StylePriority.UseBackColor = false;
            this.plantName_lbl.StylePriority.UseBorders = false;
            this.plantName_lbl.StylePriority.UseFont = false;
            this.plantName_lbl.StylePriority.UsePadding = false;
            this.plantName_lbl.Text = "plantName_lbl";
            this.plantName_lbl.Weight = 0.6642913269184807D;
            // 
            // plantName_data
            // 
            this.plantName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plantName_data.Multiline = true;
            this.plantName_data.Name = "plantName_data";
            this.plantName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.plantName_data.StylePriority.UseBorders = false;
            this.plantName_data.StylePriority.UsePadding = false;
            this.plantName_data.Text = "plantName_data";
            this.plantName_data.Weight = 1.3357086730815193D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorName_lbl,
            this.vendorName_data,
            this.pmName_lbl,
            this.pmName_data});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // vendorName_lbl
            // 
            this.vendorName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vendorName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vendorName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.vendorName_lbl.Multiline = true;
            this.vendorName_lbl.Name = "vendorName_lbl";
            this.vendorName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.vendorName_lbl.StylePriority.UseBackColor = false;
            this.vendorName_lbl.StylePriority.UseBorders = false;
            this.vendorName_lbl.StylePriority.UseFont = false;
            this.vendorName_lbl.StylePriority.UsePadding = false;
            this.vendorName_lbl.Text = "vendorName_lbl";
            this.vendorName_lbl.Weight = 0.66429131194482549D;
            // 
            // vendorName_data
            // 
            this.vendorName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.vendorName_data.Multiline = true;
            this.vendorName_data.Name = "vendorName_data";
            this.vendorName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.vendorName_data.StylePriority.UseBorders = false;
            this.vendorName_data.StylePriority.UsePadding = false;
            this.vendorName_data.Text = "vendorName_data";
            this.vendorName_data.Weight = 1.3357086880551747D;
            // 
            // pmName_lbl
            // 
            this.pmName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pmName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.pmName_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.pmName_lbl.Multiline = true;
            this.pmName_lbl.Name = "pmName_lbl";
            this.pmName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.pmName_lbl.StylePriority.UseBackColor = false;
            this.pmName_lbl.StylePriority.UseBorders = false;
            this.pmName_lbl.StylePriority.UseFont = false;
            this.pmName_lbl.StylePriority.UsePadding = false;
            this.pmName_lbl.Text = "pmName_lbl";
            this.pmName_lbl.Weight = 0.66429132691845438D;
            // 
            // pmName_data
            // 
            this.pmName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.pmName_data.Multiline = true;
            this.pmName_data.Name = "pmName_data";
            this.pmName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 7, 0, 100F);
            this.pmName_data.StylePriority.UseBorders = false;
            this.pmName_data.StylePriority.UsePadding = false;
            this.pmName_data.Text = "pmName_data";
            this.pmName_data.Weight = 1.3357086730815457D;
            // 
            // PU103GLD
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageFooter,
            this.ReportFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 36, 10);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRSubreport InvoiceItemsSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand InvoiceItemSubBand;
        private DevExpress.XtraReports.UI.XRTable xrTable8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell subtotal_lbl;
        private DevExpress.XtraReports.UI.XRTableCell subtotal_data;
        private DevExpress.XtraReports.UI.XRTable xrTable9;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vatAmount_data;
        private DevExpress.XtraReports.UI.XRTable xrTable10;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell amount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell amount_data;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel purchaseInvoice_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell description_lbl;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell dueDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell dueDate_data;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell dtName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell dtName_data;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableCell currencyName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell currencyName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell vendorRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vendorRef_data;
        private DevExpress.XtraReports.UI.XRTableCell plantName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plantName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell vendorName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell vendorName_data;
        private DevExpress.XtraReports.UI.XRTableCell pmName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell pmName_data;
    }
}
