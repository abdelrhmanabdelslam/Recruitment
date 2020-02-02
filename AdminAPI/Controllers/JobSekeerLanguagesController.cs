using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using Microsoft.AspNetCore.Mvc;


namespace JobSekeerLanguagesManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class JobSekeerLanguagesController : CommonBaseAPIController
        {

            public IJobSekeerLanguagesAppService JobSekeerLanguagesAppService { get; }

            public JobSekeerLanguagesController(IJobSekeerLanguagesAppService jobSekeerLanguagesAppService)
            {
                JobSekeerLanguagesAppService = jobSekeerLanguagesAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<JobSekeerLanguagesReturnDTO>>> GetAllJobSekeerLanguagess()
            {
                #region Declare Return Var With Intial Value
                List<JobSekeerLanguagesReturnDTO> JobSekeerLanguagesReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    JobSekeerLanguagesReturnDTOList = await JobSekeerLanguagesAppService.GetAllJobSekeerLanguagess();
                    #region Validate JobSekeerLanguagesReturnDTOList for nullability before prepaing the response.
                    if (JobSekeerLanguagesReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSekeerLanguagesReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<JobSekeerLanguagesReturnDTO>>> GetJobSekeerLanguagesById(int id)
            {
                #region Vars
                JobSekeerLanguagesReturnDTO JobSekeerLanguagesReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        JobSekeerLanguagesReturnDTO = await JobSekeerLanguagesAppService.GetJobSekeerLanguagesById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (JobSekeerLanguagesReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSekeerLanguagesReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddJobSekeerLanguages(JobSekeerLanguagesAddDTO JobSekeerLanguagesAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddJobSekeerLanguages for nullability before prepaing the response.

                    if (await JobSekeerLanguagesAppService.AddJobSekeerLanguages(JobSekeerLanguagesAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO JobSekeerLanguagesUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await JobSekeerLanguagesAppService.UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int JobSekeerLanguagesId)
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
                        if (await JobSekeerLanguagesAppService.DeleteJobSekeerLanguages(JobSekeerLanguagesId))
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




