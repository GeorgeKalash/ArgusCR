
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales.SA416b
{
    partial class SA416b
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
            this.DetailSubBand = new DevExpress.XtraReports.UI.SubBand();
            this.DetailSubReports = new DevExpress.XtraReports.UI.XRSubreport();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SummarySubBand = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.startDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.startDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.endDate_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.endDate_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemCategory_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCategory_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemGroup_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemGroup_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.item_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.item_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.client_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.client_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plant_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plant_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.systemFunction_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.systemFunction_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.docType_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.docType_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientGrp_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientGrp_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.salesPerson_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.salesPerson_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.reference_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.reference_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemCollection_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCollection_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productionLine_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.productionLine_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            this.SummarySubReports = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DetailSubBand
            // 
            this.DetailSubBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDotDot;
            this.DetailSubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.DetailSubReports});
            this.DetailSubBand.HeightF = 23F;
            this.DetailSubBand.Name = "DetailSubBand";
            // 
            // DetailSubReports
            // 
            this.DetailSubReports.LocationFloat = new DevExpress.Utils.PointFloat(24.58334F, 0F);
            this.DetailSubReports.Name = "DetailSubReports";
            this.DetailSubReports.ReportSource = new ArgusCR1029.Sales.SA416b.DetailSubReports();
            this.DetailSubReports.SizeF = new System.Drawing.SizeF(1252.833F, 23F);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.DetailSubBand,
            this.SummarySubBand});
            // 
            // SummarySubBand
            // 
            this.SummarySubBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.SummarySubReports});
            this.SummarySubBand.HeightF = 41.33324F;
            this.SummarySubBand.Name = "SummarySubBand";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 13.33334F;
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
            this.title_lbl,
            this.logo_data,
            this.xrTable5,
            this.xrTable1});
            this.ReportHeader.HeightF = 224.9168F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(219.3123F, 0F);
            this.title_lbl.Multiline = true;
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(1079.688F, 39.66666F);
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "Detailed Sales Costs By Item";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // logo_data
            // 
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(12.49976F, 0F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(206.8123F, 113F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(238.5417F, 50F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow1});
            this.xrTable5.SizeF = new System.Drawing.SizeF(301.2544F, 145.2014F);
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
            this.startDate_lbl.Weight = 0.50430701687612911D;
            // 
            // startDate_param
            // 
            this.startDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.startDate_param.Multiline = true;
            this.startDate_param.Name = "startDate_param";
            this.startDate_param.StylePriority.UseFont = false;
            this.startDate_param.Weight = 1.2347443593502792D;
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
            this.endDate_lbl.Weight = 0.50430701687612911D;
            // 
            // endDate_param
            // 
            this.endDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.endDate_param.Multiline = true;
            this.endDate_param.Name = "endDate_param";
            this.endDate_param.StylePriority.UseFont = false;
            this.endDate_param.Weight = 1.2347443593502792D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemCategory_lbl,
            this.itemCategory_param});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // itemCategory_lbl
            // 
            this.itemCategory_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.itemCategory_lbl.Multiline = true;
            this.itemCategory_lbl.Name = "itemCategory_lbl";
            this.itemCategory_lbl.StylePriority.UseFont = false;
            this.itemCategory_lbl.Text = "Item Category:";
            this.itemCategory_lbl.Weight = 0.50430701687612911D;
            // 
            // itemCategory_param
            // 
            this.itemCategory_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemCategory_param.Multiline = true;
            this.itemCategory_param.Name = "itemCategory_param";
            this.itemCategory_param.StylePriority.UseFont = false;
            this.itemCategory_param.Weight = 1.2347443593502792D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemGroup_lbl,
            this.itemGroup_param});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // itemGroup_lbl
            // 
            this.itemGroup_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.itemGroup_lbl.Multiline = true;
            this.itemGroup_lbl.Name = "itemGroup_lbl";
            this.itemGroup_lbl.StylePriority.UseFont = false;
            this.itemGroup_lbl.Text = "Item Group:";
            this.itemGroup_lbl.Weight = 0.50430701687612911D;
            // 
            // itemGroup_param
            // 
            this.itemGroup_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemGroup_param.Multiline = true;
            this.itemGroup_param.Name = "itemGroup_param";
            this.itemGroup_param.StylePriority.UseFont = false;
            this.itemGroup_param.Weight = 1.2347443593502792D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.item_lbl,
            this.item_param});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // item_lbl
            // 
            this.item_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.item_lbl.Multiline = true;
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.StylePriority.UseFont = false;
            this.item_lbl.Text = "Item:";
            this.item_lbl.Weight = 0.50430701687612911D;
            // 
            // item_param
            // 
            this.item_param.Font = new System.Drawing.Font("Arial", 8F);
            this.item_param.Multiline = true;
            this.item_param.Name = "item_param";
            this.item_param.StylePriority.UseFont = false;
            this.item_param.Weight = 1.2347443593502792D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.client_lbl,
            this.client_param});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // client_lbl
            // 
            this.client_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.client_lbl.Multiline = true;
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.StylePriority.UseFont = false;
            this.client_lbl.Text = "Client:";
            this.client_lbl.Weight = 0.50430701687612911D;
            // 
            // client_param
            // 
            this.client_param.Font = new System.Drawing.Font("Arial", 8F);
            this.client_param.Multiline = true;
            this.client_param.Name = "client_param";
            this.client_param.StylePriority.UseFont = false;
            this.client_param.Weight = 1.2347443593502792D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plant_lbl,
            this.plant_param});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // plant_lbl
            // 
            this.plant_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.plant_lbl.Multiline = true;
            this.plant_lbl.Name = "plant_lbl";
            this.plant_lbl.StylePriority.UseFont = false;
            this.plant_lbl.Text = "Plant:";
            this.plant_lbl.Weight = 0.50430701687612911D;
            // 
            // plant_param
            // 
            this.plant_param.Font = new System.Drawing.Font("Arial", 8F);
            this.plant_param.Multiline = true;
            this.plant_param.Name = "plant_param";
            this.plant_param.StylePriority.UseFont = false;
            this.plant_param.Weight = 1.2347443593502792D;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(550.2127F, 50F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow9,
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16});
            this.xrTable1.SizeF = new System.Drawing.SizeF(312.9166F, 145.2014F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.systemFunction_lbl,
            this.systemFunction_param});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // systemFunction_lbl
            // 
            this.systemFunction_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.systemFunction_lbl.Multiline = true;
            this.systemFunction_lbl.Name = "systemFunction_lbl";
            this.systemFunction_lbl.StylePriority.UseFont = false;
            this.systemFunction_lbl.Text = "System Function:";
            this.systemFunction_lbl.Weight = 0.57526280681898123D;
            // 
            // systemFunction_param
            // 
            this.systemFunction_param.Font = new System.Drawing.Font("Arial", 8F);
            this.systemFunction_param.Multiline = true;
            this.systemFunction_param.Name = "systemFunction_param";
            this.systemFunction_param.StylePriority.UseFont = false;
            this.systemFunction_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.docType_lbl,
            this.docType_param});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // docType_lbl
            // 
            this.docType_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.docType_lbl.Multiline = true;
            this.docType_lbl.Name = "docType_lbl";
            this.docType_lbl.StylePriority.UseFont = false;
            this.docType_lbl.Text = "Document Type:";
            this.docType_lbl.Weight = 0.57526280681898123D;
            // 
            // docType_param
            // 
            this.docType_param.Font = new System.Drawing.Font("Arial", 8F);
            this.docType_param.Multiline = true;
            this.docType_param.Name = "docType_param";
            this.docType_param.StylePriority.UseFont = false;
            this.docType_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientGrp_lbl,
            this.clientGrp_param});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // clientGrp_lbl
            // 
            this.clientGrp_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.clientGrp_lbl.Multiline = true;
            this.clientGrp_lbl.Name = "clientGrp_lbl";
            this.clientGrp_lbl.StylePriority.UseFont = false;
            this.clientGrp_lbl.Text = "Client Group:";
            this.clientGrp_lbl.Weight = 0.57526280681898123D;
            // 
            // clientGrp_param
            // 
            this.clientGrp_param.Font = new System.Drawing.Font("Arial", 8F);
            this.clientGrp_param.Multiline = true;
            this.clientGrp_param.Name = "clientGrp_param";
            this.clientGrp_param.StylePriority.UseFont = false;
            this.clientGrp_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.salesPerson_lbl,
            this.salesPerson_param});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // salesPerson_lbl
            // 
            this.salesPerson_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.salesPerson_lbl.Multiline = true;
            this.salesPerson_lbl.Name = "salesPerson_lbl";
            this.salesPerson_lbl.StylePriority.UseFont = false;
            this.salesPerson_lbl.Text = "Sales Person:";
            this.salesPerson_lbl.Weight = 0.57526280681898123D;
            // 
            // salesPerson_param
            // 
            this.salesPerson_param.Font = new System.Drawing.Font("Arial", 8F);
            this.salesPerson_param.Multiline = true;
            this.salesPerson_param.Name = "salesPerson_param";
            this.salesPerson_param.StylePriority.UseFont = false;
            this.salesPerson_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.reference_lbl,
            this.reference_param});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // reference_lbl
            // 
            this.reference_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.reference_lbl.Multiline = true;
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.StylePriority.UseFont = false;
            this.reference_lbl.Text = "Reference:";
            this.reference_lbl.Weight = 0.57526280681898123D;
            // 
            // reference_param
            // 
            this.reference_param.Font = new System.Drawing.Font("Arial", 8F);
            this.reference_param.Multiline = true;
            this.reference_param.Name = "reference_param";
            this.reference_param.StylePriority.UseFont = false;
            this.reference_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemCollection_lbl,
            this.itemCollection_param});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // itemCollection_lbl
            // 
            this.itemCollection_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.itemCollection_lbl.Multiline = true;
            this.itemCollection_lbl.Name = "itemCollection_lbl";
            this.itemCollection_lbl.StylePriority.UseFont = false;
            this.itemCollection_lbl.Text = "Item Collection:";
            this.itemCollection_lbl.Weight = 0.57526280681898123D;
            // 
            // itemCollection_param
            // 
            this.itemCollection_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemCollection_param.Multiline = true;
            this.itemCollection_param.Name = "itemCollection_param";
            this.itemCollection_param.StylePriority.UseFont = false;
            this.itemCollection_param.Weight = 1.2311113879433222D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productionLine_lbl,
            this.productionLine_param});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // productionLine_lbl
            // 
            this.productionLine_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.productionLine_lbl.Multiline = true;
            this.productionLine_lbl.Name = "productionLine_lbl";
            this.productionLine_lbl.StylePriority.UseFont = false;
            this.productionLine_lbl.Text = "Production Line:";
            this.productionLine_lbl.Weight = 0.57526280681898123D;
            // 
            // productionLine_param
            // 
            this.productionLine_param.Font = new System.Drawing.Font("Arial", 8F);
            this.productionLine_param.Multiline = true;
            this.productionLine_param.Name = "productionLine_param";
            this.productionLine_param.StylePriority.UseFont = false;
            this.productionLine_param.Weight = 1.2311113879433222D;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.printSignature,
            this.pagesNumber_lbl});
            this.PageFooter.HeightF = 32.50003F;
            this.PageFooter.Name = "PageFooter";
            // 
            // printSignature
            // 
            this.printSignature.Font = new System.Drawing.Font("Arial", 8F);
            this.printSignature.ForeColor = System.Drawing.Color.DimGray;
            this.printSignature.LocationFloat = new DevExpress.Utils.PointFloat(24.58334F, 9.500027F);
            this.printSignature.Multiline = true;
            this.printSignature.Name = "printSignature";
            this.printSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.printSignature.SizeF = new System.Drawing.SizeF(825.8896F, 23F);
            this.printSignature.StylePriority.UseFont = false;
            this.printSignature.StylePriority.UseForeColor = false;
            this.printSignature.StylePriority.UseTextAlignment = false;
            this.printSignature.Text = "printSignature";
            this.printSignature.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pagesNumber_lbl
            // 
            this.pagesNumber_lbl.BackColor = System.Drawing.Color.White;
            this.pagesNumber_lbl.Font = new System.Drawing.Font("Arial", 8F);
            this.pagesNumber_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pagesNumber_lbl.LocationFloat = new DevExpress.Utils.PointFloat(1179.74F, 12.5F);
            this.pagesNumber_lbl.Name = "pagesNumber_lbl";
            this.pagesNumber_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pagesNumber_lbl.SizeF = new System.Drawing.SizeF(97.67694F, 20.00002F);
            this.pagesNumber_lbl.StylePriority.UseBackColor = false;
            this.pagesNumber_lbl.StylePriority.UseFont = false;
            this.pagesNumber_lbl.StylePriority.UseForeColor = false;
            this.pagesNumber_lbl.StylePriority.UseTextAlignment = false;
            this.pagesNumber_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pagesNumber_lbl.TextFormatString = "Page {0} of {1}";
            // 
            // SummarySubReports
            // 
            this.SummarySubReports.LocationFloat = new DevExpress.Utils.PointFloat(24.58334F, 18.33324F);
            this.SummarySubReports.Name = "SummarySubReports";
            this.SummarySubReports.ReportSource = new ArgusCR1029.Sales.SA416b.SummarySubReports();
            this.SummarySubReports.SizeF = new System.Drawing.SizeF(1252.833F, 23F);
            // 
            // SA416b
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 13, 0);
            this.PageHeight = 827;
            this.PageWidth = 1299;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Plus;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.SubBand SummarySubBand;
        private DevExpress.XtraReports.UI.XRSubreport DetailSubReports;
        private DevExpress.XtraReports.UI.XRSubreport SummarySubReports;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.SubBand DetailSubBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo pagesNumber_lbl;
        private DevExpress.XtraReports.UI.XRLabel printSignature;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell startDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell startDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell endDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell endDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell itemCategory_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemCategory_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell itemGroup_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemGroup_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell item_lbl;
        private DevExpress.XtraReports.UI.XRTableCell item_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell client_lbl;
        private DevExpress.XtraReports.UI.XRTableCell client_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell plant_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plant_param;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell systemFunction_lbl;
        private DevExpress.XtraReports.UI.XRTableCell systemFunction_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell docType_lbl;
        private DevExpress.XtraReports.UI.XRTableCell docType_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell clientGrp_lbl;
        private DevExpress.XtraReports.UI.XRTableCell clientGrp_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_lbl;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell reference_lbl;
        private DevExpress.XtraReports.UI.XRTableCell reference_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell itemCollection_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemCollection_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell productionLine_lbl;
        private DevExpress.XtraReports.UI.XRTableCell productionLine_param;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
    }
}
