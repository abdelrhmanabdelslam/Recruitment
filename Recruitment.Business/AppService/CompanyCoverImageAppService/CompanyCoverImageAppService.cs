using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyCoverImageDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyCoverImageAppService : BaseAppService, ICompanyCoverImageAppService
    {
        #region Properties
        public ICompanyCoverImageBusinessMapping CompanyCoverImageBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyCoverImageAppService(ICompanyCoverImageBusinessMapping companyCoverImageBusinessMapping)
        {
            CompanyCoverImageBusinessMapping = companyCoverImageBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyCoverImage ActionActivity Logs for All CompanyCoverImages
        /// </summary>
        /// <returns>List<CompanyCoverImageReturnDTO></returns>
        public async Task<List<CompanyCoverImageReturnDTO>> GetAllCompanyCoverImages()
        {
            #region Declare a return type with initial value.
            List<CompanyCoverImageReturnDTO> allCompanyCoverImages = null;
            #endregion
            try
            {
                allCompanyCoverImages = await CompanyCoverImageBusinessMapping.GetAllCompanyCoverImages();
            }
            catch (Exception exception)  {}
            return allCompanyCoverImages;
        }
        /// <summary>
        /// Add CompanyCoverImage AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyCoverImage(CompanyCoverImageAddDTO companyCoverImageAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyCoverImageAddDTO != null)
                {
                    isCreated = await CompanyCoverImageBusinessMapping.AddCompanyCoverImage(companyCoverImageAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyCoverImage By Id 
        /// </summary>
        /// <returns>CompanyCoverImageReturnDTO<CompanyCoverImageReturnDTO></returns>
        public async Task<CompanyCoverImageReturnDTO> GetCompanyCoverImageById(int CompanyCoverImageId)
        {
            #region Declare a return type with initial value.
            CompanyCoverImageReturnDTO CompanyCoverImage = null;
            #endregion
            try
            {
                if (CompanyCoverImageId > default(int))
                {
                    CompanyCoverImage = await CompanyCoverImageBusinessMapping.GetCompanyCoverImageById(CompanyCoverImageId);
                }
            }
            catch (Exception exception)  {}
            return CompanyCoverImage;
        }
        /// <summary>
        /// Updae CompanyCoverImage AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyCoverImage(CompanyCoverImageUpdateDTO companyCoverImageUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyCoverImageUpdateDTO != null)
                {
                    isUpdated = await CompanyCoverImageBusinessMapping.UpdateCompanyCoverImage(companyCoverImageUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyCoverImage AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyCoverImage(int CompanyCoverImageId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyCoverImageId > default(int))
                {
                    isDeleted = await CompanyCoverImageBusinessMapping.DeleteCompanyCoverImage(CompanyCoverImageId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




