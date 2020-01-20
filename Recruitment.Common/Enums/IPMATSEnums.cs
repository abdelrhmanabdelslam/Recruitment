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
        ////[EnumMessage("Internal server error")]
        InternalServerError = -100,
        ////[EnumMessage("Success")]
        Success = 0,
        ////[EnumMessage("Error")]
        Error = 1,
        //[EnumMessage("UnAuthorized")]
        UnAuthorized = -1,
        //[EnumMessage("Email or password is incorrect.")]
        InvalidCredentials = -2,
        //[EnumMessage("Verification code may be expired or incorrect.")]
        InvalidVCodeProcess = -3,
        //[EnumMessage("Password doesn't match the pattern.")]
        InvalidPasswordFormat = -4,
        //[EnumMessage("Phone doesn't match the pattern.")]
        InvalidPhoneFormat = -4,
        //[EnumMessage("Invalid Parameters.")]
        InvalidParameters = -5,
        //[EnumMessage("Invalid data for {0}.")]
        InvalidData = -6,
        //[EnumMessage("Email already exists.")]
        EmailAlreadyExists = -7,
        //[EnumMessage("Empty data.")]
        EmptyData = -8,
        //[EnumMessage("Check your mail for veification.")]
        EmailVerificationMessage = -9,
        //[EnumMessage("Email Verified successfully.")]
        EmailVerificationSuccessMessage = -10,
        //[EnumMessage("Email does not exist.")]
        EmailNotExist = -11,
        //[EnumMessage("Address is linked To Request")]
        AddressIsLinkedToRequest = -12,
        //[EnumMessage("Forget passwordSuccessMessage")]
        ForgetPasswordSuccessMessage = -13,
        //[EnumMessage("Invalid Notfication Token Id")]
        InvalidNotficationTokenId = -14

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
