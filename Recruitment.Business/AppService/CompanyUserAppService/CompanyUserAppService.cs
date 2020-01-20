using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyUserDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyUserAppService : BaseAppService, ICompanyUserAppService
    {
        #region Properties
        public ICompanyUserBusinessMapping CompanyUserBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyUserAppService(ICompanyUserBusinessMapping companyUserBusinessMapping)
        {
            CompanyUserBusinessMapping = companyUserBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyUser ActionActivity Logs for All CompanyUsers
        /// </summary>
        /// <returns>List<CompanyUserReturnDTO></returns>
        public async Task<List<CompanyUserReturnDTO>> GetAllCompanyUsers()
        {
            #region Declare a return type with initial value.
            List<CompanyUserReturnDTO> allCompanyUsers = null;
            #endregion
            try
            {
                allCompanyUsers = await CompanyUserBusinessMapping.GetAllCompanyUsers();
            }
            catch (Exception exception)  {}
            return allCompanyUsers;
        }
        /// <summary>
        /// Add CompanyUser AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyUser(CompanyUserAddDTO companyUserAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyUserAddDTO != null)
                {
                    isCreated = await CompanyUserBusinessMapping.AddCompanyUser(companyUserAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyUser By Id 
        /// </summary>
        /// <returns>CompanyUserReturnDTO<CompanyUserReturnDTO></returns>
        public async Task<CompanyUserReturnDTO> GetCompanyUserById(int CompanyUserId)
        {
            #region Declare a return type with initial value.
            CompanyUserReturnDTO CompanyUser = null;
            #endregion
            try
            {
                if (CompanyUserId > default(int))
                {
                    CompanyUser = await CompanyUserBusinessMapping.GetCompanyUserById(CompanyUserId);
                }
            }
            catch (Exception exception)  {}
            return CompanyUser;
        }
        /// <summary>
        /// Updae CompanyUser AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyUser(CompanyUserUpdateDTO companyUserUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyUserUpdateDTO != null)
                {
                    isUpdated = await CompanyUserBusinessMapping.UpdateCompanyUser(companyUserUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyUser AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyUser(int CompanyUserId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyUserId > default(int))
                {
                    isDeleted = await CompanyUserBusinessMapping.DeleteCompanyUser(CompanyUserId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




