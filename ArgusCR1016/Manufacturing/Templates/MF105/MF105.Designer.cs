
namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    partial class MF105
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
            this.IssueOfMaterialsSubReport = new DevExpress.XtraReports.UI.XRSubreport();
            this.OverheadsSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.CategorySubReport = new DevExpress.XtraReports.UI.XRSubreport();
            this.workSheet_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 38F;
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
            this.IssueOfMaterialsSubReport});
            this.IssueOfMaterialsSubBand.HeightF = 23F;
            this.IssueOfMaterialsSubBand.KeepTogether = true;
            this.IssueOfMaterialsSubBand.Name = "IssueOfMaterialsSubBand";
            // 
            // IssueOfMaterialsSubReport
            // 
            this.IssueOfMaterialsSubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.IssueOfMaterialsSubReport.Name = "IssueOfMaterialsSubReport";
            this.IssueOfMaterialsSubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF105.IssueOfMaterialsSubReport();
            this.IssueOfMaterialsSubReport.SizeF = new System.Drawing.SizeF(1138.083F, 23F);
            // 
            // OverheadsSubBand
            // 
            this.OverheadsSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CategorySubReport});
            this.OverheadsSubBand.HeightF = 23F;
            this.OverheadsSubBand.KeepTogether = true;
            this.OverheadsSubBand.Name = "OverheadsSubBand";
            // 
            // CategorySubReport
            // 
            this.CategorySubReport.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.CategorySubReport.Name = "CategorySubReport";
            this.CategorySubReport.ReportSource = new ArgusCR1016.Manufacturing.Templates.MF105.CategorySubReport();
            this.CategorySubReport.SizeF = new System.Drawing.SizeF(1138.083F, 23F);
            // 
            // workSheet_lbl
            // 
            this.workSheet_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.workSheet_lbl.LocationFloat = new DevExpress.Utils.PointFloat(849.1251F, 0F);
            this.workSheet_lbl.Multiline = true;
            this.workSheet_lbl.Name = "workSheet_lbl";
            this.workSheet_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.workSheet_lbl.SizeF = new System.Drawing.SizeF(298.9583F, 29.16667F);
            this.workSheet_lbl.StylePriority.UseFont = false;
            this.workSheet_lbl.StylePriority.UseTextAlignment = false;
            this.workSheet_lbl.Text = "WorkSheet";
            this.workSheet_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.printSignature_lbl,
            this.pagesNumber_lbl});
            this.PageFooter.HeightF = 39.16677F;
            this.PageFooter.Name = "PageFooter";
            // 
            // printSignature_lbl
            // 
            this.printSignature_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSignature_lbl.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 12.5F);
            this.printSignature_lbl.Multiline = true;
            this.printSignature_lbl.Name = "printSignature_lbl";
            this.printSignature_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature_lbl.SizeF = new System.Drawing.SizeF(676.2528F, 23.00002F);
            this.printSignature_lbl.StylePriority.UseFont = false;
            this.printSignature_lbl.StylePriority.UseTextAlignment = false;
            this.printSignature_lbl.Text = "printSignature";
            this.printSignature_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(1037.5F, 12.5F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(110.5834F, 23F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.workSheet_lbl});
            this.ReportHeader.HeightF = 109.4166F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // MF105
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageFooter,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 38, 10);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel workSheet_lbl;
        private DevExpress.XtraReports.UI.SubBand IssueOfMaterialsSubBand;
        private DevExpress.XtraReports.UI.SubBand OverheadsSubBand;
        private DevExpress.XtraReports.UI.XRSubreport CategorySubReport;
        private DevExpress.XtraReports.UI.XRSubreport IssueOfMaterialsSubReport;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature_lbl;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
