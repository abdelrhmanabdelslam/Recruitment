using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Common.Enums
{
    public enum ActionEnum
    {
        View = 1,
        Add = 2,
        Update = 3,
        Delete = 4,
        ScanDocument = 5,
        ScanBarcode = 6,
        Print = 7,
        Packaging = 8,
        Cancel = 9,
        StoppingCancel = 10
    }
    public enum BarcodeTypeEnum
    {
        Single = 1,
        Group = 2,
        Belt = 3
    }
    public enum ChannelTypeEnum
    {
        PostOfficer = 1,
        CallCenter = 2,
        PDA = 3,
        Mobile = 4,
        Web = 5

    }
    public enum CurrencyEnum
    {
        Dinar = 1,
        Dollar = 2,
        Euro = 3,

    }
    public enum DistributorTypeEnum
    {
        Delegate = 1,
        Distributor = 2,
        Both = 3,
    }
    public enum Page
    { }
    public enum ComponentEnum
    {
    }
    public enum PaymentMethodEnum
    {
        Cach = 1,
        Credit = 2
    }
    public enum PostOfficeType
    {
        Branch = 1,
        Main = 2,
        Exchange = 3
    }
    public enum UserActivationStatus
    {
       
    }
    public enum PriceTypeEnum
    {
        Absoluate = 1,
        Percentage = 2
    }
    public enum PricingFactorType
    {
        ActualWeight,
        DimentionWeight
    }
    public enum AttachmentTypeEnum
    {
        Documents = 1, //مسنمسكات
        Attachment = 2 //مرفقات
    }
    public enum DeleteStatusEnum
    {
        NotDeleted = 0, 
        Deleted = 1
    }
    public enum APIResponseMessage
    {
        InternalServerError = -100,
        Success = 0,
        Error = 1,
        UnAuthorized = -1,
        InvalidCredentials = -2,
        InvalidVCodeProcess = -3,
        InvalidPasswordFormat = -4,
        InvalidPhoneFormat = -5,
        InvalidParameters = -6,
        InvalidData = -7,
        EmailAlreadyExists = -8,
        EmptyData = -9,
        EmailVerificationMessage = -10,
        EmailVerificationSuccessMessage = -11,
        EmailNotExist = -12,
        AddressIsLinkedToRequest = -13,
        ForgetPasswordSuccessMessage = -14,
        InvalidNotficationTokenId = -15,
        ReferenceAccountIDNotExsit = -16,
        SenderAccountNotExsit = -17,
        ReceiverAccountNotExsit = -18,
        InvalidCounteryId = -19,
        InvalidCurrencyId = -20,
        InvalidGovernorateId = -21,
        InvalidDestinationPostOfficeId = -22,
        InvalidOriginPostOfficeId = -23,
        InvalidBarCodeId = -24,
        InvalidShippingTypeId = -25,
        InvalidChannelTypeId = -26,
        InvalidDeliveryTypeId = -27,
        InvalidPaymentMethodId = -28,
        InvalidBuildingTypeId = -29,
        AppartmentNoIsEmpty = -30,
        FloorIsEmpty = -31,
        ReferenceRequestIdAlreadyExist = -32,
        ShiftTypeRelatedToDistributer = -33,
        CantDeleteUserRelatedToDistributer = -35,
        CantDeletePostofficeRelatedToShelf = -36,
        weightRangeIsRelatedToFixedServicePrice = -38,
        LookUpIsRelatedToLookUpContents = -39,
        CantDeleteDDDRelatedToZone = -40,
        ThisUserIsRelatedToANotherOffice = -41,
        InValidImageSize = -42,
        InValidImageExtension = -43,
        ForgetPassEmailAlreadySent = -44,
        CantDeletePostofficeRelatedToUser = -45,
        CantDeletePackageSizeRelatedToPackageServicePrice = -46,
        CantDeletePackageServicePriceRelatedToRequestItem = -47,
        OfficeCodeIsExist = -48,
        PostOfficeNameIsExist = -49,
        ZoneRelatedToFixedServicePrice = -50,
        CantDeleteFixedServicePriceRelatedToRequestItem = -51,
        CantAddPostOfficeBecauseThereIsExchangeCenterInTheSameGovernorate = -52,
        CantUpdatePostOfficeBecauseThereIsExchangeCenterInTheSameGovernorate = -53,
        CantChangeNewPasswordToBeSameAsOldOne = -54,
        CantAddSeconadryPostOfficeTheSameAsUserPostOffice = -55,
        DistributerExist = -56,
        CantEditSeconadryPostOfficeTheSameAsUserPostOffice = -57,
        CantDeleteStoreRelatedToShelf = -58
    }
    public enum RequestType
    {
        GET = 1,
        POST = 2
    }
    public enum Components
    {
        UserManagement = 1,
        ControlPanel = 2,
        Request =3
    }
    public enum SettingKeys
    {
        TokenSecurityKey = 1,
        TokenExpireInHours = 2,
        RequestTimeoutInMiliseconds = 3,
        TDESKey=4
    }

}
