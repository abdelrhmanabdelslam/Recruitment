
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using static Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;
//using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;

namespace Recruitment.Common.Base
{
    public abstract class CommonBaseAPIController : ControllerBase
    {
        #region Properties
        public string CurrentLanguagId => ConfigHelper.DefaultLocalization;
        #endregion
        #region Methods
        /// <summary>
        /// Initialize response json object with default value.
        /// </summary>
        /// <returns>JsonResult</returns>
        public JsonResult GetDefaultJsonResult<T>()
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                jsonResult = new JsonResult(new CommonAPIResponse<object>()
                {
                    Message = CommonHelper.GetResponseMessage(APIResponseMessage.InternalServerError, CurrentLanguagId),
                    InnerData = new object()
                });
                jsonResult.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            catch (System.Exception exception)
            {
                 
            }
            return jsonResult;
        }
        /// <summary>
        /// Get invalid data for given model in json result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="modelKeys"></param>
        /// <returns>JsonResult</returns>
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
                    jsonResult = JsonResultResponse($"{string.Format(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidParameters, CurrentLanguagId), string.Empty)}", Activator.CreateInstance<T>(), HttpStatusCode.BadRequest);
                }
            }
            catch (System.Exception exception)
            {
                 
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
                 
            }
            return jsonResult;
        }
        /// <summary>
        /// Prepare Response json object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commonBusinessDTO">Response</param>
        /// <returns>JsonResult</returns>
        public JsonResult JsonResultResponse<T>(CommonBusinessDTO<T> commonBusinessDTO)
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = null;
            #endregion
            try
            {
                jsonResult = new JsonResult(new CommonAPIResponse<T>() { Message = CommonHelper.GetResponseMessage(commonBusinessDTO.Message, CurrentLanguagId), InnerData = commonBusinessDTO.InnerData });
                jsonResult.StatusCode = (int)commonBusinessDTO.HttpStatusCode;
            }
            catch (System.Exception exception)
            {
                 
            }
            return jsonResult;
        }
        /// <summary>
        /// Getting the services response.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="httpStatusCode"></param>
        /// <returns>JsonResult</returns>
        public JsonResult GetReponse<T>(T input, HttpStatusCode httpStatusCode)
        {
            #region Declare a return type with initial value.
            JsonResult jsonResult = new JsonResult("");
            #endregion
            try
            {
                jsonResult.Value = input;
                jsonResult.StatusCode = (int)httpStatusCode;
            }
            catch (System.Exception exception)
            {
                 
            }
            return jsonResult;
        }
        #endregion
    }
}
