using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using Microsoft.AspNetCore.Mvc;


namespace CompanyOnlinePresenceManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CompanyOnlinePresenceController : CommonBaseAPIController
        {

            public ICompanyOnlinePresenceAppService CompanyOnlinePresenceAppService { get; }

            public CompanyOnlinePresenceController(ICompanyOnlinePresenceAppService companyOnlinePresenceAppService)
            {
                CompanyOnlinePresenceAppService = companyOnlinePresenceAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<CompanyOnlinePresenceReturnDTO>>> GetAllCompanyOnlinePresences()
            {
                #region Declare Return Var With Intial Value
                List<CompanyOnlinePresenceReturnDTO> CompanyOnlinePresenceReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    CompanyOnlinePresenceReturnDTOList = await CompanyOnlinePresenceAppService.GetAllCompanyOnlinePresences();
                    #region Validate CompanyOnlinePresenceReturnDTOList for nullability before prepaing the response.
                    if (CompanyOnlinePresenceReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), CompanyOnlinePresenceReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<CompanyOnlinePresenceReturnDTO>>> GetCompanyOnlinePresenceById(int id)
            {
                #region Vars
                CompanyOnlinePresenceReturnDTO CompanyOnlinePresenceReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        CompanyOnlinePresenceReturnDTO = await CompanyOnlinePresenceAppService.GetCompanyOnlinePresenceById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (CompanyOnlinePresenceReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), CompanyOnlinePresenceReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO CompanyOnlinePresenceAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddCompanyOnlinePresence for nullability before prepaing the response.

                    if (await CompanyOnlinePresenceAppService.AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO CompanyOnlinePresenceUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await CompanyOnlinePresenceAppService.UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int CompanyOnlinePresenceId)
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
                        if (await CompanyOnlinePresenceAppService.DeleteCompanyOnlinePresence(CompanyOnlinePresenceId))
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




