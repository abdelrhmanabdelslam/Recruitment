using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostIndustryDTOS;
using Microsoft.AspNetCore.Mvc;


namespace PostIndustryManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PostIndustryController : CommonBaseAPIController
        {

            public IPostIndustryAppService PostIndustryAppService { get; }

            public PostIndustryController(IPostIndustryAppService postIndustryAppService)
            {
                PostIndustryAppService = postIndustryAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<PostIndustryReturnDTO>>> GetAllPostIndustrys()
            {
                #region Declare Return Var With Intial Value
                List<PostIndustryReturnDTO> PostIndustryReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    PostIndustryReturnDTOList = await PostIndustryAppService.GetAllPostIndustrys();
                    #region Validate PostIndustryReturnDTOList for nullability before prepaing the response.
                    if (PostIndustryReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), PostIndustryReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<PostIndustryReturnDTO>>> GetPostIndustryById(int id)
            {
                #region Vars
                PostIndustryReturnDTO PostIndustryReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        PostIndustryReturnDTO = await PostIndustryAppService.GetPostIndustryById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (PostIndustryReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), PostIndustryReturnDTO, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddPostIndustry(PostIndustryAddDTO PostIndustryAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddPostIndustry for nullability before prepaing the response.

                    if (await PostIndustryAppService.AddPostIndustry(PostIndustryAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdatePostIndustry(PostIndustryUpdateDTO PostIndustryUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await PostIndustryAppService.UpdatePostIndustry(PostIndustryUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int PostIndustryId)
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
                        if (await PostIndustryAppService.DeletePostIndustry(PostIndustryId))
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




