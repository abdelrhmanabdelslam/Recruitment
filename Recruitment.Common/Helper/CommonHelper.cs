using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;
using System.Text;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;
namespace Recruitment.Common.Helper
{
    public static class CommonHelper
    {
        #region Methods
        /// <summary>
        /// Get response message
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiResponseMessage"></param>
        /// <returns>string</returns>
        public static string GetResponseMessage(APIResponseMessage apiResponseMessage, string currentLanguage)
        {
            #region Declare a return type with initial value.
            string responseMessage = string.Empty;
            #endregion
            try
            {
                // refactor to add Localization to Messages
                responseMessage = apiResponseMessage.ToString();
            }
            catch (System.Exception exception)
            {
                //Logger.Instance.LogException(exception, exception.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return responseMessage;

        }
        /// <summary>
        /// Prepare Response json object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">Response message</param>
        /// <param name="innerData">Response data</param>
        /// <param name="httpStatusCode">Response StatusCode</param>
        /// <returns>JsonResult</returns>
        public static CommonBusinessDTO<T> CommonBusinessDTOResponse<T>(APIResponseMessage message, T innerData, HttpStatusCode httpStatusCode, APIResponseMessage aPIResponseMessage)
        {
            #region Declare a return type with initial value.
            CommonBusinessDTO<T> commonBusinessDTO = null;
            #endregion
            try
            {
                commonBusinessDTO = new CommonBusinessDTO<T>() { Message = message, InnerData = innerData, HttpStatusCode = httpStatusCode, APIResponseCode = aPIResponseMessage };
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, exception.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return commonBusinessDTO;
        }
        /// <summary>
        /// Generate unique number
        /// </summary>
        /// <returns></returns>
        public static string GenerateUniqueNumber()
        {
            #region Declare a return type with initial value.
            string result = null;
            #endregion
            try
            {
                result = BitConverter.ToUInt32(Guid.NewGuid().ToByteArray(), 8).ToString();
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, exception.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return result;
        }
        #endregion
    }
}
