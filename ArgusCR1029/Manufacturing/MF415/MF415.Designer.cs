
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing.MF415
{
    partial class MF415
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
            this.GeneralSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.GeneralSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SummarySubBand = new DevExpress.XtraReports.UI.SubBand();
            this.GrandTotalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.startDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.startDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.endDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.endDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCategory_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemGroup_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.productionLine_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.item_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.addressStreet_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressEmail_data = new DevExpress.XtraReports.UI.XRLabel();
            this.companyInfoName_data = new DevExpress.XtraReports.UI.XRLabel();
            this.taxNo_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressName_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressMobile_data = new DevExpress.XtraReports.UI.XRLabel();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.printSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // GeneralSubBand
            // 
            this.GeneralSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.GeneralSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.GeneralSubReports});
            this.GeneralSubBand.HeightF = 23F;
            this.GeneralSubBand.Name = "GeneralSubBand";
            // 
            // GeneralSubReports
            // 
            this.GeneralSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 0F);
            this.GeneralSubReports.Name = "GeneralSubReports";
            this.GeneralSubReports.ReportSource = new ArgusCR1029.Manufacturing.MF415.GeneralSubReports();
            this.GeneralSubReports.SizeF = new System.Drawing.SizeF(1250.523F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.GeneralSubBand,
            this.SummarySubBand});
            // 
            // SummarySubBand
            // 
            this.SummarySubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.GrandTotalSubReports});
            this.SummarySubBand.HeightF = 23F;
            this.SummarySubBand.Name = "SummarySubBand";
            // 
            // GrandTotalSubReports
            // 
            this.GrandTotalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 0F);
            this.GrandTotalSubReports.Name = "GrandTotalSubReports";
            this.GrandTotalSubReports.ReportSource = new ArgusCR1029.Manufacturing.MF415.GrandTotalSubReports();
            this.GrandTotalSubReports.SizeF = new System.Drawing.SizeF(1250.522F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10F;
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
            this.xrTable5,
            this.title_lbl,
            this.addressStreet_data,
            this.addressEmail_data,
            this.companyInfoName_data,
            this.taxNo_data,
            this.addressName_data,
            this.addressMobile_data,
            this.logo_data});
            this.ReportHeader.HeightF = 198.659F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(1003.19F, 37.66666F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow2,
            this.xrTableRow7});
            this.xrTable5.SizeF = new System.Drawing.SizeF(272.3333F, 135.9375F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.startDate_lbl,
            this.startDate_param});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // startDate_lbl
            // 
            this.startDate_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.startDate_lbl.Multiline = true;
            this.startDate_lbl.Name = "startDate_lbl";
            this.startDate_lbl.StylePriority.UseFont = false;
            this.startDate_lbl.Text = "Start Date:";
            this.startDate_lbl.Weight = 0.50416506401979622D;
            // 
            // startDate_param
            // 
            this.startDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.startDate_param.Multiline = true;
            this.startDate_param.Name = "startDate_param";
            this.startDate_param.StylePriority.UseFont = false;
            this.startDate_param.Weight = 1.0520250227637686D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.endDate_lbl,
            this.endDate_param});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.endDate_lbl.Multiline = true;
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.StylePriority.UseFont = false;
            this.endDate_lbl.Text = "End Date:";
            this.endDate_lbl.Weight = 0.50416506401979622D;
            // 
            // endDate_param
            // 
            this.endDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.endDate_param.Multiline = true;
            this.endDate_param.Name = "endDate_param";
            this.endDate_param.StylePriority.UseFont = false;
            this.endDate_param.Weight = 1.0520250227637686D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.itemCategory_param});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Item Category:";
            this.xrTableCell1.Weight = 0.50416506401979622D;
            // 
            // itemCategory_param
            // 
            this.itemCategory_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemCategory_param.Multiline = true;
            this.itemCategory_param.Name = "itemCategory_param";
            this.itemCategory_param.StylePriority.UseFont = false;
            this.itemCategory_param.Weight = 1.0520250227637686D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.itemGroup_param});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Item Group:";
            this.xrTableCell3.Weight = 0.50416506401979622D;
            // 
            // itemGroup_param
            // 
            this.itemGroup_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemGroup_param.Multiline = true;
            this.itemGroup_param.Name = "itemGroup_param";
            this.itemGroup_param.StylePriority.UseFont = false;
            this.itemGroup_param.Weight = 1.0520250227637686D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.productionLine_param});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Production Line:";
            this.xrTableCell2.Weight = 0.50416506401979622D;
            // 
            // productionLine_param
            // 
            this.productionLine_param.Font = new System.Drawing.Font("Arial", 8F);
            this.productionLine_param.Multiline = true;
            this.productionLine_param.Name = "productionLine_param";
            this.productionLine_param.StylePriority.UseFont = false;
            this.productionLine_param.Weight = 1.0520250227637686D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.item_param});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.Text = "Item:";
            this.xrTableCell7.Weight = 0.50416506401979611D;
            // 
            // item_param
            // 
            this.item_param.Font = new System.Drawing.Font("Arial", 8F);
            this.item_param.Multiline = true;
            this.item_param.Name = "item_param";
            this.item_param.StylePriority.UseFont = false;
            this.item_param.Weight = 1.0520250227637686D;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(345.1669F, 0.08331934F);
            this.title_lbl.Multiline = true;
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(953.833F, 37.58334F);
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "Detailed Production By Items";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // addressStreet_data
            // 
            this.addressStreet_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressStreet_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 56.49999F);
            this.addressStreet_data.Multiline = true;
            this.addressStreet_data.Name = "addressStreet_data";
            this.addressStreet_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.addressStreet_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83334F);
            this.addressStreet_data.StylePriority.UseFont = false;
            this.addressStreet_data.StylePriority.UseTextAlignment = false;
            this.addressStreet_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // addressEmail_data
            // 
            this.addressEmail_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressEmail_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 94.16664F);
            this.addressEmail_data.Multiline = true;
            this.addressEmail_data.Name = "addressEmail_data";
            this.addressEmail_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.addressEmail_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83335F);
            this.addressEmail_data.StylePriority.UseFont = false;
            this.addressEmail_data.StylePriority.UseTextAlignment = false;
            this.addressEmail_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // companyInfoName_data
            // 
            this.companyInfoName_data.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.companyInfoName_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 0F);
            this.companyInfoName_data.Multiline = true;
            this.companyInfoName_data.Name = "companyInfoName_data";
            this.companyInfoName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.companyInfoName_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83334F);
            this.companyInfoName_data.StylePriority.UseFont = false;
            this.companyInfoName_data.StylePriority.UseTextAlignment = false;
            this.companyInfoName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // taxNo_data
            // 
            this.taxNo_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.taxNo_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 18.83332F);
            this.taxNo_data.Multiline = true;
            this.taxNo_data.Name = "taxNo_data";
            this.taxNo_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.taxNo_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83334F);
            this.taxNo_data.StylePriority.UseFont = false;
            this.taxNo_data.StylePriority.UseTextAlignment = false;
            this.taxNo_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // addressName_data
            // 
            this.addressName_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressName_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 37.66666F);
            this.addressName_data.Multiline = true;
            this.addressName_data.Name = "addressName_data";
            this.addressName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.addressName_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83334F);
            this.addressName_data.StylePriority.UseFont = false;
            this.addressName_data.StylePriority.UseTextAlignment = false;
            this.addressName_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // addressMobile_data
            // 
            this.addressMobile_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressMobile_data.LocationFloat = new DevExpress.Utils.PointFloat(136.4586F, 75.33331F);
            this.addressMobile_data.Multiline = true;
            this.addressMobile_data.Name = "addressMobile_data";
            this.addressMobile_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.addressMobile_data.SizeF = new System.Drawing.SizeF(208.7082F, 18.83334F);
            this.addressMobile_data.StylePriority.UseFont = false;
            this.addressMobile_data.StylePriority.UseTextAlignment = false;
            this.addressMobile_data.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(25.00033F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(105.5832F, 113F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.Font = new System.Drawing.Font("Arial", 8F);
            this.pagesNumber_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(1157.291F, 10.00004F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(118.2314F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseFont = false;
            this.pagesNumber_lbl.StylePriority.UseForeColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // printSignature
            // 
            this.printSignature.Font = new System.Drawing.Font("Arial", 8F);
            this.printSignature.ForeColor = System.Drawing.Color.DimGray;
            this.printSignature.LocationFloat = new DevExpress.Utils.PointFloat(25.00033F, 10.00001F);
            this.printSignature.Multiline = true;
            this.printSignature.Name = "printSignature";
            this.printSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature.SizeF = new System.Drawing.SizeF(840.7535F, 23F);
            this.printSignature.StylePriority.UseFont = false;
            this.printSignature.StylePriority.UseForeColor = false;
            this.printSignature.StylePriority.UseTextAlignment = false;
            this.printSignature.Text = "printSignature";
            this.printSignature.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pagesNumber_lbl,
            this.printSignature});
            this.PageFooter.HeightF = 33.00004F;
            this.PageFooter.Name = "PageFooter";
            // 
            // MF415
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 10, 0);
            this.PageHeight = 827;
            this.PageWidth = 1299;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Plus;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand SummarySubBand;
        private DevExpress.XtraReports.UI.XRSubreport GeneralSubReports;
        private DevExpress.XtraReports.UI.XRSubreport GrandTotalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand GeneralSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel printSignature;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell startDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell startDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell endDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell endDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell itemCategory_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell itemGroup_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell productionLine_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell item_param;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
        private DevExpress.XtraReports.UI.XRLabel addressStreet_data;
        private DevExpress.XtraReports.UI.XRLabel addressEmail_data;
        private DevExpress.XtraReports.UI.XRLabel companyInfoName_data;
        private DevExpress.XtraReports.UI.XRLabel taxNo_data;
        private DevExpress.XtraReports.UI.XRLabel addressName_data;
        private DevExpress.XtraReports.UI.XRLabel addressMobile_data;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
    }
}
