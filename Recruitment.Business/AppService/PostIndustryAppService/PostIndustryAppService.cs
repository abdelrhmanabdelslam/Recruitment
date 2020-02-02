using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.PostIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class PostIndustryAppService : BaseAppService, IPostIndustryAppService
    {
        #region Properties
        public IPostIndustryBusinessMapping PostIndustryBusinessMapping { get; }
        #endregion

        #region Constructor
        public PostIndustryAppService(IPostIndustryBusinessMapping postIndustryBusinessMapping)
        {
            PostIndustryBusinessMapping = postIndustryBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All PostIndustry ActionActivity Logs for All PostIndustrys
        /// </summary>
        /// <returns>List<PostIndustryReturnDTO></returns>
        public async Task<List<PostIndustryReturnDTO>> GetAllPostIndustrys()
        {
            #region Declare a return type with initial value.
            List<PostIndustryReturnDTO> allPostIndustrys = null;
            #endregion
            try
            {
                allPostIndustrys = await PostIndustryBusinessMapping.GetAllPostIndustrys();
            }
            catch (Exception exception)  {}
            return allPostIndustrys;
        }
        /// <summary>
        /// Add PostIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddPostIndustry(PostIndustryAddDTO postIndustryAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (postIndustryAddDTO != null)
                {
                    isCreated = await PostIndustryBusinessMapping.AddPostIndustry(postIndustryAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  PostIndustry By Id 
        /// </summary>
        /// <returns>PostIndustryReturnDTO<PostIndustryReturnDTO></returns>
        public async Task<PostIndustryReturnDTO> GetPostIndustryById(int PostIndustryId)
        {
            #region Declare a return type with initial value.
            PostIndustryReturnDTO PostIndustry = null;
            #endregion
            try
            {
                if (PostIndustryId > default(int))
                {
                    PostIndustry = await PostIndustryBusinessMapping.GetPostIndustryById(PostIndustryId);
                }
            }
            catch (Exception exception)  {}
            return PostIndustry;
        }
        /// <summary>
        /// Updae PostIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdatePostIndustry(PostIndustryUpdateDTO postIndustryUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (postIndustryUpdateDTO != null)
                {
                    isUpdated = await PostIndustryBusinessMapping.UpdatePostIndustry(postIndustryUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete PostIndustry AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeletePostIndustry(int PostIndustryId)
        {
            bool isDeleted = false;
            try
            {
                if (PostIndustryId > default(int))
                {
                    isDeleted = await PostIndustryBusinessMapping.DeletePostIndustry(PostIndustryId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




