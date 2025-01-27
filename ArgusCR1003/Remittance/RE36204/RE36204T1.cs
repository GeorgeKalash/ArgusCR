using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;

namespace ArgusCR1003.Remittance.RE36204
{
    public partial class RE36204T1 : ArgusRPT.BaseReport
    {
        public RE36204T1()
        {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e)
        {
            SharedClasses.JsonProtocol.GetStructure<ArgusCT_DS.Remittance.Report.RT102> webObject = deserializeGet<ArgusCT_DS.Remittance.Report.RT102>();

            carNo_data.Text = webObject.record.clientMaster?.categoryName;
            category_data.Text = webObject.record.clientMaster?.categoryName;
            date_data.Text = webObject.record.clientRemittance?.date.ToString("dd/MM/yyyy"); ;
            branch_data.Text = webObject.record.clientRemittance?.plantName;
            arName_data.Text = webObject.record.clientIndividual?.fl_firstName;
            engName_data.Text = webObject.record.clientIndividual?.firstName;
            gender_data.Text = webObject.record.clientRemittance?.genderName;
            nationality_data.Text = webObject.record.clientMaster?.nationalityName;
            idType_data.Text = webObject.record.clientIDView?.idtName;
            idNo_data.Text = webObject.record.clientIDView?.idNo;
            idIss_data.Text = webObject.record.clientIDView?.idCountryName;

            idPlace_data.Text = webObject.record.clientIDView?.idCityName;

            idExp_data.Text = webObject.record.clientIDView?.idExpiryDate.ToString("dd/MM/yyyy");

            idIssDate_data.Text = webObject.record.clientIDView.idIssueDate?.ToString("dd/MM/yyyy") ?? string.Empty;

            eduLevel_data.Text = webObject.record.clientRemittance?.educationLevelName;
            materialStatus_data.Text = webObject.record.clientRemittance?.statusName;
            sponsor_data.Text = webObject.record.clientIndividual?.sponsorName;
            mobileNo_data.Text = webObject.record.clientRemittance?.whatsAppNo;
            district_data.Text = webObject.record.addressView?.cityDistrict;

            city_data.Text = webObject.record.addressView?.city;
            buildingNo_data.Text = webObject.record.addressView?.bldgNo;

            street_data.Text = webObject.record.addressView?.street1;
            postal_data.Text = webObject.record.addressView?.postalCode;
            aparteent_data.Text = webObject.record.addressView?.unitNo;

            extraNo_data.Text = webObject.record.imageContent;

            profession_data.Text = webObject.record.clientMaster?.professionName;
            workCity_data.Text = webObject.record.workAddressView?.name;
            income_data.Text = webObject.record.clientIndividual?.incomeSourceName;
            adress_data.Text = webObject.record.workAddress?.ToString();

            image_data.ImageUrl = webObject.record.imageContent;


            QRCode.Text = webObject.record.clientRemittance.reference;
            base.OnBeforePrint(e);
        }

        protected override void labelsText()
        {
        }
        protected override string dictionaryStore()
        {
            return "CR1003.RE36204T1";
        }
    }
}