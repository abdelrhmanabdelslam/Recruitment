using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.ReferralDTOS;
using Microsoft.AspNetCore.Mvc;


namespace ReferralManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ReferralController : CommonBaseAPIController
        {

            public IReferralAppService ReferralAppService { get; }

            public ReferralController(IReferralAppService referralAppService)
            {
                ReferralAppService = referralAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<ReferralReturnDTO>>> GetAllReferrals()
            {
                #region Declare Return Var With Intial Value
                List<ReferralReturnDTO> ReferralReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    ReferralReturnDTOList = await ReferralAppService.GetAllReferrals();
                    #region Validate ReferralReturnDTOList for nullability before prepaing the response.
                    if (ReferralReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), ReferralReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<ReferralReturnDTO>>> GetReferralById(int id)
            {
                #region Vars
                ReferralReturnDTO ReferralReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        ReferralReturnDTO = await ReferralAppService.GetReferralById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (ReferralReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), ReferralReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddReferral(ReferralAddDTO ReferralAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddReferral for nullability before prepaing the response.

                    if (await ReferralAppService.AddReferral(ReferralAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateReferral(ReferralUpdateDTO ReferralUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await ReferralAppService.UpdateReferral(ReferralUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int ReferralId)
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
                        if (await ReferralAppService.DeleteReferral(ReferralId))
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




