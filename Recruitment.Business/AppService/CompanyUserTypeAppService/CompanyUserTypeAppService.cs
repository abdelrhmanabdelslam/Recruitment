using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyUserTypeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyUserTypeAppService : BaseAppService, ICompanyUserTypeAppService
    {
        #region Properties
        public ICompanyUserTypeBusinessMapping CompanyUserTypeBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyUserTypeAppService(ICompanyUserTypeBusinessMapping companyUserTypeBusinessMapping)
        {
            CompanyUserTypeBusinessMapping = companyUserTypeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyUserType ActionActivity Logs for All CompanyUserTypes
        /// </summary>
        /// <returns>List<CompanyUserTypeReturnDTO></returns>
        public async Task<List<CompanyUserTypeReturnDTO>> GetAllCompanyUserTypes()
        {
            #region Declare a return type with initial value.
            List<CompanyUserTypeReturnDTO> allCompanyUserTypes = null;
            #endregion
            try
            {
                allCompanyUserTypes = await CompanyUserTypeBusinessMapping.GetAllCompanyUserTypes();
            }
            catch (Exception exception)  {}
            return allCompanyUserTypes;
        }
        /// <summary>
        /// Add CompanyUserType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyUserType(CompanyUserTypeAddDTO companyUserTypeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyUserTypeAddDTO != null)
                {
                    isCreated = await CompanyUserTypeBusinessMapping.AddCompanyUserType(companyUserTypeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyUserType By Id 
        /// </summary>
        /// <returns>CompanyUserTypeReturnDTO<CompanyUserTypeReturnDTO></returns>
        public async Task<CompanyUserTypeReturnDTO> GetCompanyUserTypeById(int CompanyUserTypeId)
        {
            #region Declare a return type with initial value.
            CompanyUserTypeReturnDTO CompanyUserType = null;
            #endregion
            try
            {
                if (CompanyUserTypeId > default(int))
                {
                    CompanyUserType = await CompanyUserTypeBusinessMapping.GetCompanyUserTypeById(CompanyUserTypeId);
                }
            }
            catch (Exception exception)  {}
            return CompanyUserType;
        }
        /// <summary>
        /// Updae CompanyUserType AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyUserType(CompanyUserTypeUpdateDTO companyUserTypeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyUserTypeUpdateDTO != null)
                {
                    isUpdated = await CompanyUserTypeBusinessMapping.UpdateCompanyUserType(companyUserTypeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyUserType AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyUserType(int CompanyUserTypeId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyUserTypeId > default(int))
                {
                    isDeleted = await CompanyUserTypeBusinessMapping.DeleteCompanyUserType(CompanyUserTypeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




