using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using Microsoft.AspNetCore.Mvc;


namespace CurrentJobSearchStatusManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CurrentJobSearchStatusController : CommonBaseAPIController
        {

            public ICurrentJobSearchStatusAppService CurrentJobSearchStatusAppService { get; }

            public CurrentJobSearchStatusController(ICurrentJobSearchStatusAppService currentJobSearchStatusAppService)
            {
                CurrentJobSearchStatusAppService = currentJobSearchStatusAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<CurrentJobSearchStatusReturnDTO>>> GetAllCurrentJobSearchStatuss()
            {
                #region Declare Return Var With Intial Value
                List<CurrentJobSearchStatusReturnDTO> CurrentJobSearchStatusReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    CurrentJobSearchStatusReturnDTOList = await CurrentJobSearchStatusAppService.GetAllCurrentJobSearchStatuss();
                    #region Validate CurrentJobSearchStatusReturnDTOList for nullability before prepaing the response.
                    if (CurrentJobSearchStatusReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), CurrentJobSearchStatusReturnDTOList, HttpStatusCode.OK);
                    }
                    else
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), new object(), HttpStatusCode.BadRequest);
                    }
                    #endregion
                }
                catch (Exception exception)
                {

                }
                return jsonResult;
            }
            /// <summary>
            /// Get User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns></returns>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<CurrentJobSearchStatusReturnDTO>>> GetCurrentJobSearchStatusById(int id)
            {
                #region Vars
                CurrentJobSearchStatusReturnDTO CurrentJobSearchStatusReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        CurrentJobSearchStatusReturnDTO = await CurrentJobSearchStatusAppService.GetCurrentJobSearchStatusById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (CurrentJobSearchStatusReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), CurrentJobSearchStatusReturnDTO, HttpStatusCode.OK);
                    else
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), new object(), HttpStatusCode.BadRequest);
                    #endregion
                }
                catch (Exception exception)
                {

                }
                return jsonResult;
            }
            // POST api/<controller>
            [HttpPost]
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO CurrentJobSearchStatusAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddCurrentJobSearchStatus for nullability before prepaing the response.

                    if (await CurrentJobSearchStatusAppService.AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO))
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), true, HttpStatusCode.OK);
                    else
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), false, HttpStatusCode.BadRequest);
                    #endregion
                }
                catch (Exception exception)
                {

                }
                return jsonResult;
            }
            // PUT api/<controller>/5
            [HttpPut]
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO CurrentJobSearchStatusUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await CurrentJobSearchStatusAppService.UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO))
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), true, HttpStatusCode.OK);
                    else
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), false, HttpStatusCode.BadRequest);
                    #endregion

                }
                catch (Exception exception)
                {

                }
                return jsonResult;
            }
            // DELETE api/<controller>/5
            [HttpDelete]
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int CurrentJobSearchStatusId)
            {


                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion
                try
                {


                    #region Validate Parrameters
                    if (ModelState.IsValid)
                    {
                        #region Validate userDeleteDTO for nullability before prepaing the response.
                        if (await CurrentJobSearchStatusAppService.DeleteCurrentJobSearchStatus(CurrentJobSearchStatusId))
                            jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), true, HttpStatusCode.OK);
                        else
                            jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), false, HttpStatusCode.BadRequest);
                        #endregion
                    }
                    else
                    {
                        jsonResult = GetInvalidParametersJsonResult<object>(ModelState.Keys);
                    }
                    #endregion
                }
                catch (Exception exception)
                {


                }
                return jsonResult;
            }
        }
    }




