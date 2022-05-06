
namespace ArgusCR1016.Manufacturing.Templates.MF105
{
    partial class CategorySubReport
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
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemCategoryRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCategoryName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.nbOfStones_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.weight_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[categoryRef]")});
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 2, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell5.Weight = 0.77490170294346772D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[categoryName]")});
            this.xrTableCell6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 2, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell6.Weight = 1.3431630082190369D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[pcs]")});
            this.xrTableCell7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 2, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.61992135065786491D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")});
            this.xrTableCell8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 2, 0, 100F);
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell8.TextFormatString = "{0:n2}";
            this.xrTableCell8.Weight = 0.61992135065786513D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 50F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 25F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemCategoryRef_lbl,
            this.itemCategoryName_lbl,
            this.nbOfStones_lbl,
            this.weight_lbl});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // itemCategoryRef_lbl
            // 
            this.itemCategoryRef_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemCategoryRef_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemCategoryRef_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.itemCategoryRef_lbl.Multiline = true;
            this.itemCategoryRef_lbl.Name = "itemCategoryRef_lbl";
            this.itemCategoryRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.itemCategoryRef_lbl.StylePriority.UseBackColor = false;
            this.itemCategoryRef_lbl.StylePriority.UseBorders = false;
            this.itemCategoryRef_lbl.StylePriority.UseFont = false;
            this.itemCategoryRef_lbl.StylePriority.UsePadding = false;
            this.itemCategoryRef_lbl.StylePriority.UseTextAlignment = false;
            this.itemCategoryRef_lbl.Text = "Item Category Ref.";
            this.itemCategoryRef_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemCategoryRef_lbl.Weight = 0.77490177159931106D;
            // 
            // itemCategoryName_lbl
            // 
            this.itemCategoryName_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemCategoryName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.itemCategoryName_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.itemCategoryName_lbl.Multiline = true;
            this.itemCategoryName_lbl.Name = "itemCategoryName_lbl";
            this.itemCategoryName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.itemCategoryName_lbl.StylePriority.UseBackColor = false;
            this.itemCategoryName_lbl.StylePriority.UseBorders = false;
            this.itemCategoryName_lbl.StylePriority.UseFont = false;
            this.itemCategoryName_lbl.StylePriority.UsePadding = false;
            this.itemCategoryName_lbl.StylePriority.UseTextAlignment = false;
            this.itemCategoryName_lbl.Text = "Item Category Name";
            this.itemCategoryName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.itemCategoryName_lbl.Weight = 1.3431630707721389D;
            // 
            // nbOfStones_lbl
            // 
            this.nbOfStones_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nbOfStones_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.nbOfStones_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.nbOfStones_lbl.Multiline = true;
            this.nbOfStones_lbl.Name = "nbOfStones_lbl";
            this.nbOfStones_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.nbOfStones_lbl.StylePriority.UseBackColor = false;
            this.nbOfStones_lbl.StylePriority.UseBorders = false;
            this.nbOfStones_lbl.StylePriority.UseFont = false;
            this.nbOfStones_lbl.StylePriority.UsePadding = false;
            this.nbOfStones_lbl.StylePriority.UseTextAlignment = false;
            this.nbOfStones_lbl.Text = "Nb. Of Stones";
            this.nbOfStones_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.nbOfStones_lbl.Weight = 0.61992141727944872D;
            // 
            // weight_lbl
            // 
            this.weight_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weight_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.weight_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.weight_lbl.Multiline = true;
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 4, 0, 100F);
            this.weight_lbl.StylePriority.UseBackColor = false;
            this.weight_lbl.StylePriority.UseBorders = false;
            this.weight_lbl.StylePriority.UseFont = false;
            this.weight_lbl.StylePriority.UsePadding = false;
            this.weight_lbl.StylePriority.UseTextAlignment = false;
            this.weight_lbl.Text = "Weight";
            this.weight_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.weight_lbl.Weight = 0.61992141727944872D;
            // 
            // CategorySubReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
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
        private DevExpress.XtraReports.UI.XRTableCell itemCategoryRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemCategoryName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell nbOfStones_lbl;
        private DevExpress.XtraReports.UI.XRTableCell weight_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
    }
}
