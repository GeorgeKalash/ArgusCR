
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Manufacturing.MF428
{
    partial class MF428
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SummarySubBand = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.startDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.startDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.endDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.endDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.item_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.workCenter_param = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.sku_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.endDate2_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GeneralSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.MetalSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
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
            this.MetalSubReports});
            this.SummarySubBand.HeightF = 23F;
            this.SummarySubBand.Name = "SummarySubBand";
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
            this.ReportHeader.HeightF = 135.9761F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(862.5F, 50F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow7,
            this.xrTableRow9});
            this.xrTable5.SizeF = new System.Drawing.SizeF(282.2917F, 64.44641F);
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
            this.startDate_lbl.Text = "تاريخ البدء";
            this.startDate_lbl.Weight = 0.45253756424627994D;
            // 
            // startDate_param
            // 
            this.startDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.startDate_param.Multiline = true;
            this.startDate_param.Name = "startDate_param";
            this.startDate_param.StylePriority.UseFont = false;
            this.startDate_param.Weight = 1.1653730944472054D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.endDate_lbl,
            this.endDate_param});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.endDate_lbl.Multiline = true;
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.StylePriority.UseFont = false;
            this.endDate_lbl.Text = "تاريخ الانتهاء";
            this.endDate_lbl.Weight = 0.45253756424628D;
            // 
            // endDate_param
            // 
            this.endDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.endDate_param.Multiline = true;
            this.endDate_param.Name = "endDate_param";
            this.endDate_param.StylePriority.UseFont = false;
            this.endDate_param.Weight = 1.1653730944472052D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.item_lbl,
            this.workCenter_param});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // item_lbl
            // 
            this.item_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.item_lbl.Multiline = true;
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.StylePriority.UseFont = false;
            this.item_lbl.Text = "مركز العمل";
            this.item_lbl.Weight = 0.45253756424628D;
            // 
            // workCenter_param
            // 
            this.workCenter_param.Font = new System.Drawing.Font("Arial", 8F);
            this.workCenter_param.Multiline = true;
            this.workCenter_param.Name = "workCenter_param";
            this.workCenter_param.StylePriority.UseFont = false;
            this.workCenter_param.Weight = 1.1653730944472052D;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(330.1665F, 0F);
            this.title_lbl.Multiline = true;
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(838.8335F, 39.66666F);
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "تقرير الانتاج واستلام الباركود بخطوط الانتاج";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // addressStreet_data
            // 
            this.addressStreet_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressStreet_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 56.49999F);
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
            this.addressEmail_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 94.16668F);
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
            this.companyInfoName_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 0F);
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
            this.taxNo_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 18.83334F);
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
            this.addressName_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 37.66667F);
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
            this.addressMobile_data.LocationFloat = new DevExpress.Utils.PointFloat(121.4583F, 75.33334F);
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
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(105.5832F, 113F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.Font = new System.Drawing.Font("Arial", 8F);
            this.pagesNumber_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(1028.125F, 10.00001F);
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
            this.PageFooter.HeightF = 33.00001F;
            this.PageFooter.Name = "PageFooter";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.PageHeader.HeightF = 24.58296F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(25.00041F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1121.356F, 24.58296F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UsePadding = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.sku_lbl,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.endDate2_param,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // sku_lbl
            // 
            this.sku_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.sku_lbl.Multiline = true;
            this.sku_lbl.Name = "sku_lbl";
            this.sku_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.sku_lbl.StylePriority.UseFont = false;
            this.sku_lbl.StylePriority.UsePadding = false;
            this.sku_lbl.Text = "خط الانتاج";
            this.sku_lbl.Weight = 1.6707329518189109D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "العيار";
            this.xrTableCell1.Weight = 0.64079227456004151D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.Text = "انتاج الجوبات المرحلة";
            this.xrTableCell2.Weight = 0.64079227456004173D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.Text = " الجوبات الغير مرحلة";
            this.xrTableCell3.Weight = 0.64079227456004151D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Text = "الجوبات المنقولة ولم تستلم";
            this.xrTableCell4.Weight = 0.64079227456004162D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.Text = "اجمالى الانتاج";
            this.xrTableCell5.Weight = 0.64079227456004162D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.Text = "نسبة الانتاج";
            this.xrTableCell6.Weight = 0.6407922745600414D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "الانتاج يوم";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.56403087071021207D;
            // 
            // endDate2_param
            // 
            this.endDate2_param.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.endDate2_param.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.endDate2_param.Multiline = true;
            this.endDate2_param.Name = "endDate2_param";
            this.endDate2_param.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.endDate2_param.StylePriority.UseBorders = false;
            this.endDate2_param.StylePriority.UseFont = false;
            this.endDate2_param.StylePriority.UsePadding = false;
            this.endDate2_param.StylePriority.UseTextAlignment = false;
            this.endDate2_param.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.endDate2_param.Weight = 0.64079228474516081D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.Text = "انتاج اليوم المنتظر للتكويد";
            this.xrTableCell8.Weight = 0.64079227456004173D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.Text = "الاضافات فى الجوبات المنتظرة للتكويد";
            this.xrTableCell9.Weight = 0.64079227456004151D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.Text = "اجمالى الاضافات للجوبات المنتهية";
            this.xrTableCell10.Weight = 0.64079227456004151D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.Text = "نسبه الإضافات";
            this.xrTableCell11.Weight = 0.64079282455648D;
            // 
            // GeneralSubReports
            // 
            this.GeneralSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 0F);
            this.GeneralSubReports.Name = "GeneralSubReports";
            this.GeneralSubReports.ReportSource = new ArgusCR1029.Manufacturing.MF428.GeneralSubReports();
            this.GeneralSubReports.SizeF = new System.Drawing.SizeF(1121.356F, 23F);
            // 
            // MetalSubReports
            // 
            this.MetalSubReports.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 0F);
            this.MetalSubReports.Name = "MetalSubReports";
            this.MetalSubReports.ReportSource = new ArgusCR1029.Manufacturing.MF428.MetalSubReports();
            this.MetalSubReports.SizeF = new System.Drawing.SizeF(1121.356F, 23F);
            // 
            // MF428
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 10, 0);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand SummarySubBand;
        private DevExpress.XtraReports.UI.XRSubreport GeneralSubReports;
        private DevExpress.XtraReports.UI.XRSubreport MetalSubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand GeneralSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel printSignature;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel addressStreet_data;
        private DevExpress.XtraReports.UI.XRLabel addressEmail_data;
        private DevExpress.XtraReports.UI.XRLabel companyInfoName_data;
        private DevExpress.XtraReports.UI.XRLabel taxNo_data;
        private DevExpress.XtraReports.UI.XRLabel addressName_data;
        private DevExpress.XtraReports.UI.XRLabel addressMobile_data;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell startDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell startDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell endDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell endDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell item_lbl;
        private DevExpress.XtraReports.UI.XRTableCell workCenter_param;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell sku_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell endDate2_param;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
    }
}
