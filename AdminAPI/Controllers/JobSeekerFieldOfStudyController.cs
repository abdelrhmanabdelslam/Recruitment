using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using Microsoft.AspNetCore.Mvc;


namespace JobSeekerFieldOfStudyManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class JobSeekerFieldOfStudyController : CommonBaseAPIController
        {

            public IJobSeekerFieldOfStudyAppService JobSeekerFieldOfStudyAppService { get; }

            public JobSeekerFieldOfStudyController(IJobSeekerFieldOfStudyAppService jobSeekerFieldOfStudyAppService)
            {
                JobSeekerFieldOfStudyAppService = jobSeekerFieldOfStudyAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<JobSeekerFieldOfStudyReturnDTO>>> GetAllJobSeekerFieldOfStudys()
            {
                #region Declare Return Var With Intial Value
                List<JobSeekerFieldOfStudyReturnDTO> JobSeekerFieldOfStudyReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    JobSeekerFieldOfStudyReturnDTOList = await JobSeekerFieldOfStudyAppService.GetAllJobSeekerFieldOfStudys();
                    #region Validate JobSeekerFieldOfStudyReturnDTOList for nullability before prepaing the response.
                    if (JobSeekerFieldOfStudyReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerFieldOfStudyReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<JobSeekerFieldOfStudyReturnDTO>>> GetJobSeekerFieldOfStudyById(int id)
            {
                #region Vars
                JobSeekerFieldOfStudyReturnDTO JobSeekerFieldOfStudyReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        JobSeekerFieldOfStudyReturnDTO = await JobSeekerFieldOfStudyAppService.GetJobSeekerFieldOfStudyById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (JobSeekerFieldOfStudyReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerFieldOfStudyReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO JobSeekerFieldOfStudyAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddJobSeekerFieldOfStudy for nullability before prepaing the response.

                    if (await JobSeekerFieldOfStudyAppService.AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO JobSeekerFieldOfStudyUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await JobSeekerFieldOfStudyAppService.UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int JobSeekerFieldOfStudyId)
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
                        if (await JobSeekerFieldOfStudyAppService.DeleteJobSeekerFieldOfStudy(JobSeekerFieldOfStudyId))
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




