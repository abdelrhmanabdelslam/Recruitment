using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.PostJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class PostJobRoleAppService : BaseAppService, IPostJobRoleAppService
    {
        #region Properties
        public IPostJobRoleBusinessMapping PostJobRoleBusinessMapping { get; }
        #endregion

        #region Constructor
        public PostJobRoleAppService(IPostJobRoleBusinessMapping postJobRoleBusinessMapping)
        {
            PostJobRoleBusinessMapping = postJobRoleBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All PostJobRole ActionActivity Logs for All PostJobRoles
        /// </summary>
        /// <returns>List<PostJobRoleReturnDTO></returns>
        public async Task<List<PostJobRoleReturnDTO>> GetAllPostJobRoles()
        {
            #region Declare a return type with initial value.
            List<PostJobRoleReturnDTO> allPostJobRoles = null;
            #endregion
            try
            {
                allPostJobRoles = await PostJobRoleBusinessMapping.GetAllPostJobRoles();
            }
            catch (Exception exception)  {}
            return allPostJobRoles;
        }
        /// <summary>
        /// Add PostJobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddPostJobRole(PostJobRoleAddDTO postJobRoleAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (postJobRoleAddDTO != null)
                {
                    isCreated = await PostJobRoleBusinessMapping.AddPostJobRole(postJobRoleAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  PostJobRole By Id 
        /// </summary>
        /// <returns>PostJobRoleReturnDTO<PostJobRoleReturnDTO></returns>
        public async Task<PostJobRoleReturnDTO> GetPostJobRoleById(int PostJobRoleId)
        {
            #region Declare a return type with initial value.
            PostJobRoleReturnDTO PostJobRole = null;
            #endregion
            try
            {
                if (PostJobRoleId > default(int))
                {
                    PostJobRole = await PostJobRoleBusinessMapping.GetPostJobRoleById(PostJobRoleId);
                }
            }
            catch (Exception exception)  {}
            return PostJobRole;
        }
        /// <summary>
        /// Updae PostJobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdatePostJobRole(PostJobRoleUpdateDTO postJobRoleUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (postJobRoleUpdateDTO != null)
                {
                    isUpdated = await PostJobRoleBusinessMapping.UpdatePostJobRole(postJobRoleUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete PostJobRole AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeletePostJobRole(int PostJobRoleId)
        {
            bool isDeleted = false;
            try
            {
                if (PostJobRoleId > default(int))
                {
                    isDeleted = await PostJobRoleBusinessMapping.DeletePostJobRole(PostJobRoleId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




