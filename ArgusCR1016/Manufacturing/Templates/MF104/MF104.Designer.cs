
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
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.documentType_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.dtName_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.documentRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_data = new DevExpress.XtraReports.UI.XRTableCell();
            this.jobOrderPricing_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // Detail
            // 
            this.Detail.HeightF = 24.79167F;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.IssueOfMaterialsSubBand,
            this.OverheadsSubBand});
            // 
            // IssueOfMaterialsSubBand
            // 
            this.IssueOfMaterialsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.IssueOfMaterialsSubReports});
            this.IssueOfMaterialsSubBand.HeightF = 23F;
            this.IssueOfMaterialsSubBand.KeepTogether = true;
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
            this.OverheadsSubBand.KeepTogether = true;
            this.OverheadsSubBand.Name = "OverheadsSubBand";
            // 
            // OverheadsSubReport
            // 
            this.OverheadsSubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.OverheadsSubReport.Name = "OverheadsSubReport";
            this.OverheadsSubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF104.OverheadsSubReport();
            this.OverheadsSubReport.SizeF = new System.Drawing.SizeF(802.9166F, 23F);
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 37.5F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(382.2916F, 53.12498F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.documentType_lbl,
            this.dtName_data});
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
            this.documentType_lbl.Weight = 0.58583094684356007D;
            // 
            // dtName_data
            // 
            this.dtName_data.Multiline = true;
            this.dtName_data.Name = "dtName_data";
            this.dtName_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.dtName_data.StylePriority.UsePadding = false;
            this.dtName_data.Text = "dtName_data";
            this.dtName_data.Weight = 1.41416905315644D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.documentRef_lbl,
            this.reference_data});
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
            this.documentRef_lbl.Weight = 0.58583094684356007D;
            // 
            // reference_data
            // 
            this.reference_data.Multiline = true;
            this.reference_data.Name = "reference_data";
            this.reference_data.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.reference_data.StylePriority.UsePadding = false;
            this.reference_data.Text = "reference_data\r\n";
            this.reference_data.Weight = 1.41416905315644D;
            // 
            // jobOrderPricing_lbl
            // 
            this.jobOrderPricing_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.jobOrderPricing_lbl.LocationFloat = new DevExpress.Utils.PointFloat(513.9584F, 0F);
            this.jobOrderPricing_lbl.Multiline = true;
            this.jobOrderPricing_lbl.Name = "jobOrderPricing_lbl";
            this.jobOrderPricing_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.jobOrderPricing_lbl.SizeF = new System.Drawing.SizeF(298.9583F, 29.16667F);
            this.jobOrderPricing_lbl.StylePriority.UseFont = false;
            this.jobOrderPricing_lbl.StylePriority.UseTextAlignment = false;
            this.jobOrderPricing_lbl.Text = "Job Order for Pricing";
            this.jobOrderPricing_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.printSignature_lbl,
            this.pagesNumber_lbl});
            this.PageFooter.HeightF = 33.00003F;
            this.PageFooter.Name = "PageFooter";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 10.00001F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(490.4195F, 23.00002F);
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(704.1667F, 10.00001F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(108.7499F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.jobOrderPricing_lbl,
            this.xrTable1});
            this.ReportHeader.HeightF = 90.62498F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            // 
            // MF104
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageFooter,
            this.ReportHeader,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 30, 10);
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
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell documentType_lbl;
        private DevExpress.XtraReports.UI.XRTableCell dtName_data;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell documentRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_data;
        private DevExpress.XtraReports.UI.XRLabel jobOrderPricing_lbl;
        private DevExpress.XtraReports.UI.SubBand IssueOfMaterialsSubBand;
        private DevExpress.XtraReports.UI.SubBand OverheadsSubBand;
        private DevExpress.XtraReports.UI.XRSubreport OverheadsSubReport;
        private DevExpress.XtraReports.UI.XRSubreport IssueOfMaterialsSubReports;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    }
}
