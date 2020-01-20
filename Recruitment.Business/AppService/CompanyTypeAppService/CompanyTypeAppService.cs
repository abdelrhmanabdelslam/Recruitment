using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyTypeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyTypeAppService : BaseAppService, ICompanyTypeAppService
    {
        #region Properties
        public ICompanyTypeBusinessMapping CompanyTypeBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyTypeAppService(ICompanyTypeBusinessMapping companyTypeBusinessMapping)
        {
            CompanyTypeBusinessMapping = companyTypeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyType ActionActivity Logs for All CompanyTypes
        /// </summary>
        /// <returns>List<CompanyTypeReturnDTO></returns>
        public async Task<List<CompanyTypeReturnDTO>> GetAllCompanyTypes()
        {
            #region Declare a return type with initial value.
            List<CompanyTypeReturnDTO> allCompanyTypes = null;
            #endregion
            try
            {
                allCompanyTypes = await CompanyTypeBusinessMapping.GetAllCompanyTypes();
            }
            catch (Exception exception)  {}
            return allCompanyTypes;
        }
        /// <summary>
        /// Add CompanyType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyType(CompanyTypeAddDTO companyTypeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyTypeAddDTO != null)
                {
                    isCreated = await CompanyTypeBusinessMapping.AddCompanyType(companyTypeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyType By Id 
        /// </summary>
        /// <returns>CompanyTypeReturnDTO<CompanyTypeReturnDTO></returns>
        public async Task<CompanyTypeReturnDTO> GetCompanyTypeById(int CompanyTypeId)
        {
            #region Declare a return type with initial value.
            CompanyTypeReturnDTO CompanyType = null;
            #endregion
            try
            {
                if (CompanyTypeId > default(int))
                {
                    CompanyType = await CompanyTypeBusinessMapping.GetCompanyTypeById(CompanyTypeId);
                }
            }
            catch (Exception exception)  {}
            return CompanyType;
        }
        /// <summary>
        /// Updae CompanyType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyType(CompanyTypeUpdateDTO companyTypeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyTypeUpdateDTO != null)
                {
                    isUpdated = await CompanyTypeBusinessMapping.UpdateCompanyType(companyTypeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyType AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyType(int CompanyTypeId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyTypeId > default(int))
                {
                    isDeleted = await CompanyTypeBusinessMapping.DeleteCompanyType(CompanyTypeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




