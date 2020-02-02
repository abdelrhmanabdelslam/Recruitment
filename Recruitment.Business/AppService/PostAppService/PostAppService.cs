using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.PostDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class PostAppService : BaseAppService, IPostAppService
    {
        #region Properties
        public IPostBusinessMapping PostBusinessMapping { get; }
        #endregion

        #region Constructor
        public PostAppService(IPostBusinessMapping postBusinessMapping)
        {
            PostBusinessMapping = postBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Post ActionActivity Logs for All Posts
        /// </summary>
        /// <returns>List<PostReturnDTO></returns>
        public async Task<List<PostReturnDTO>> GetAllPosts()
        {
            #region Declare a return type with initial value.
            List<PostReturnDTO> allPosts = null;
            #endregion
            try
            {
                allPosts = await PostBusinessMapping.GetAllPosts();
            }
            catch (Exception exception)  {}
            return allPosts;
        }
        /// <summary>
        /// Add Post AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddPost(PostAddDTO postAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (postAddDTO != null)
                {
                    isCreated = await PostBusinessMapping.AddPost(postAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Post By Id 
        /// </summary>
        /// <returns>PostReturnDTO<PostReturnDTO></returns>
        public async Task<PostReturnDTO> GetPostById(int PostId)
        {
            #region Declare a return type with initial value.
            PostReturnDTO Post = null;
            #endregion
            try
            {
                if (PostId > default(int))
                {
                    Post = await PostBusinessMapping.GetPostById(PostId);
                }
            }
            catch (Exception exception)  {}
            return Post;
        }
        /// <summary>
        /// Updae Post AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdatePost(PostUpdateDTO postUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (postUpdateDTO != null)
                {
                    isUpdated = await PostBusinessMapping.UpdatePost(postUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Post AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeletePost(int PostId)
        {
            bool isDeleted = false;
            try
            {
                if (PostId > default(int))
                {
                    isDeleted = await PostBusinessMapping.DeletePost(PostId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




