using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using Microsoft.AspNetCore.Mvc;


namespace JobSeekerTypeOfJobManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class JobSeekerTypeOfJobController : CommonBaseAPIController
        {

            public IJobSeekerTypeOfJobAppService JobSeekerTypeOfJobAppService { get; }

            public JobSeekerTypeOfJobController(IJobSeekerTypeOfJobAppService jobSeekerTypeOfJobAppService)
            {
                JobSeekerTypeOfJobAppService = jobSeekerTypeOfJobAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<JobSeekerTypeOfJobReturnDTO>>> GetAllJobSeekerTypeOfJobs()
            {
                #region Declare Return Var With Intial Value
                List<JobSeekerTypeOfJobReturnDTO> JobSeekerTypeOfJobReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    JobSeekerTypeOfJobReturnDTOList = await JobSeekerTypeOfJobAppService.GetAllJobSeekerTypeOfJobs();
                    #region Validate JobSeekerTypeOfJobReturnDTOList for nullability before prepaing the response.
                    if (JobSeekerTypeOfJobReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerTypeOfJobReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<JobSeekerTypeOfJobReturnDTO>>> GetJobSeekerTypeOfJobById(int id)
            {
                #region Vars
                JobSeekerTypeOfJobReturnDTO JobSeekerTypeOfJobReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        JobSeekerTypeOfJobReturnDTO = await JobSeekerTypeOfJobAppService.GetJobSeekerTypeOfJobById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (JobSeekerTypeOfJobReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerTypeOfJobReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO JobSeekerTypeOfJobAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddJobSeekerTypeOfJob for nullability before prepaing the response.

                    if (await JobSeekerTypeOfJobAppService.AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO JobSeekerTypeOfJobUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await JobSeekerTypeOfJobAppService.UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int JobSeekerTypeOfJobId)
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
                        if (await JobSeekerTypeOfJobAppService.DeleteJobSeekerTypeOfJob(JobSeekerTypeOfJobId))
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




