using IPMATS.Common.Helper;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using System;
using System.Net;
using System.Reflection;
using static Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;

namespace Recruitment.Common.Base
{
    public abstract class CommonBaseAPIController : ControllerBase
    {
        #region Properties
        public string CurrentLanguagId => ConfigHelper.DefaultLocalization;
        public int CurrentUserId { get; set; }

        #endregion
        #region Methods
        ///// <summary>
        ///// Initialize response json object with default value.
        ///// </summary>
        ///// <returns>JsonResult</returns>
        //public JsonResult GetDefaultJsonResult<T>()
        //{
        //    #region Declare a return type with initial value.
        //    JsonResult jsonResult = null;
        //    #endregion
        //    try
        //    {
        //        jsonResult = new JsonResult(new CommonAPIResponse<T>()
        //        {
        //            Message = CommonHelper.GetResponseMessage(APIResponseMessage.InternalServerError, CurrentLanguagId),
        //            InnerData = (T)Activator.CreateInstance(typeof(T))
        //        });
        //        jsonResult.StatusCode = (int)HttpStatusCode.InternalServerError;
        //    }
        //    catch (System.Exception exception)
        //    {
        //        Logger.Instance.LogException(exception, LogLevel.Medium);
        //    }
        //    return jsonResult;
        //}
        /// <summary>
        /// Initialize response json object with default value and code
        /// </summary>
        /// <returns>JsonResult</returns>
        public JsonResult GetDefaultJsonResult<T>()
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                jsonResult = new JsonResult(new CommonAPIResponse<T>()
                {
                    Message = CommonHelper.GetResponseMessage(APIResponseMessage.InternalServerError, CurrentLanguagId),
                    InnerData = (T)Activator.CreateInstance(typeof(T)),
                    APIResponseCode = APIResponseMessage.InternalServerError,
                });
                jsonResult.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, LogLevel.Medium);
            }
            return jsonResult;
        }

        ///// <summary>
        ///// Get invalid data for given model in json result.
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="modelKeys"></param>
        ///// <returns>JsonResult</returns>
        //public JsonResult GetInvalidParametersJsonResult<T>(KeyEnumerable modelKeys = default(KeyEnumerable))
        //{
        //    #region Declare a return type with initial value.
        //    JsonResult jsonResult = null;
        //    #endregion
        //    try
        //    {
        //        if (!modelKeys.Equals(default(KeyEnumerable)))
        //        {
        //            jsonResult = JsonResultResponse($"{string.Format(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidData, CurrentLanguagId), $"[{string.Join(", ", modelKeys)}]")}", Activator.CreateInstance<T>(), HttpStatusCode.BadRequest);
        //        }
        //        else
        //        {
        //            jsonResult = JsonResultResponse($"{string.Format(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidParameters, CurrentLanguagId), string.Empty)}", Activator.CreateInstance<T>(), HttpStatusCode.BadRequest);
        //        }
        //    }
        //    catch (System.Exception exception)
        //    {
        //        Logger.Instance.LogException(exception, CurrentUserId.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
        //    }
        //    return jsonResult;
        //}
        public JsonResult GetInvalidParametersJsonResult<T>(KeyEnumerable modelKeys = default(KeyEnumerable))
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                if (!modelKeys.Equals(default(KeyEnumerable)))
                {
                    jsonResult = JsonResultResponse($"{string.Format(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidData, CurrentLanguagId), $"[{string.Join(", ", modelKeys)}]")}", Activator.CreateInstance<T>(), HttpStatusCode.BadRequest);
                }
                else
                {
                    jsonResult = JsonResultResponse($"{string.Format(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidParameters, CurrentLanguagId), string.Empty)}", Activator.CreateInstance<T>(), HttpStatusCode.OK, APIResponseMessage.InternalServerError);
                }
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, CurrentUserId.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return jsonResult;
        }
        /// <summary>
        /// Prepare Response json object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">Response message</param>
        /// <param name="innerData">Response data</param>
        /// <param name="httpStatusCode">Response StatusCode</param>
        /// <returns>JsonResult</returns>
        public JsonResult JsonResultResponse<T>(string message, T innerData, HttpStatusCode httpStatusCode)
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                jsonResult = new JsonResult(new CommonAPIResponse<T>() { Message = message, InnerData = innerData });
                jsonResult.StatusCode = (int)httpStatusCode;
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, CurrentUserId.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return jsonResult;
        }
        /// <summary>
        /// Prepare Response json object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">Response message</param>
        /// <param name="innerData">Response data</param>
        /// <param name="httpStatusCode">Response StatusCode</param>
        /// /// <param name="aPIResponseMessage">APIResponse Code</param>
        /// <returns>JsonResult</returns>
        public JsonResult JsonResultResponse<T>(string message, T innerData, HttpStatusCode httpStatusCode, APIResponseMessage aPIResponseMessage)
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                jsonResult = new JsonResult(new CommonAPIResponse<T>() { Message = message, InnerData = innerData, APIResponseCode = aPIResponseMessage });
                jsonResult.StatusCode = (int)httpStatusCode;
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, CurrentUserId.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return jsonResult;
        }
        #endregion
    }
}
