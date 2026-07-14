
using System;
using System.Drawing.Printing;

namespace ArgusCR1029.Sales.SA424
{
    partial class SA424
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
            this.SummarySubReports = new DevExpress.XtraReports.UI.XRSubreport();
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
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.client_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientRef_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.salesPerson_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.salesPerson_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plantGroup_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plantGroup_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.plant_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.plant_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.title_lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.site_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.site_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clientGrp_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.clientGrp_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.salesZone_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.salesZone_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.itemCategory_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.itemCategory_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.description_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.desc_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.status_lbl = new DevExpress.XtraReports.UI.XRTableCell();
            this.stt_param = new DevExpress.XtraReports.UI.XRTableCell();
            this.addressStreet_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressEmail_data = new DevExpress.XtraReports.UI.XRLabel();
            this.companyInfoName_data = new DevExpress.XtraReports.UI.XRLabel();
            this.taxNo_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressName_data = new DevExpress.XtraReports.UI.XRLabel();
            this.addressMobile_data = new DevExpress.XtraReports.UI.XRLabel();
            this.logo_data = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.printSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.pagesNumber_lbl = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
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
            this.DetailSubReports.ReportSource = new ArgusCR1029.Sales.SA424.DetailSubReports();
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
            // SummarySubReports
            // 
            this.SummarySubReports.LocationFloat = new DevExpress.Utils.PointFloat(24.58334F, 18.33324F);
            this.SummarySubReports.Name = "SummarySubReports";
            this.SummarySubReports.ReportSource = new ArgusCR1029.Sales.SA424.SummarySubReports();
            this.SummarySubReports.SizeF = new System.Drawing.SizeF(1252.833F, 23F);
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
            this.xrTable5,
            this.title_lbl,
            this.xrTable7,
            this.addressStreet_data,
            this.addressEmail_data,
            this.companyInfoName_data,
            this.taxNo_data,
            this.addressName_data,
            this.addressMobile_data,
            this.logo_data});
            this.ReportHeader.HeightF = 196.3751F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(362.5F, 50F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow11,
            this.xrTableRow12});
            this.xrTable5.SizeF = new System.Drawing.SizeF(291.4583F, 124.4583F);
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
            this.startDate_lbl.Weight = 0.4381614790949715D;
            // 
            // startDate_param
            // 
            this.startDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.startDate_param.Multiline = true;
            this.startDate_param.Name = "startDate_param";
            this.startDate_param.StylePriority.UseFont = false;
            this.startDate_param.Weight = 1.2443399944479514D;
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
            this.endDate_lbl.Weight = 0.4381614790949715D;
            // 
            // endDate_param
            // 
            this.endDate_param.Font = new System.Drawing.Font("Arial", 8F);
            this.endDate_param.Multiline = true;
            this.endDate_param.Name = "endDate_param";
            this.endDate_param.StylePriority.UseFont = false;
            this.endDate_param.Weight = 1.2443399944479514D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.client_lbl,
            this.clientRef_param});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // client_lbl
            // 
            this.client_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.client_lbl.Multiline = true;
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.StylePriority.UseFont = false;
            this.client_lbl.Text = "Client:";
            this.client_lbl.Weight = 0.4381614790949715D;
            // 
            // clientRef_param
            // 
            this.clientRef_param.Font = new System.Drawing.Font("Arial", 8F);
            this.clientRef_param.Multiline = true;
            this.clientRef_param.Name = "clientRef_param";
            this.clientRef_param.StylePriority.UseFont = false;
            this.clientRef_param.Weight = 1.2443399944479514D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.salesPerson_lbl,
            this.salesPerson_param});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // salesPerson_lbl
            // 
            this.salesPerson_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.salesPerson_lbl.Multiline = true;
            this.salesPerson_lbl.Name = "salesPerson_lbl";
            this.salesPerson_lbl.StylePriority.UseFont = false;
            this.salesPerson_lbl.Text = "Sales Person:";
            this.salesPerson_lbl.Weight = 0.4381614790949715D;
            // 
            // salesPerson_param
            // 
            this.salesPerson_param.Font = new System.Drawing.Font("Arial", 8F);
            this.salesPerson_param.Multiline = true;
            this.salesPerson_param.Name = "salesPerson_param";
            this.salesPerson_param.StylePriority.UseFont = false;
            this.salesPerson_param.Weight = 1.2443399944479514D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plantGroup_lbl,
            this.plantGroup_param});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // plantGroup_lbl
            // 
            this.plantGroup_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.plantGroup_lbl.Multiline = true;
            this.plantGroup_lbl.Name = "plantGroup_lbl";
            this.plantGroup_lbl.StylePriority.UseFont = false;
            this.plantGroup_lbl.Text = "Plant Group:";
            this.plantGroup_lbl.Weight = 0.4381614790949715D;
            // 
            // plantGroup_param
            // 
            this.plantGroup_param.Font = new System.Drawing.Font("Arial", 8F);
            this.plantGroup_param.Multiline = true;
            this.plantGroup_param.Name = "plantGroup_param";
            this.plantGroup_param.StylePriority.UseFont = false;
            this.plantGroup_param.Weight = 1.2443399944479514D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.plant_lbl,
            this.plant_param});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // plant_lbl
            // 
            this.plant_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.plant_lbl.Multiline = true;
            this.plant_lbl.Name = "plant_lbl";
            this.plant_lbl.StylePriority.UseFont = false;
            this.plant_lbl.Text = "Plant:";
            this.plant_lbl.Weight = 0.4381614790949715D;
            // 
            // plant_param
            // 
            this.plant_param.Font = new System.Drawing.Font("Arial", 8F);
            this.plant_param.Multiline = true;
            this.plant_param.Name = "plant_param";
            this.plant_param.StylePriority.UseFont = false;
            this.plant_param.Weight = 1.2443399944479514D;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title_lbl.LocationFloat = new DevExpress.Utils.PointFloat(344.7498F, 3.178914E-05F);
            this.title_lbl.Multiline = true;
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.title_lbl.SizeF = new System.Drawing.SizeF(954.2502F, 39.66666F);
            this.title_lbl.StylePriority.UseFont = false;
            this.title_lbl.StylePriority.UseTextAlignment = false;
            this.title_lbl.Text = "Sales By Document";
            this.title_lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable7
            // 
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(675F, 50F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17});
            this.xrTable7.SizeF = new System.Drawing.SizeF(278.4584F, 124.4583F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.site_lbl,
            this.site_param});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // site_lbl
            // 
            this.site_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.site_lbl.Multiline = true;
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.StylePriority.UseFont = false;
            this.site_lbl.Text = "Site:";
            this.site_lbl.Weight = 0.47777550825584386D;
            // 
            // site_param
            // 
            this.site_param.Font = new System.Drawing.Font("Arial", 8F);
            this.site_param.Multiline = true;
            this.site_param.Name = "site_param";
            this.site_param.StylePriority.UseFont = false;
            this.site_param.Weight = 1.1296815515334282D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clientGrp_lbl,
            this.clientGrp_param});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // clientGrp_lbl
            // 
            this.clientGrp_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.clientGrp_lbl.Multiline = true;
            this.clientGrp_lbl.Name = "clientGrp_lbl";
            this.clientGrp_lbl.StylePriority.UseFont = false;
            this.clientGrp_lbl.Text = "Client Group:";
            this.clientGrp_lbl.Weight = 0.47777550825584386D;
            // 
            // clientGrp_param
            // 
            this.clientGrp_param.Font = new System.Drawing.Font("Arial", 8F);
            this.clientGrp_param.Multiline = true;
            this.clientGrp_param.Name = "clientGrp_param";
            this.clientGrp_param.StylePriority.UseFont = false;
            this.clientGrp_param.Weight = 1.1296815515334282D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.salesZone_lbl,
            this.salesZone_param});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // salesZone_lbl
            // 
            this.salesZone_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.salesZone_lbl.Multiline = true;
            this.salesZone_lbl.Name = "salesZone_lbl";
            this.salesZone_lbl.StylePriority.UseFont = false;
            this.salesZone_lbl.Text = "Sales Zone:";
            this.salesZone_lbl.Weight = 0.47777550825584386D;
            // 
            // salesZone_param
            // 
            this.salesZone_param.Font = new System.Drawing.Font("Arial", 8F);
            this.salesZone_param.Multiline = true;
            this.salesZone_param.Name = "salesZone_param";
            this.salesZone_param.StylePriority.UseFont = false;
            this.salesZone_param.Weight = 1.1296815515334282D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.itemCategory_lbl,
            this.itemCategory_param});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // itemCategory_lbl
            // 
            this.itemCategory_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.itemCategory_lbl.Multiline = true;
            this.itemCategory_lbl.Name = "itemCategory_lbl";
            this.itemCategory_lbl.StylePriority.UseFont = false;
            this.itemCategory_lbl.Text = "Item Category:";
            this.itemCategory_lbl.Weight = 0.47777550825584386D;
            // 
            // itemCategory_param
            // 
            this.itemCategory_param.Font = new System.Drawing.Font("Arial", 8F);
            this.itemCategory_param.Multiline = true;
            this.itemCategory_param.Name = "itemCategory_param";
            this.itemCategory_param.StylePriority.UseFont = false;
            this.itemCategory_param.Weight = 1.1296815515334282D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.description_lbl,
            this.desc_param});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // description_lbl
            // 
            this.description_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.StylePriority.UseFont = false;
            this.description_lbl.Text = "Description:";
            this.description_lbl.Weight = 0.47777550825584386D;
            // 
            // desc_param
            // 
            this.desc_param.Font = new System.Drawing.Font("Arial", 8F);
            this.desc_param.Multiline = true;
            this.desc_param.Name = "desc_param";
            this.desc_param.StylePriority.UseFont = false;
            this.desc_param.Weight = 1.1296815515334282D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.status_lbl,
            this.stt_param});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // status_lbl
            // 
            this.status_lbl.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.status_lbl.Multiline = true;
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.StylePriority.UseFont = false;
            this.status_lbl.Text = "Status:";
            this.status_lbl.Weight = 0.47777550825584386D;
            // 
            // stt_param
            // 
            this.stt_param.Font = new System.Drawing.Font("Arial", 8F);
            this.stt_param.Multiline = true;
            this.stt_param.Name = "stt_param";
            this.stt_param.StylePriority.UseFont = false;
            this.stt_param.Weight = 1.1296815515334282D;
            // 
            // addressStreet_data
            // 
            this.addressStreet_data.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.addressStreet_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0416F, 56.50007F);
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
            this.addressEmail_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0417F, 94.16668F);
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
            this.companyInfoName_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0416F, 3.178914E-05F);
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
            this.taxNo_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0416F, 18.83337F);
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
            this.addressName_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0416F, 37.66669F);
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
            this.addressMobile_data.LocationFloat = new DevExpress.Utils.PointFloat(136.0417F, 75.33333F);
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
            this.logo_data.LocationFloat = new DevExpress.Utils.PointFloat(24.58334F, 3.178914E-05F);
            this.logo_data.Name = "logo_data";
            this.logo_data.SizeF = new System.Drawing.SizeF(105.5832F, 113F);
            this.logo_data.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
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
            this.printSignature.SizeF = new System.Drawing.SizeF(733.1813F, 23F);
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
            // SA424
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
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
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
        private DevExpress.XtraReports.UI.XRLabel addressStreet_data;
        private DevExpress.XtraReports.UI.XRLabel addressEmail_data;
        private DevExpress.XtraReports.UI.XRLabel companyInfoName_data;
        private DevExpress.XtraReports.UI.XRLabel taxNo_data;
        private DevExpress.XtraReports.UI.XRLabel addressName_data;
        private DevExpress.XtraReports.UI.XRLabel addressMobile_data;
        private DevExpress.XtraReports.UI.XRPictureBox logo_data;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell startDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell startDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell endDate_lbl;
        private DevExpress.XtraReports.UI.XRTableCell endDate_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell client_lbl;
        private DevExpress.XtraReports.UI.XRTableCell clientRef_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_lbl;
        private DevExpress.XtraReports.UI.XRTableCell salesPerson_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell plantGroup_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plantGroup_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell plant_lbl;
        private DevExpress.XtraReports.UI.XRTableCell plant_param;
        private DevExpress.XtraReports.UI.XRLabel title_lbl;
        private DevExpress.XtraReports.UI.XRTable xrTable7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell site_lbl;
        private DevExpress.XtraReports.UI.XRTableCell site_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell clientGrp_lbl;
        private DevExpress.XtraReports.UI.XRTableCell clientGrp_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell salesZone_lbl;
        private DevExpress.XtraReports.UI.XRTableCell salesZone_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell itemCategory_lbl;
        private DevExpress.XtraReports.UI.XRTableCell itemCategory_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell description_lbl;
        private DevExpress.XtraReports.UI.XRTableCell desc_param;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell status_lbl;
        private DevExpress.XtraReports.UI.XRTableCell stt_param;
        private DevExpress.XtraReports.UI.XRLabel printSignature;
    }
}
