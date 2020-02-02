using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using Microsoft.AspNetCore.Mvc;


namespace JobSeekerProfessionalInformationManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class JobSeekerProfessionalInformationController : CommonBaseAPIController
        {

            public IJobSeekerProfessionalInformationAppService JobSeekerProfessionalInformationAppService { get; }

            public JobSeekerProfessionalInformationController(IJobSeekerProfessionalInformationAppService jobSeekerProfessionalInformationAppService)
            {
                JobSeekerProfessionalInformationAppService = jobSeekerProfessionalInformationAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<JobSeekerProfessionalInformationReturnDTO>>> GetAllJobSeekerProfessionalInformations()
            {
                #region Declare Return Var With Intial Value
                List<JobSeekerProfessionalInformationReturnDTO> JobSeekerProfessionalInformationReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    JobSeekerProfessionalInformationReturnDTOList = await JobSeekerProfessionalInformationAppService.GetAllJobSeekerProfessionalInformations();
                    #region Validate JobSeekerProfessionalInformationReturnDTOList for nullability before prepaing the response.
                    if (JobSeekerProfessionalInformationReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerProfessionalInformationReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<JobSeekerProfessionalInformationReturnDTO>>> GetJobSeekerProfessionalInformationById(int id)
            {
                #region Vars
                JobSeekerProfessionalInformationReturnDTO JobSeekerProfessionalInformationReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        JobSeekerProfessionalInformationReturnDTO = await JobSeekerProfessionalInformationAppService.GetJobSeekerProfessionalInformationById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (JobSeekerProfessionalInformationReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), JobSeekerProfessionalInformationReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO JobSeekerProfessionalInformationAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddJobSeekerProfessionalInformation for nullability before prepaing the response.

                    if (await JobSeekerProfessionalInformationAppService.AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO JobSeekerProfessionalInformationUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await JobSeekerProfessionalInformationAppService.UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int JobSeekerProfessionalInformationId)
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
                        if (await JobSeekerProfessionalInformationAppService.DeleteJobSeekerProfessionalInformation(JobSeekerProfessionalInformationId))
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




