using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Recruitment.Business.AppService;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.AdminDTOS;
using Microsoft.AspNetCore.Mvc;
using IPMATS.Common.Auth;
using Microsoft.AspNetCore.Authorization;

namespace AdminManagmentAPI.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]

    public class AdminController : CommonBaseAPIController
        {

            public IAdminAppService AdminAppService { get; }

            public AdminController(IAdminAppService adminAppService)
            {
                AdminAppService = adminAppService;
            }
            // GET: api/<controller>
            [HttpGet]
            public async Task<ActionResult<CommonAPIResponse<AdminReturnDTO>>> GetAllAdmins()
            {
                #region Declare Return Var With Intial Value
                List<AdminReturnDTO> AdminReturnDTOList = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {
                    AdminReturnDTOList = await AdminAppService.GetAllAdmins();
                    #region Validate AdminReturnDTOList for nullability before prepaing the response.
                    if (AdminReturnDTOList != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), AdminReturnDTOList, HttpStatusCode.OK);
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
            public async Task<ActionResult<CommonAPIResponse<AdminReturnDTO>>> GetAdminById(int id)
            {
                #region Vars
                AdminReturnDTO AdminReturnDTO = null;
                #endregion
                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<object>();
                #endregion
                try
                {

                    if (id != default(int))
                        AdminReturnDTO = await AdminAppService.GetAdminById(id);

                    #region Validate userIdentityDTO for nullability before prepaing the response.
                    if (AdminReturnDTO != null)
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), AdminReturnDTO, HttpStatusCode.OK);
                    else
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), new object(), HttpStatusCode.BadRequest);
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
   [HttpPost]
        [AllowAnonymous]
        public async Task<UserDTO> LoginUser(UserLoginDTO userLoginDTO)
        {
            #region Vars
            #region Declare return type with initial value.
            JsonResult jsonResult = GetDefaultJsonResult<UserDTO>();
            #endregion
            #endregion
            #region Vars
            UserDTO userReturnDTO = new UserDTO();
            #endregion

            try
            {
                #region Validate Parrameters
                if (ModelState.IsValid)
                {
                   
                    #region login user with userLoginDTO
                    userReturnDTO = await AdminAppService.AdminLoginAsync(userLoginDTO);
                    #endregion
                    #region Validate userLoginDTO for nullability before prepaing the response.
                    if (userReturnDTO != null)
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), userReturnDTO, HttpStatusCode.OK);
                    }
                    else
                    {
                        jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), new object(), HttpStatusCode.BadRequest);
                    }
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
                //Logger.Instance.LogException(exception, CurrentUser.UserId.ToString(), MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }

            return userReturnDTO;
        }

        //[HttpPost]
        //    [AllowAnonymous]
        //public async Task<ActionResult<CommonAPIResponse<object>>> AdminLoginAsync([FromBody]UserLoginDTO adminLoginDTO)
        //    {
        //    #region Vars
        //        UserDTO userDTO = null;
        //        #endregion
        //        #region Declare return type with initial value.
        //        JsonResult jsonResult = GetDefaultJsonResult<UserDTO>();
        //        #endregion
        //        try
        //        {

        //            if (adminLoginDTO != null)
        //                userDTO = await AdminAppService.AdminLoginAsync(adminLoginDTO);

        //            #region Validate userIdentityDTO for nullability before prepaing the response.
        //            if (userDTO != null)
        //                jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.Success, CurrentLanguagId), userDTO, HttpStatusCode.OK);
        //            else
        //                jsonResult = JsonResultResponse(CommonHelper.GetResponseMessage(APIResponseMessage.InvalidCredentials, CurrentLanguagId), new object(), HttpStatusCode.BadRequest);
        //            #endregion
        //        }
        //        catch (Exception exception)
        //        {

        //        }
        //        return jsonResult;
        //    }
        // POST api/<controller>
        [HttpPost]
            public async Task<ActionResult<CommonAPIResponse<bool>>> AddAdmin(AdminAddDTO AdminAddDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate AddAdmin for nullability before prepaing the response.

                    if (await AdminAppService.AddAdmin(AdminAddDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> UpdateAdmin(AdminUpdateDTO AdminUpdateDTO)
            {

                #region Declare return type with initial value.
                JsonResult jsonResult = GetDefaultJsonResult<bool>();
                #endregion

                try
                {
                    #region Validate userUpdateDTO for nullability before prepaing the response.
                    if (await AdminAppService.UpdateAdmin(AdminUpdateDTO))
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
            public async Task<ActionResult<CommonAPIResponse<bool>>> Delete(int AdminId)
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
                        if (await AdminAppService.DeleteAdmin(AdminId))
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




