using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanySizeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanySizeAppService : BaseAppService, ICompanySizeAppService
    {
        #region Properties
        public ICompanySizeBusinessMapping CompanySizeBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanySizeAppService(ICompanySizeBusinessMapping companySizeBusinessMapping)
        {
            CompanySizeBusinessMapping = companySizeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanySize ActionActivity Logs for All CompanySizes
        /// </summary>
        /// <returns>List<CompanySizeReturnDTO></returns>
        public async Task<List<CompanySizeReturnDTO>> GetAllCompanySizes()
        {
            #region Declare a return type with initial value.
            List<CompanySizeReturnDTO> allCompanySizes = null;
            #endregion
            try
            {
                allCompanySizes = await CompanySizeBusinessMapping.GetAllCompanySizes();
            }
            catch (Exception exception)  {}
            return allCompanySizes;
        }
        /// <summary>
        /// Add CompanySize AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanySize(CompanySizeAddDTO companySizeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companySizeAddDTO != null)
                {
                    isCreated = await CompanySizeBusinessMapping.AddCompanySize(companySizeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanySize By Id 
        /// </summary>
        /// <returns>CompanySizeReturnDTO<CompanySizeReturnDTO></returns>
        public async Task<CompanySizeReturnDTO> GetCompanySizeById(int CompanySizeId)
        {
            #region Declare a return type with initial value.
            CompanySizeReturnDTO CompanySize = null;
            #endregion
            try
            {
                if (CompanySizeId > default(int))
                {
                    CompanySize = await CompanySizeBusinessMapping.GetCompanySizeById(CompanySizeId);
                }
            }
            catch (Exception exception)  {}
            return CompanySize;
        }
        /// <summary>
        /// Updae CompanySize AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanySize(CompanySizeUpdateDTO companySizeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companySizeUpdateDTO != null)
                {
                    isUpdated = await CompanySizeBusinessMapping.UpdateCompanySize(companySizeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanySize AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanySize(int CompanySizeId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanySizeId > default(int))
                {
                    isDeleted = await CompanySizeBusinessMapping.DeleteCompanySize(CompanySizeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




