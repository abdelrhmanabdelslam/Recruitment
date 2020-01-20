using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyIndustryAppService : BaseAppService, ICompanyIndustryAppService
    {
        #region Properties
        public ICompanyIndustryBusinessMapping CompanyIndustryBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyIndustryAppService(ICompanyIndustryBusinessMapping companyIndustryBusinessMapping)
        {
            CompanyIndustryBusinessMapping = companyIndustryBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyIndustry ActionActivity Logs for All CompanyIndustrys
        /// </summary>
        /// <returns>List<CompanyIndustryReturnDTO></returns>
        public async Task<List<CompanyIndustryReturnDTO>> GetAllCompanyIndustrys()
        {
            #region Declare a return type with initial value.
            List<CompanyIndustryReturnDTO> allCompanyIndustrys = null;
            #endregion
            try
            {
                allCompanyIndustrys = await CompanyIndustryBusinessMapping.GetAllCompanyIndustrys();
            }
            catch (Exception exception)  {}
            return allCompanyIndustrys;
        }
        /// <summary>
        /// Add CompanyIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyIndustry(CompanyIndustryAddDTO companyIndustryAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyIndustryAddDTO != null)
                {
                    isCreated = await CompanyIndustryBusinessMapping.AddCompanyIndustry(companyIndustryAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyIndustry By Id 
        /// </summary>
        /// <returns>CompanyIndustryReturnDTO<CompanyIndustryReturnDTO></returns>
        public async Task<CompanyIndustryReturnDTO> GetCompanyIndustryById(int CompanyIndustryId)
        {
            #region Declare a return type with initial value.
            CompanyIndustryReturnDTO CompanyIndustry = null;
            #endregion
            try
            {
                if (CompanyIndustryId > default(int))
                {
                    CompanyIndustry = await CompanyIndustryBusinessMapping.GetCompanyIndustryById(CompanyIndustryId);
                }
            }
            catch (Exception exception)  {}
            return CompanyIndustry;
        }
        /// <summary>
        /// Updae CompanyIndustry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyIndustry(CompanyIndustryUpdateDTO companyIndustryUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyIndustryUpdateDTO != null)
                {
                    isUpdated = await CompanyIndustryBusinessMapping.UpdateCompanyIndustry(companyIndustryUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyIndustry AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyIndustry(int CompanyIndustryId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyIndustryId > default(int))
                {
                    isDeleted = await CompanyIndustryBusinessMapping.DeleteCompanyIndustry(CompanyIndustryId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




