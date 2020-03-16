using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using TripleDES = IPMATS.Common.Helper.TripleDES;
using Microsoft.AspNetCore.Mvc.Filters;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;
using Recruitment.Common.Helper;

namespace IPMATS.Common.Auth
{
    public class TokenHandler
    {
        #region Properties
        private static TripleDES TripleDESObj = null;

        //private static ICurrentUser CurrentUser = null;

        #endregion
        #region Constructor
        static TokenHandler()
        {
            // CurrentUser = new CurrentUser();
            TripleDESObj = new TripleDES(ConfigHelper.AppSetting.TDESKeyList.FirstOrDefault());
        }
        #endregion


        /// <summary>
        /// create token
        /// </summary>
        /// <param name="loggedUser"></param>
        /// <returns></returns>
        public static RefreshTokenDTO CreateToken(UserDTO loggedUser)
        {
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { 
                new Claim(ClaimTypes.Email, TripleDESObj.Encrypt( loggedUser.Email.ToString())),
                 new Claim(ClaimTypes.Sid, TripleDESObj.Encrypt( loggedUser.UserId.ToString()))
                }),
                Expires = DateTime.Now.AddMinutes(Convert.ToInt32(ConfigHelper.AppSetting.TokenExpireInMinutesList.FirstOrDefault())),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKeyList.FirstOrDefault())), SecurityAlgorithms.HmacSha256),
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken jwtToken = tokenHandler.CreateToken(tokenDescriptor);
            return new RefreshTokenDTO()
            {
                Token = tokenHandler.WriteToken(jwtToken),
                RefreshToken = BuildRefreshToken()
            };
        }


        private static string BuildRefreshToken()
        {
            PasswordHandler passwordHandler = new PasswordHandler();
            return passwordHandler.CreatePasswordHash(Guid.NewGuid().ToString());
        }

        /// <summary>
        /// get userid from token
        /// </summary>
        /// <param name="context"></param>
        /// <returns>CurrentUser</returns>
        public static CurrentUser GetCurrentUserId(string token)
        {
            #region Declare a return type with initial value.
            CurrentUser currentUser = null;
            #endregion
            try
            {
                #region Validate Parameters
                if (token != null)
                {
                    #region Vars
                    SecurityToken validatedToken;
                    int userId = default(int);
                    short postOfficeId = default(short);
                    int roleId = default(int);
                    #endregion

                    // IdentityModelEventSource.ShowPII = true;
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKeyList.FirstOrDefault()))
                    };

                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        currentUser = new CurrentUser();
                        ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validatedToken);
                        string Sub = principal.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(c => c.Value).SingleOrDefault();
                        if (int.TryParse(new TripleDES(ConfigHelper.AppSetting.TDESKeyList.FirstOrDefault()).Decrypt(Sub), out userId))
                        {
                            currentUser.UserId = userId;
                        }
                        string Email = principal.Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault();
                        if (!string.IsNullOrWhiteSpace(Email))
                        {
                            currentUser.Email = Email;
                        }
                      
                    }
                }
                #endregion
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogException(exception, LogLevel.Medium);
            }
            return currentUser;
        }
        /// <summary>
        /// get userid from token
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static int GetCurrentRoleId(string token)
        {
            #region Declare a return type with initial value.
            int result = default(int);
            #endregion
            try
            {
                #region Validate Parameters
                if (token != null)
                {
                    #region Vars
                    SecurityToken validatedToken;
                    int roleId = default(int);
                    #endregion

                    // IdentityModelEventSource.ShowPII = true;
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKeyList.FirstOrDefault()))
                    };

                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validatedToken);
                        string Sub = principal.Claims.Where(c => c.Type == "RoleId").Select(c => c.Value).SingleOrDefault();
                        if (int.TryParse(Sub, out roleId))
                        {
                            result = roleId;
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
        /// <summary>
        /// get userid from token
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static int GetCurrentPostOfficeId(string token)
        {
            #region Declare a return type with initial value.
            int result = default(int);
            #endregion
            try
            {
                #region Validate Parameters
                if (token != null)
                {
                    #region Vars
                    SecurityToken validatedToken;
                    int postOfficeId = default(int);
                    #endregion

                    // IdentityModelEventSource.ShowPII = true;
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ConfigHelper.AppSetting.TokenSecurityKeyList.FirstOrDefault()))
                    };

                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validatedToken);
                        string Sub = principal.Claims.Where(c => c.Type == "PostOfficeId").Select(c => c.Value).SingleOrDefault();
                        if (int.TryParse(Sub, out postOfficeId))
                        {
                            result = postOfficeId;
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