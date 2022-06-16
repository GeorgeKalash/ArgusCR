
namespace ArgusCR1006.POS.PS101
{
    partial class InvoiceReceiptSubReports
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
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.explanation_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.Amount_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.cardType_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.ccRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.typeName_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.currencyRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.cashAccountRef_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
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
            this.xrTable1});
            this.Detail.HeightF = 19.17F;
            this.Detail.Name = "Detail";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(549.96F, 19.17F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.White;
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell8.Weight = 1.5273971264299158D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.White;
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")});
            this.xrTableCell9.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell9.TextFormatString = "{0:n2}";
            this.xrTableCell9.Weight = 0.76369856511013035D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.White;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ccName]")});
            this.xrTableCell10.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell10.Weight = 1.0182647231827651D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.White;
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[receiptRef]")});
            this.xrTableCell11.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell11.Weight = 1.0182647615905947D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.White;
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[typeName]")});
            this.xrTableCell12.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "typeName";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell12.Weight = 1.0182647937416682D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.White;
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[currencyRef]")});
            this.xrTableCell13.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell13.Weight = 0.700057001500004D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.BackColor = System.Drawing.Color.White;
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cashAccountRef]")});
            this.xrTableCell14.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100F);
            this.xrTableCell14.StylePriority.UseBackColor = false;
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "cashAccountRef";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell14.Weight = 0.94189572159752888D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable8
            // 
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(549.96F, 25F);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.explanation_lbl,
            this.Amount_lbl,
            this.cardType_lbl,
            this.ccRef_lbl,
            this.typeName_lbl,
            this.currencyRef_lbl,
            this.cashAccountRef_lbl});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // explanation_lbl
            // 
            this.explanation_lbl.BackColor = System.Drawing.Color.White;
            this.explanation_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.explanation_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.explanation_lbl.Multiline = true;
            this.explanation_lbl.Name = "explanation_lbl";
            this.explanation_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.explanation_lbl.StylePriority.UseBackColor = false;
            this.explanation_lbl.StylePriority.UseBorders = false;
            this.explanation_lbl.StylePriority.UseFont = false;
            this.explanation_lbl.StylePriority.UsePadding = false;
            this.explanation_lbl.StylePriority.UseTextAlignment = false;
            this.explanation_lbl.Text = "الشرح";
            this.explanation_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.explanation_lbl.Weight = 1.5273972651202354D;
            // 
            // Amount_lbl
            // 
            this.Amount_lbl.BackColor = System.Drawing.Color.White;
            this.Amount_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Amount_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Amount_lbl.Multiline = true;
            this.Amount_lbl.Name = "Amount_lbl";
            this.Amount_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.Amount_lbl.StylePriority.UseBackColor = false;
            this.Amount_lbl.StylePriority.UseBorders = false;
            this.Amount_lbl.StylePriority.UseFont = false;
            this.Amount_lbl.StylePriority.UsePadding = false;
            this.Amount_lbl.StylePriority.UseTextAlignment = false;
            this.Amount_lbl.Text = "المبلغ";
            this.Amount_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Amount_lbl.Weight = 0.763698658957944D;
            // 
            // cardType_lbl
            // 
            this.cardType_lbl.BackColor = System.Drawing.Color.White;
            this.cardType_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cardType_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cardType_lbl.Multiline = true;
            this.cardType_lbl.Name = "cardType_lbl";
            this.cardType_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.cardType_lbl.StylePriority.UseBackColor = false;
            this.cardType_lbl.StylePriority.UseBorders = false;
            this.cardType_lbl.StylePriority.UseFont = false;
            this.cardType_lbl.StylePriority.UsePadding = false;
            this.cardType_lbl.StylePriority.UseTextAlignment = false;
            this.cardType_lbl.Text = "نوع البطاقة";
            this.cardType_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.cardType_lbl.Weight = 1.0182648773846252D;
            // 
            // ccRef_lbl
            // 
            this.ccRef_lbl.BackColor = System.Drawing.Color.White;
            this.ccRef_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ccRef_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.ccRef_lbl.Multiline = true;
            this.ccRef_lbl.Name = "ccRef_lbl";
            this.ccRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.ccRef_lbl.StylePriority.UseBackColor = false;
            this.ccRef_lbl.StylePriority.UseBorders = false;
            this.ccRef_lbl.StylePriority.UseFont = false;
            this.ccRef_lbl.StylePriority.UsePadding = false;
            this.ccRef_lbl.StylePriority.UseTextAlignment = false;
            this.ccRef_lbl.Text = "رقم الشيك \\ البطاقة";
            this.ccRef_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.ccRef_lbl.Weight = 1.0182652785877047D;
            // 
            // typeName_lbl
            // 
            this.typeName_lbl.BackColor = System.Drawing.Color.White;
            this.typeName_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.typeName_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.typeName_lbl.Multiline = true;
            this.typeName_lbl.Name = "typeName_lbl";
            this.typeName_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.typeName_lbl.StylePriority.UseBackColor = false;
            this.typeName_lbl.StylePriority.UseBorders = false;
            this.typeName_lbl.StylePriority.UseFont = false;
            this.typeName_lbl.StylePriority.UsePadding = false;
            this.typeName_lbl.StylePriority.UseTextAlignment = false;
            this.typeName_lbl.Text = "طريقة الدفع";
            this.typeName_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.typeName_lbl.Weight = 1.0182644832233507D;
            // 
            // currencyRef_lbl
            // 
            this.currencyRef_lbl.BackColor = System.Drawing.Color.White;
            this.currencyRef_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.currencyRef_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyRef_lbl.Multiline = true;
            this.currencyRef_lbl.Name = "currencyRef_lbl";
            this.currencyRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.currencyRef_lbl.StylePriority.UseBackColor = false;
            this.currencyRef_lbl.StylePriority.UseBorders = false;
            this.currencyRef_lbl.StylePriority.UseFont = false;
            this.currencyRef_lbl.StylePriority.UsePadding = false;
            this.currencyRef_lbl.StylePriority.UseTextAlignment = false;
            this.currencyRef_lbl.Text = "رمز العملة";
            this.currencyRef_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.currencyRef_lbl.Weight = 0.70005709314564779D;
            // 
            // cashAccountRef_lbl
            // 
            this.cashAccountRef_lbl.BackColor = System.Drawing.Color.White;
            this.cashAccountRef_lbl.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cashAccountRef_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashAccountRef_lbl.Multiline = true;
            this.cashAccountRef_lbl.Name = "cashAccountRef_lbl";
            this.cashAccountRef_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.cashAccountRef_lbl.StylePriority.UseBackColor = false;
            this.cashAccountRef_lbl.StylePriority.UseBorders = false;
            this.cashAccountRef_lbl.StylePriority.UseFont = false;
            this.cashAccountRef_lbl.StylePriority.UsePadding = false;
            this.cashAccountRef_lbl.StylePriority.UseTextAlignment = false;
            this.cashAccountRef_lbl.Text = "رمز الصندوق";
            this.cashAccountRef_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.cashAccountRef_lbl.Weight = 0.94189503538385633D;
            // 
            // InvoiceReceiptSubReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 271, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTable xrTable8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell explanation_lbl;
        private DevExpress.XtraReports.UI.XRTableCell Amount_lbl;
        private DevExpress.XtraReports.UI.XRTableCell cardType_lbl;
        private DevExpress.XtraReports.UI.XRTableCell ccRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell typeName_lbl;
        private DevExpress.XtraReports.UI.XRTableCell currencyRef_lbl;
        private DevExpress.XtraReports.UI.XRTableCell cashAccountRef_lbl;
    }
}
