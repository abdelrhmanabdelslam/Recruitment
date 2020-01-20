using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyInformationDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyInformationAppService : BaseAppService, ICompanyInformationAppService
    {
        #region Properties
        public ICompanyInformationBusinessMapping CompanyInformationBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyInformationAppService(ICompanyInformationBusinessMapping companyInformationBusinessMapping)
        {
            CompanyInformationBusinessMapping = companyInformationBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyInformation ActionActivity Logs for All CompanyInformations
        /// </summary>
        /// <returns>List<CompanyInformationReturnDTO></returns>
        public async Task<List<CompanyInformationReturnDTO>> GetAllCompanyInformations()
        {
            #region Declare a return type with initial value.
            List<CompanyInformationReturnDTO> allCompanyInformations = null;
            #endregion
            try
            {
                allCompanyInformations = await CompanyInformationBusinessMapping.GetAllCompanyInformations();
            }
            catch (Exception exception)  {}
            return allCompanyInformations;
        }
        /// <summary>
        /// Add CompanyInformation AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyInformation(CompanyInformationAddDTO companyInformationAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyInformationAddDTO != null)
                {
                    isCreated = await CompanyInformationBusinessMapping.AddCompanyInformation(companyInformationAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyInformation By Id 
        /// </summary>
        /// <returns>CompanyInformationReturnDTO<CompanyInformationReturnDTO></returns>
        public async Task<CompanyInformationReturnDTO> GetCompanyInformationById(int CompanyInformationId)
        {
            #region Declare a return type with initial value.
            CompanyInformationReturnDTO CompanyInformation = null;
            #endregion
            try
            {
                if (CompanyInformationId > default(int))
                {
                    CompanyInformation = await CompanyInformationBusinessMapping.GetCompanyInformationById(CompanyInformationId);
                }
            }
            catch (Exception exception)  {}
            return CompanyInformation;
        }
        /// <summary>
        /// Updae CompanyInformation AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyInformation(CompanyInformationUpdateDTO companyInformationUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyInformationUpdateDTO != null)
                {
                    isUpdated = await CompanyInformationBusinessMapping.UpdateCompanyInformation(companyInformationUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyInformation AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyInformation(int CompanyInformationId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyInformationId > default(int))
                {
                    isDeleted = await CompanyInformationBusinessMapping.DeleteCompanyInformation(CompanyInformationId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




