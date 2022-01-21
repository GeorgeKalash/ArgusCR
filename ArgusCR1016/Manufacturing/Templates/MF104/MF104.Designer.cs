
namespace ArgusCR1016.Manufacturing.Templates.MF104
{
    partial class MF104
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.IssueOfMaterialsSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.IssueOfMaterialsSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.OverheadsSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.OverheadsSubReport = new DevExpress.XtraReports.UI.XRSubreport();
            this.LaborTimeSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.LaborTimeSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.documentType_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.documentRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.jobOrderPricing_lbl = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25.20833F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 1.041667F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 24.79167F;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.IssueOfMaterialsSubBand,
            this.OverheadsSubBand,
            this.LaborTimeSubBand});
            // 
            // IssueOfMaterialsSubBand
            // 
            this.IssueOfMaterialsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.IssueOfMaterialsSubReports});
            this.IssueOfMaterialsSubBand.HeightF = 23F;
            this.IssueOfMaterialsSubBand.Name = "IssueOfMaterialsSubBand";
            // 
            // IssueOfMaterialsSubReports
            // 
            this.IssueOfMaterialsSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.IssueOfMaterialsSubReports.Name = "IssueOfMaterialsSubReports";
            this.IssueOfMaterialsSubReports.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF104.IssueOfMaterialsSubReports();
            this.IssueOfMaterialsSubReports.SizeF = new System.Drawing.SizeF(802.9166F, 23F);
            // 
            // OverheadsSubBand
            // 
            this.OverheadsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.OverheadsSubReport});
            this.OverheadsSubBand.HeightF = 23F;
            this.OverheadsSubBand.Name = "OverheadsSubBand";
            // 
            // OverheadsSubReport
            // 
            this.OverheadsSubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.OverheadsSubReport.Name = "OverheadsSubReport";
            this.OverheadsSubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF104.OverheadsSubReport();
            this.OverheadsSubReport.SizeF = new System.Drawing.SizeF(802.9166F, 23F);
            // 
            // LaborTimeSubBand
            // 
            this.LaborTimeSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.LaborTimeSubReports});
            this.LaborTimeSubBand.HeightF = 23F;
            this.LaborTimeSubBand.Name = "LaborTimeSubBand";
            // 
            // LaborTimeSubReports
            // 
            this.LaborTimeSubReports.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.LaborTimeSubReports.Name = "LaborTimeSubReports";
            this.LaborTimeSubReports.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF104.LaborTimeSubReports();
            this.LaborTimeSubReports.SizeF = new System.Drawing.SizeF(802.9166F, 23F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.jobOrderPricing_lbl});
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 10.00001F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(382.2916F, 62.49998F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.documentType_lbl,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // documentType_lbl
            // 
            this.documentType_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.documentType_lbl.Multiline = true;
            this.documentType_lbl.Name = "documentType_lbl";
            this.documentType_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.documentType_lbl.StylePriority.UseFont = false;
            this.documentType_lbl.StylePriority.UsePadding = false;
            this.documentType_lbl.Text = "Document Type:";
            this.documentType_lbl.Weight = 0.65122605439224857D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.Weight = 1.3487739456077514D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.documentRef_lbl,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // documentRef_lbl
            // 
            this.documentRef_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.documentRef_lbl.Multiline = true;
            this.documentRef_lbl.Name = "documentRef_lbl";
            this.documentRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.documentRef_lbl.StylePriority.UseFont = false;
            this.documentRef_lbl.StylePriority.UsePadding = false;
            this.documentRef_lbl.Text = "Document Ref:";
            this.documentRef_lbl.Weight = 0.65122605439224857D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Weight = 1.3487739456077514D;
            // 
            // jobOrderPricing_lbl
            // 
            this.jobOrderPricing_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.jobOrderPricing_lbl.LocationFloat = new DevExpress.Utils.PointFloat(513.9583F, 10.00001F);
            this.jobOrderPricing_lbl.Multiline = true;
            this.jobOrderPricing_lbl.Name = "jobOrderPricing_lbl";
            this.jobOrderPricing_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jobOrderPricing_lbl.SizeF = new System.Drawing.SizeF(298.9583F, 29.16667F);
            this.jobOrderPricing_lbl.StylePriority.UseFont = false;
            this.jobOrderPricing_lbl.StylePriority.UseTextAlignment = false;
            this.jobOrderPricing_lbl.Text = "Job Order for Pricing";
            this.jobOrderPricing_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // MF104
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 25, 1);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell documentType_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell documentRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRLabel jobOrderPricing_lbl;
        private DevExpress.XtraReports.UI.SubBand IssueOfMaterialsSubBand;
        private DevExpress.XtraReports.UI.SubBand OverheadsSubBand;
        private DevExpress.XtraReports.UI.SubBand LaborTimeSubBand;
        private DevExpress.XtraReports.UI.XRSubreport OverheadsSubReport;
        private DevExpress.XtraReports.UI.XRSubreport LaborTimeSubReports;
        private DevExpress.XtraReports.UI.XRSubreport IssueOfMaterialsSubReports;
    }
}
