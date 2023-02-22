
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Financials.FI104
{
    partial class FI104
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
            this.ItemSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.ItemsSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.InvoiceReceiptSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable16 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.metalTransactions_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable17 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.dtName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.function_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.function_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.date_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.date_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plant_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plantRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.plantName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.site_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.siteRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.siteName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.account_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.accountRef_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.accountName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.description_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.companyInfoName_data = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ItemSubBand
            // 
            this.ItemSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.ItemSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ItemsSubReports});
            this.ItemSubBand.HeightF = 23F;
            this.ItemSubBand.KeepTogether = true;
            this.ItemSubBand.Name = "ItemSubBand";
            // 
            // ItemsSubReports
            // 
            this.ItemsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.ItemsSubReports.Name = "ItemsSubReports";
            this.ItemsSubReports.ReportSource = new ArgusCR1029.Financials.FI104.ItemsSubReports();
            this.ItemsSubReports.SizeF = new System.Drawing.SizeF(806.9999F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ItemSubBand,
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
            this.MetalSubReports.ReportSource = new ArgusCR1029.Financials.FI104.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(806.9999F, 23F);
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
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.logo_data,
            this.companyInfoName_data,
            this.xrTable16,
            this.xrTable17,
            this.xrTable1});
            this.ReportHeader.HeightF = 309.1309F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable16
            // 
            this.xrTable16.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 132.9167F);
            this.xrTable16.Name = "xrTable16";
            this.xrTable16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
            this.xrTable16.SizeF = new System.Drawing.SizeF(807F, 36.45833F);
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.metalTransactions_lbl});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // metalTransactions_lbl
            // 
            this.metalTransactions_lbl.BackColor = System.Drawing.Color.Black;
            this.metalTransactions_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.metalTransactions_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.metalTransactions_lbl.ForeColor = System.Drawing.Color.White;
            this.metalTransactions_lbl.Multiline = true;
            this.metalTransactions_lbl.Name = "metalTransactions_lbl";
            this.metalTransactions_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 6, 0, 100F);
            this.metalTransactions_lbl.StylePriority.UseBackColor = false;
            this.metalTransactions_lbl.StylePriority.UseBorders = false;
            this.metalTransactions_lbl.StylePriority.UseFont = false;
            this.metalTransactions_lbl.StylePriority.UseForeColor = false;
            this.metalTransactions_lbl.StylePriority.UsePadding = false;
            this.metalTransactions_lbl.StylePriority.UseTextAlignment = false;
            this.metalTransactions_lbl.Text = "Metal Transactions";
            this.metalTransactions_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.metalTransactions_lbl.Weight = 1D;
            // 
            // xrTable17
            // 
            this.xrTable17.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable17.BorderWidth = 0.5F;
            this.xrTable17.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 169.375F);
            this.xrTable17.Name = "xrTable17";
            this.xrTable17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow17,
            this.xrTableRow4,
            this.xrTableRow20,
            this.xrTableRow21});
            this.xrTable17.SizeF = new System.Drawing.SizeF(324.2563F, 110.8335F);
            this.xrTable17.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.dtName_lbl,
            this.dtName_data});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // dtName_lbl
            // 
            this.dtName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_lbl.CanGrow = false;
            this.dtName_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtName_lbl.Multiline = true;
            this.dtName_lbl.Name = "dtName_lbl";
            this.dtName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.dtName_lbl.StylePriority.UseBackColor = false;
            this.dtName_lbl.StylePriority.UseBorders = false;
            this.dtName_lbl.StylePriority.UseFont = false;
            this.dtName_lbl.StylePriority.UsePadding = false;
            this.dtName_lbl.Text = "Document Type:";
            this.dtName_lbl.Weight = 0.776253436942312D;
            // 
            // dtName_data
            // 
            this.dtName_data.BackColor = System.Drawing.Color.White;
            this.dtName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dtName_data.CanGrow = false;
            this.dtName_data.Multiline = true;
            this.dtName_data.Name = "dtName_data";
            this.dtName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.dtName_data.StylePriority.UseBackColor = false;
            this.dtName_data.StylePriority.UseBorders = false;
            this.dtName_data.StylePriority.UsePadding = false;
            this.dtName_data.Weight = 1.2321042476962258D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.function_lbl,
            this.function_data});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // function_lbl
            // 
            this.function_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.function_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.function_lbl.CanGrow = false;
            this.function_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.function_lbl.Multiline = true;
            this.function_lbl.Name = "function_lbl";
            this.function_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.function_lbl.StylePriority.UseBackColor = false;
            this.function_lbl.StylePriority.UseBorders = false;
            this.function_lbl.StylePriority.UseFont = false;
            this.function_lbl.StylePriority.UsePadding = false;
            this.function_lbl.Text = "Function:";
            this.function_lbl.Weight = 0.77625353637014349D;
            // 
            // function_data
            // 
            this.function_data.BackColor = System.Drawing.Color.White;
            this.function_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.function_data.CanGrow = false;
            this.function_data.Multiline = true;
            this.function_data.Name = "function_data";
            this.function_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.function_data.StylePriority.UseBackColor = false;
            this.function_data.StylePriority.UseBorders = false;
            this.function_data.StylePriority.UsePadding = false;
            this.function_data.Weight = 1.2321041482683943D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_data});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reference_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_lbl.CanGrow = false;
            this.reference_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.reference_lbl.StylePriority.UseBackColor = false;
            this.reference_lbl.StylePriority.UseBorders = false;
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.StylePriority.UsePadding = false;
            this.reference_lbl.Text = "Reference:";
            this.reference_lbl.Weight = 0.7762535363701436D;
            // 
            // reference_data
            // 
            this.reference_data.BackColor = System.Drawing.Color.White;
            this.reference_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reference_data.CanGrow = false;
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.reference_data.StylePriority.UseBackColor = false;
            this.reference_data.StylePriority.UseBorders = false;
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.Weight = 1.2321041482683943D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.date_lbl,
            this.date_data});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_lbl.CanGrow = false;
            this.date_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_lbl.Multiline = true;
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.date_lbl.StylePriority.UseBackColor = false;
            this.date_lbl.StylePriority.UseBorders = false;
            this.date_lbl.StylePriority.UseFont = false;
            this.date_lbl.StylePriority.UsePadding = false;
            this.date_lbl.Text = "Date:";
            this.date_lbl.Weight = 0.77625353637014349D;
            // 
            // date_data
            // 
            this.date_data.BackColor = System.Drawing.Color.White;
            this.date_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.date_data.CanGrow = false;
            this.date_data.Multiline = true;
            this.date_data.Name = "date_data";
            this.date_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.date_data.StylePriority.UseBackColor = false;
            this.date_data.StylePriority.UseBorders = false;
            this.date_data.StylePriority.UsePadding = false;
            this.date_data.Weight = 1.2321041482683943D;
            // 
            // xrTable1
            // 
            this.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable1.BorderWidth = 0.5F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(334.2562F, 169.375F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(482.7438F, 110.8335F);
            this.xrTable1.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plant_lbl,
            this.plantRef_data,
            this.plantName_data});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // plant_lbl
            // 
            this.plant_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plant_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plant_lbl.CanGrow = false;
            this.plant_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.plant_lbl.Multiline = true;
            this.plant_lbl.Name = "plant_lbl";
            this.plant_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.plant_lbl.StylePriority.UseBackColor = false;
            this.plant_lbl.StylePriority.UseBorders = false;
            this.plant_lbl.StylePriority.UseFont = false;
            this.plant_lbl.StylePriority.UsePadding = false;
            this.plant_lbl.Text = "Plant:";
            this.plant_lbl.Weight = 0.57669786170227766D;
            // 
            // plantRef_data
            // 
            this.plantRef_data.BackColor = System.Drawing.Color.White;
            this.plantRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plantRef_data.CanGrow = false;
            this.plantRef_data.Multiline = true;
            this.plantRef_data.Name = "plantRef_data";
            this.plantRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.plantRef_data.StylePriority.UseBackColor = false;
            this.plantRef_data.StylePriority.UseBorders = false;
            this.plantRef_data.StylePriority.UsePadding = false;
            this.plantRef_data.Weight = 0.90222642616737669D;
            // 
            // plantName_data
            // 
            this.plantName_data.BackColor = System.Drawing.Color.White;
            this.plantName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.plantName_data.CanGrow = false;
            this.plantName_data.Multiline = true;
            this.plantName_data.Name = "plantName_data";
            this.plantName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.plantName_data.StylePriority.UseBackColor = false;
            this.plantName_data.StylePriority.UseBorders = false;
            this.plantName_data.StylePriority.UsePadding = false;
            this.plantName_data.Weight = 1.561149157301051D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.site_lbl,
            this.siteRef_data,
            this.siteName_data});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // site_lbl
            // 
            this.site_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.site_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.site_lbl.CanGrow = false;
            this.site_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.site_lbl.Multiline = true;
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.site_lbl.StylePriority.UseBackColor = false;
            this.site_lbl.StylePriority.UseBorders = false;
            this.site_lbl.StylePriority.UseFont = false;
            this.site_lbl.StylePriority.UsePadding = false;
            this.site_lbl.Text = "Site:";
            this.site_lbl.Weight = 0.57669795284106584D;
            // 
            // siteRef_data
            // 
            this.siteRef_data.BackColor = System.Drawing.Color.White;
            this.siteRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.siteRef_data.CanGrow = false;
            this.siteRef_data.Multiline = true;
            this.siteRef_data.Name = "siteRef_data";
            this.siteRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.siteRef_data.StylePriority.UseBackColor = false;
            this.siteRef_data.StylePriority.UseBorders = false;
            this.siteRef_data.StylePriority.UsePadding = false;
            this.siteRef_data.Weight = 0.90222681558965578D;
            // 
            // siteName_data
            // 
            this.siteName_data.BackColor = System.Drawing.Color.White;
            this.siteName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.siteName_data.CanGrow = false;
            this.siteName_data.Multiline = true;
            this.siteName_data.Name = "siteName_data";
            this.siteName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.siteName_data.StylePriority.UseBackColor = false;
            this.siteName_data.StylePriority.UseBorders = false;
            this.siteName_data.StylePriority.UsePadding = false;
            this.siteName_data.Weight = 1.5611487719334545D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.account_lbl,
            this.accountRef_data,
            this.accountName_data});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // account_lbl
            // 
            this.account_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.account_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.account_lbl.CanGrow = false;
            this.account_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.account_lbl.Multiline = true;
            this.account_lbl.Name = "account_lbl";
            this.account_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.account_lbl.StylePriority.UseBackColor = false;
            this.account_lbl.StylePriority.UseBorders = false;
            this.account_lbl.StylePriority.UseFont = false;
            this.account_lbl.StylePriority.UsePadding = false;
            this.account_lbl.Text = "Account:";
            this.account_lbl.Weight = 0.57669806055793327D;
            // 
            // accountRef_data
            // 
            this.accountRef_data.BackColor = System.Drawing.Color.White;
            this.accountRef_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.accountRef_data.CanGrow = false;
            this.accountRef_data.Multiline = true;
            this.accountRef_data.Name = "accountRef_data";
            this.accountRef_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.accountRef_data.StylePriority.UseBackColor = false;
            this.accountRef_data.StylePriority.UseBorders = false;
            this.accountRef_data.StylePriority.UsePadding = false;
            this.accountRef_data.Weight = 0.9022262273117212D;
            // 
            // accountName_data
            // 
            this.accountName_data.BackColor = System.Drawing.Color.White;
            this.accountName_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.accountName_data.CanGrow = false;
            this.accountName_data.Multiline = true;
            this.accountName_data.Name = "accountName_data";
            this.accountName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.accountName_data.StylePriority.UseBackColor = false;
            this.accountName_data.StylePriority.UseBorders = false;
            this.accountName_data.StylePriority.UsePadding = false;
            this.accountName_data.Weight = 1.561149157301051D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_lbl,
            this.description_data});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.description_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.description_lbl.CanGrow = false;
            this.description_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.description_lbl.StylePriority.UseBackColor = false;
            this.description_lbl.StylePriority.UseBorders = false;
            this.description_lbl.StylePriority.UseFont = false;
            this.description_lbl.StylePriority.UsePadding = false;
            this.description_lbl.Text = "Description:";
            this.description_lbl.Weight = 0.57669806055793327D;
            // 
            // description_data
            // 
            this.description_data.BackColor = System.Drawing.Color.White;
            this.description_data.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.description_data.CanGrow = false;
            this.description_data.Multiline = true;
            this.description_data.Name = "description_data";
            this.description_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 4, 0, 100F);
            this.description_data.StylePriority.UseBackColor = false;
            this.description_data.StylePriority.UseBorders = false;
            this.description_data.StylePriority.UsePadding = false;
            this.description_data.Weight = 2.4633753846127719D;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 3.178914E-05F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(105.5832F, 113F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // companyInfoName_data
            // 
            this.companyInfoName_data.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.companyInfoName_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 3.178914E-05F);
            this.companyInfoName_data.Multiline = true;
            this.companyInfoName_data.Name = "companyInfoName_data";
            this.companyInfoName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.companyInfoName_data.SizeF = new System.Drawing.SizeF(320.1666F, 30.29167F);
            this.companyInfoName_data.StylePriority.UseFont = false;
            this.companyInfoName_data.StylePriority.UseTextAlignment = false;
            this.companyInfoName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pagesNumber_lbl,
            this.printSignature});
            this.PageFooter.HeightF = 32.99997F;
            this.PageFooter.Name = "PageFooter";
            // 
            // printSignature
            // 
            this.printSignature.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 9.999974F);
            this.printSignature.Multiline = true;
            this.printSignature.Name = "printSignature";
            this.printSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature.SizeF = new System.Drawing.SizeF(603.0455F, 23F);
            this.printSignature.StylePriority.UseTextAlignment = false;
            this.printSignature.Text = "printSignature";
            this.printSignature.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(711.825F, 9.999974F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(105.1749F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // FI104
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 30, 10);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand InvoiceReceiptSubBand;
        private DevExpress.XtraReports.UI.XRSubreport ItemsSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand ItemSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable16;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell metalTransactions_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable17;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell dtName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell dtName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell function_lbl;
        private DevExpress.XtraReports.UI.XRTableCell function_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow20;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow21;
        private DevExpress.XtraReports.UI.XRTableCell date_lbl;
        private DevExpress.XtraReports.UI.XRTableCell date_data;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell plant_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plantRef_data;
        private DevExpress.XtraReports.UI.XRTableCell plantName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell site_lbl;
        private DevExpress.XtraReports.UI.XRTableCell siteRef_data;
        private DevExpress.XtraReports.UI.XRTableCell siteName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell account_lbl;
        private DevExpress.XtraReports.UI.XRTableCell accountRef_data;
        private DevExpress.XtraReports.UI.XRTableCell accountName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell description_lbl;
        private DevExpress.XtraReports.UI.XRTableCell description_data;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRLabel companyInfoName_data;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel printSignature;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
    }
}
