using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Recruitment.Common.Helper
{
    public class ConfigHelper
    {
        #region Properties
        public static IConfiguration Configuration { get; set; }
        #endregion
        #region EntityFramworkSettings
        public static string ConnectionString => GetValue("EntityFramworkSettings:ConnectionString", string.Empty);
        public static int ConnectionTimeout => GetValue("EntityFramworkSettings:ConnectionTimeout", default(int));
        public static string DefaultLocalization => GetValue("Localization:DefaultLocalization", string.Empty);

        #endregion
        #region LogPath
        public static string LogPath => GetValue("AppSettings:LogPath", string.Empty);
        #endregion
        #region LogPath
        public static string NumberOfTakeAutoComplete => GetValue("AppSettings:NumberOfTakeAutoComplete", string.Empty);
        public static long VolumeConfiguration => GetValue("AppSettings:VolumeConfiguration", default(long));
        #endregion
        #region EmailConfiguration
        public static string VCodeEmailVerificationURL => GetValue("EmailConfigurations:VCodeEmailVerificationURL", string.Empty);
        public static string SenderName => GetValue("EmailConfigurations:FromAddressName", string.Empty);
        public static string SMPTHost => GetValue("EmailConfigurations:Host", string.Empty);
        public static int SMPTPort => GetValue("EmailConfigurations:Port", default(int));
        public static string CompanyEmailAddress => GetValue("EmailConfigurations:AuthenticatedAddress", string.Empty);
        public static string CompanyEmailAddressPassword => GetValue("EmailConfigurations:AuthenticatedAddressPassword", string.Empty);
        public static int SMPTTimeout => GetValue("EmailConfigurations:SMPTTimeout", default(int));
        public static DateTime DateTimeNow => TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, DateTimeZone);
        public static string DateTimeZone => GetValue("AppSettings:DateTimeZone", string.Empty);
        public static string VCodeEmailSubject => GetValue("EmailConfigurations:VCodeEmailSubject", "Email Verification Code");
        public static string CCAddresses => GetValue("EmailConfigurations:CCAddresses", string.Empty);
        public static string BCCAddresses => GetValue("EmailConfigurations:BCCAddresses", string.Empty);
        public static string ResetPasswordAngularPath => GetValue("EmailConfigurations:ResetPasswordAngularPath", string.Empty);
        public static string ExpiredVCodeAngularUrl => GetValue("EmailConfigurations:ExpiredVCodeAngularUrl", string.Empty);
        #region Images Profile 
        public static string ImageProfilePath => GetValue("ImageProfileConfigurations:ImageProfilePath", string.Empty);
        public static string ServerURL => GetValue("ImageProfileConfigurations:ServerURL", string.Empty);
        public static string ImageExtension => GetValue("ImageProfileConfigurations:ImageExtension", string.Empty);
        public static string UploadedFileExtensionValidation => GetValue("ImageProfileConfigurations:UploadedFileExtensionValidation", string.Empty);
        public static int UploadedFileSize => GetValue("ImageProfileConfigurations:UploadedFileSize", default(int));

        #endregion
        #region Request Image 
        public static string RequestImagePath => GetValue("RequestImageConfiguration:RequestImagePath", string.Empty);
        public static string RequestImageServerURL => GetValue("RequestImageConfiguration:RequestImageServerURL", string.Empty);
        #endregion
        #endregion
        #region Common
        public static int VCodeExpireMinute => GetValue("AppSettings:VerificationCodeExpireMinute", default(int));
        public static int RequestTimeoutInMiliseconds => GetValue("AppSettings:RequestTimeoutInMiliseconds", default(int));
        public static string SwaggerURL => GetValue("AppSettings:SwaggerURL", string.Empty);

        #endregion
        #region Setting
        public static long IraqCountry => GetValue("Setting:IraqCountry", default(long));
        public static long PackagingConditionIdBreakable => GetValue("Setting:PackagingConditionIdBreakable", default(long));
        public static long PackagingConditionIdLiquid => GetValue("Setting:PackagingConditionIdLiquid", default(long));
        public static long PackagingConditionIdBoth => GetValue("Setting:PackagingConditionIdBoth", default(long));
        public static long ChannelTypeIdPostOfficer => GetValue("Setting:ChannelTypeIdPostOfficer", default(long));
        public static long ChannelTypeIdCallCenter => GetValue("Setting:ChannelTypeIdCallCenter", default(long));
        public static long ChannelTypeIdCourier => GetValue("Setting:ChannelTypeIdCourier", default(long));
        public static string ShipmentFeesAdditionalService => GetValue("Setting:ShipmentFeesAdditionalService", default(string));
        public static string ExtraFeesAdditionalService => GetValue("Setting:ExtraFeesAdditionalService", default(string));
        public static string CustomsFeesAdditionalService => GetValue("Setting:CustomsFeesAdditionalService", default(string));
        public static long DeliveryLocationOffice => GetValue("Setting:DeliveryLocationOffice", default(long));
        public static long DeliveryLocationDOD => GetValue("Setting:DeliveryLocationDOD", default(long));
        public static long PaymentMethodCorporate => GetValue("Setting:PaymentMethodCorporate", default(long));
        public static byte AdditionalServiceTotalShipmentPrice => GetValue("Setting:AdditionalServiceTotalShipmentPrice", default(byte));
        public static byte AdditionalServiceTotalPackagingPice => GetValue("Setting:AdditionalServiceTotalPackagingPice", default(byte));
        public static byte AdditionalServiceCustoms => GetValue("Setting:AdditionalServiceCustoms", default(byte));
        public static byte AdditionalServiceCustomsFees => GetValue("Setting:AdditionalServiceCustomsFees", default(byte));
        public static byte AdditionalServiceShipmentFees => GetValue("Setting:AdditionalServiceShipmentFees", default(byte));
        public static byte AdditionalServiceDOD => GetValue("Setting:AdditionalServiceDOD", default(byte));
        public static byte AdditionalServiceSameDay => GetValue("Setting:AdditionalServiceSameDay", default(byte));
        public static byte AdditionalServiceNextDay => GetValue("Setting:AdditionalServiceNextDay", default(byte));
        public static byte AdditionalServiceEarlyDelivery => GetValue("Setting:AdditionalServiceEarlyDelivery", default(byte));
        public static byte AdditionalServiceEveningDelivery => GetValue("Setting:AdditionalServiceEveningDelivery", default(byte));
        public static byte AdditionalServicePaiedFromReceiver => GetValue("Setting:AdditionalServicePaiedFromReceiver", default(byte));
        public static string PrintInvoicePostOfficeName => GetValue("Setting:PrintInvoicePostOfficeName", default(string));
        public static string PrintInvoicePostOfficeAddress => GetValue("Setting:PrintInvoicePostOfficeAddress", default(string));
        public static string PrintInvoiceContactInfo => GetValue("Setting:PrintInvoiceContactInfo", default(string));
        public static string PrintInvoiceEmail => GetValue("Setting:PrintInvoiceEmail", default(string));
        public static int BarCodeLength => GetValue("Setting:BarCodeLength", default(int));
        public static long CurrencyIdIraq => GetValue("Setting:CurrencyIdIraq", default(long));
        public static long ServiceTypeEnvelope => GetValue("Setting:ServiceTypeEnvelope", default(long));
        public static string PrintInvoiceShippingType => GetValue("Setting:PrintInvoiceShippingType", default(string));

        public static string LookupIdsOdooRequest => GetValue("AppSettings:LookupIdsOdooRequest", default(string));
        public static long BarCodeTypeIdForOdooRequest => GetValue("AppSettings:BarCodeTypeIdForOdooRequest", default(long));
        public static string InvoiceAPIUrl => GetValue("AppSettings:InvoiceAPIUrl", default(string));
        #endregion
        #region EmailTemplates
        public static string VCodeEmailTemplateFilePath => GetValue("EmailTemplates:VCodeEmailTemplateFilePath", string.Empty);
        public static string VerifyEmailExpiredResponseTemplateFilePath => GetValue("EmailTemplates:VerifyEmailExpiredResponseTemplateFilePath", string.Empty);
        public static string VerifyEmailTemplateFilePath => GetValue("EmailTemplates:VerifyEmailTemplateFilePath", string.Empty);
        public static string VerifyEmailResponseTemplateFilePath => GetValue("EmailTemplates:VerifyEmailResponseTemplateFilePath", string.Empty);
        public static string RequestInvoiceTemplateFilePath => GetValue("EmailTemplates:RequestInvoiceTemplateFilePath", string.Empty);
        public static string RequestInvoiceServicesTemplateFilePath => GetValue("EmailTemplates:RequestInvoiceServicesTemplateFilePath", string.Empty);
        public static string RequestInvoiceSummaryTemplateFilePath => GetValue("EmailTemplates:RequestInvoiceSummaryTemplateFilePath", string.Empty);
        #endregion
        #region Private - Methods
        /// <summary>
        /// Getting the value of the given key from Config file with specific type.
        /// </summary>
        /// <typeparam name="T">The specified type to be casted.</typeparam>
        /// <param name="key">The config key.</param>
        /// <param name="defaultvalue">The default of the key.</param>
        /// <returns>return a value with dynamic type.</returns>
        private static T GetValue<T>(string key, T defaultvalue) where T : IConvertible
        {
            #region Declare return Var with intial value
            T value = default(T);
            #endregion
            try
            {
                #region VARS
                dynamic result = null;
                Type valueType = typeof(T);
                #endregion
                #region Check whether the value is exists in the config or not.
                if (!string.IsNullOrWhiteSpace(Configuration.GetSection(key).Value))
                {
                    #region Casting the value into specified type.
                    if (valueType == typeof(int))
                    {
                        int keyValue = default(int);
                        if (int.TryParse(Configuration.GetSection(key).Value, out keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    else if (valueType == typeof(double))
                    {
                        double keyValue = default(double);
                        if (double.TryParse(Configuration.GetSection(key).Value, out keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    else if (valueType == typeof(long))
                    {
                        long keyValue = default(long);
                        if (long.TryParse(Configuration.GetSection(key).Value, out keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    else if (valueType == typeof(byte))
                    {
                        byte keyValue = default(byte);
                        if (byte.TryParse(Configuration.GetSection(key).Value, out keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    else if (valueType == typeof(bool))
                    {
                        bool keyValue = default(bool);
                        if (bool.TryParse(Configuration.GetSection(key).Value, out keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    else if (valueType == typeof(string))
                    {
                        string keyValue = Configuration.GetSection(key).Value;
                        if (!string.IsNullOrWhiteSpace(keyValue))
                            result = keyValue;
                        else
                            result = defaultvalue;
                    }
                    #endregion
                    #region Getting the value.
                    value = (T)Convert.ChangeType(result, valueType);
                    #endregion
                }

                #endregion
            }
            catch (Exception exception)
            {

            }
            return value;
        }

        public static AppSetting AppSetting { get; set; }


        #endregion
    }
}
