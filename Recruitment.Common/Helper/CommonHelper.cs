using Recruitment.Common.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
        public static string GetResponseMessage(APIResponseMessage apiResponseMessage, string language)
        {
            #region Declare a return type with initial value.
            string responseMessage = string.Empty;
            #endregion
            try
            {
                responseMessage = ConfigHelper.Configuration.GetSection($"{language}")[apiResponseMessage.ToString()];
            }
            catch (System.Exception exception)
            {
                
            }
            return responseMessage;
        }
        /// <summary>
        /// Get response message
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiResponseMessage"></param>
        /// <returns>string</returns>
        public static string GetResponseMessage(string apiResponseMessage, string language)
        {
            #region Declare a return type with initial value.
            string responseMessage = string.Empty;
            #endregion
            try
            {
                responseMessage = ConfigHelper.Configuration.GetSection($"{language}")[apiResponseMessage];
            }
            catch (System.Exception exception)
            {
                
            }
            return responseMessage;
        }
        /// <summary>
        /// Initialize CommonBusinessDTO object with default value.
        /// </summary>
        /// <returns>JsonResult</returns>
        public static CommonBusinessDTO<T> GetDefaultCommonBusinessDTO<T>()
        {
            #region Declare a return type with initial value.
            CommonBusinessDTO<T> commonBusinessDTO = null;
            #endregion
            try
            {
                commonBusinessDTO = new CommonBusinessDTO<T>()
                {
                    Message = APIResponseMessage.InternalServerError,
                    InnerData = (T)Activator.CreateInstance(typeof(T)),
                    HttpStatusCode = HttpStatusCode.InternalServerError
                };
            }
            catch (System.Exception exception)
            {
                
            }
            return commonBusinessDTO;
        }
        /// <summary>
        /// Prepare Response json object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">Response message</param>
        /// <param name="innerData">Response data</param>
        /// <param name="httpStatusCode">Response StatusCode</param>
        /// <returns>JsonResult</returns>
        public static CommonBusinessDTO<T> CommonBusinessDTOResponse<T>(APIResponseMessage message, T innerData, HttpStatusCode httpStatusCode)
        {
            #region Declare a return type with initial value.
            CommonBusinessDTO<T> commonBusinessDTO = null;
            #endregion
            try
            {
                commonBusinessDTO = new CommonBusinessDTO<T>() { Message = message, InnerData = innerData, HttpStatusCode = httpStatusCode };
            }
            catch (System.Exception exception)
            {
                
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
                
            }
            return result;
        }
        #endregion
    }
}
