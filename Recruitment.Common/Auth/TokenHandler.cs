using IPMATS.Common.Helper;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using IPMATS.Common.Enums;
using System.Security.Cryptography;
using TripleDES = IPMATS.Common.Helper.TripleDES;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;

namespace IPMATS.Common.Auth
{
    public class TokenHandler
    {
        #region Properties
        private static TripleDES TripleDESObj = null;
        #endregion
        #region Constructor
        static TokenHandler()
        {
            TripleDESObj = new TripleDES(ConfigHelper.AppSetting.TDESKey.FirstOrDefault());
        }
        #endregion


        /// <summary>
        /// create token
        /// </summary>
        /// <param name="loggedUser"></param>
        /// <returns></returns>
        public static string CreateToken(UserDTO loggedUser)
        {
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Role, TripleDESObj.Encrypt( loggedUser.RoleId.ToString())),
                new Claim(ClaimTypes.Role, TripleDESObj.Encrypt( loggedUser.UserId.ToString())),
                new Claim(ClaimTypes.Role, TripleDESObj.Encrypt( loggedUser.Email.ToString()))
                }),
                Expires = DateTime.Now.AddHours(Convert.ToInt32(ConfigHelper.AppSetting.TokenExpireInHours.FirstOrDefault())),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKey.FirstOrDefault())), SecurityAlgorithms.HmacSha256),
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken jwtToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(jwtToken);
        }

        /// <summary>
        /// get userid from token
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static int GetCurrentUserId(ActionExecutedContext context)
        {
            #region Declare a return type with initial value.
            int result = default(int);
            #endregion
            try
            {
                #region Validate Parameters
                if (context != null)
                {
                    #region Vars
                    SecurityToken validatedToken;
                    int userId = default(int);
                    #endregion
                    string[] requestPath = context.HttpContext.Request.Path.Value.Split("/");
                    // IdentityModelEventSource.ShowPII = true;
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKey.FirstOrDefault()))
                    };
                    string token = context.HttpContext.Request.Headers.FirstOrDefault(em => em.Key == "Authorization").Value.ToString().Replace("Bearer ", "");
                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validatedToken);
                        string Sub = principal.Claims.Where(c => c.Type == "Sub").Select(c => c.Value).SingleOrDefault();
                        if (int.TryParse(new TripleDES(ConfigHelper.AppSetting.TDESKey.FirstOrDefault()).Decrypt(Sub), out userId))
                        {
                            result = userId;
                        }
                    }
                }
                #endregion
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, LogLevel.Medium);
            }
            return result;
        }
    }
}