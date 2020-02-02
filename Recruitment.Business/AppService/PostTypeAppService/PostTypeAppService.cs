using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.PostTypeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class PostTypeAppService : BaseAppService, IPostTypeAppService
    {
        #region Properties
        public IPostTypeBusinessMapping PostTypeBusinessMapping { get; }
        #endregion

        #region Constructor
        public PostTypeAppService(IPostTypeBusinessMapping postTypeBusinessMapping)
        {
            PostTypeBusinessMapping = postTypeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All PostType ActionActivity Logs for All PostTypes
        /// </summary>
        /// <returns>List<PostTypeReturnDTO></returns>
        public async Task<List<PostTypeReturnDTO>> GetAllPostTypes()
        {
            #region Declare a return type with initial value.
            List<PostTypeReturnDTO> allPostTypes = null;
            #endregion
            try
            {
                allPostTypes = await PostTypeBusinessMapping.GetAllPostTypes();
            }
            catch (Exception exception)  {}
            return allPostTypes;
        }
        /// <summary>
        /// Add PostType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddPostType(PostTypeAddDTO postTypeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (postTypeAddDTO != null)
                {
                    isCreated = await PostTypeBusinessMapping.AddPostType(postTypeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  PostType By Id 
        /// </summary>
        /// <returns>PostTypeReturnDTO<PostTypeReturnDTO></returns>
        public async Task<PostTypeReturnDTO> GetPostTypeById(int PostTypeId)
        {
            #region Declare a return type with initial value.
            PostTypeReturnDTO PostType = null;
            #endregion
            try
            {
                if (PostTypeId > default(int))
                {
                    PostType = await PostTypeBusinessMapping.GetPostTypeById(PostTypeId);
                }
            }
            catch (Exception exception)  {}
            return PostType;
        }
        /// <summary>
        /// Updae PostType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdatePostType(PostTypeUpdateDTO postTypeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (postTypeUpdateDTO != null)
                {
                    isUpdated = await PostTypeBusinessMapping.UpdatePostType(postTypeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete PostType AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeletePostType(int PostTypeId)
        {
            bool isDeleted = false;
            try
            {
                if (PostTypeId > default(int))
                {
                    isDeleted = await PostTypeBusinessMapping.DeletePostType(PostTypeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




