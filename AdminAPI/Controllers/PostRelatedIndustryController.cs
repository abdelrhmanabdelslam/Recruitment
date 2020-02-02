using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostRelatedIndustryDTOS;
using Microsoft.AspNetCore.Mvc;


namespace PostRelatedIndustryManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PostRelatedIndustryController : CommonBaseAPIController
        {

            public IPostRelatedIndustryAppService PostRelatedIndustryAppService { get; }

            public PostRelatedIndustryController(IPostRelatedIndustryAppService postRelatedIndustryAppService)
            {
                PostRelatedIndustryAppService = postRelatedIndustryAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<PostRelatedIndustryReturnDTO>>> GetAllPostRelatedIndustrys()
            {
                #region Declare Return Var With Intial Value
                List<PostRelatedIndustryReturnDTO> PostRelatedIndustryReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    PostRelatedIndustryReturnDTOList = await PostRelatedIndustryAppService.GetAllPostRelatedIndustrys();
                    #region Validate PostRelatedIndustryReturnDTOList for nullability before prepaing the response.
                    if (PostRelatedIndustryReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), PostRelatedIndustryReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<PostRelatedIndustryReturnDTO>>> GetPostRelatedIndustryById(int id)
            {
                #region Vars
                PostRelatedIndustryReturnDTO PostRelatedIndustryReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        PostRelatedIndustryReturnDTO = await PostRelatedIndustryAppService.GetPostRelatedIndustryById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (PostRelatedIndustryReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), PostRelatedIndustryReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddPostRelatedIndustry(PostRelatedIndustryAddDTO PostRelatedIndustryAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddPostRelatedIndustry for nullability before prepaing the response.

                    if (await PostRelatedIndustryAppService.AddPostRelatedIndustry(PostRelatedIndustryAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO PostRelatedIndustryUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await PostRelatedIndustryAppService.UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int PostRelatedIndustryId)
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
                        if (await PostRelatedIndustryAppService.DeletePostRelatedIndustry(PostRelatedIndustryId))
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




