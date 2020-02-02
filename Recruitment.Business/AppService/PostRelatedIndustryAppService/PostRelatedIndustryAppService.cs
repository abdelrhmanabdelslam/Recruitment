using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.PostRelatedIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class PostRelatedIndustryAppService : BaseAppService, IPostRelatedIndustryAppService
    {
        #region Properties
        public IPostRelatedIndustryBusinessMapping PostRelatedIndustryBusinessMapping { get; }
        #endregion

        #region Constructor
        public PostRelatedIndustryAppService(IPostRelatedIndustryBusinessMapping postRelatedIndustryBusinessMapping)
        {
            PostRelatedIndustryBusinessMapping = postRelatedIndustryBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All PostRelatedIndustry ActionActivity Logs for All PostRelatedIndustrys
        /// </summary>
        /// <returns>List<PostRelatedIndustryReturnDTO></returns>
        public async Task<List<PostRelatedIndustryReturnDTO>> GetAllPostRelatedIndustrys()
        {
            #region Declare a return type with initial value.
            List<PostRelatedIndustryReturnDTO> allPostRelatedIndustrys = null;
            #endregion
            try
            {
                allPostRelatedIndustrys = await PostRelatedIndustryBusinessMapping.GetAllPostRelatedIndustrys();
            }
            catch (Exception exception)  {}
            return allPostRelatedIndustrys;
        }
        /// <summary>
        /// Add PostRelatedIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddPostRelatedIndustry(PostRelatedIndustryAddDTO postRelatedIndustryAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (postRelatedIndustryAddDTO != null)
                {
                    isCreated = await PostRelatedIndustryBusinessMapping.AddPostRelatedIndustry(postRelatedIndustryAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  PostRelatedIndustry By Id 
        /// </summary>
        /// <returns>PostRelatedIndustryReturnDTO<PostRelatedIndustryReturnDTO></returns>
        public async Task<PostRelatedIndustryReturnDTO> GetPostRelatedIndustryById(int PostRelatedIndustryId)
        {
            #region Declare a return type with initial value.
            PostRelatedIndustryReturnDTO PostRelatedIndustry = null;
            #endregion
            try
            {
                if (PostRelatedIndustryId > default(int))
                {
                    PostRelatedIndustry = await PostRelatedIndustryBusinessMapping.GetPostRelatedIndustryById(PostRelatedIndustryId);
                }
            }
            catch (Exception exception)  {}
            return PostRelatedIndustry;
        }
        /// <summary>
        /// Updae PostRelatedIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO postRelatedIndustryUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (postRelatedIndustryUpdateDTO != null)
                {
                    isUpdated = await PostRelatedIndustryBusinessMapping.UpdatePostRelatedIndustry(postRelatedIndustryUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete PostRelatedIndustry AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeletePostRelatedIndustry(int PostRelatedIndustryId)
        {
            bool isDeleted = false;
            try
            {
                if (PostRelatedIndustryId > default(int))
                {
                    isDeleted = await PostRelatedIndustryBusinessMapping.DeletePostRelatedIndustry(PostRelatedIndustryId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




