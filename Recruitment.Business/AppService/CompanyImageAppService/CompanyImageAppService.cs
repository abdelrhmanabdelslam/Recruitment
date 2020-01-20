using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyImageDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyImageAppService : BaseAppService, ICompanyImageAppService
    {
        #region Properties
        public ICompanyImageBusinessMapping CompanyImageBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyImageAppService(ICompanyImageBusinessMapping companyImageBusinessMapping)
        {
            CompanyImageBusinessMapping = companyImageBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyImage ActionActivity Logs for All CompanyImages
        /// </summary>
        /// <returns>List<CompanyImageReturnDTO></returns>
        public async Task<List<CompanyImageReturnDTO>> GetAllCompanyImages()
        {
            #region Declare a return type with initial value.
            List<CompanyImageReturnDTO> allCompanyImages = null;
            #endregion
            try
            {
                allCompanyImages = await CompanyImageBusinessMapping.GetAllCompanyImages();
            }
            catch (Exception exception)  {}
            return allCompanyImages;
        }
        /// <summary>
        /// Add CompanyImage AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyImage(CompanyImageAddDTO companyImageAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyImageAddDTO != null)
                {
                    isCreated = await CompanyImageBusinessMapping.AddCompanyImage(companyImageAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyImage By Id 
        /// </summary>
        /// <returns>CompanyImageReturnDTO<CompanyImageReturnDTO></returns>
        public async Task<CompanyImageReturnDTO> GetCompanyImageById(int CompanyImageId)
        {
            #region Declare a return type with initial value.
            CompanyImageReturnDTO CompanyImage = null;
            #endregion
            try
            {
                if (CompanyImageId > default(int))
                {
                    CompanyImage = await CompanyImageBusinessMapping.GetCompanyImageById(CompanyImageId);
                }
            }
            catch (Exception exception)  {}
            return CompanyImage;
        }
        /// <summary>
        /// Updae CompanyImage AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyImage(CompanyImageUpdateDTO companyImageUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyImageUpdateDTO != null)
                {
                    isUpdated = await CompanyImageBusinessMapping.UpdateCompanyImage(companyImageUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyImage AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyImage(int CompanyImageId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyImageId > default(int))
                {
                    isDeleted = await CompanyImageBusinessMapping.DeleteCompanyImage(CompanyImageId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




