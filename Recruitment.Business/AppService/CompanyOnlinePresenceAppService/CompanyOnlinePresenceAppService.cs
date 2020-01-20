using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CompanyOnlinePresenceAppService : BaseAppService, ICompanyOnlinePresenceAppService
    {
        #region Properties
        public ICompanyOnlinePresenceBusinessMapping CompanyOnlinePresenceBusinessMapping { get; }
        #endregion

        #region Constructor
        public CompanyOnlinePresenceAppService(ICompanyOnlinePresenceBusinessMapping companyOnlinePresenceBusinessMapping)
        {
            CompanyOnlinePresenceBusinessMapping = companyOnlinePresenceBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CompanyOnlinePresence ActionActivity Logs for All CompanyOnlinePresences
        /// </summary>
        /// <returns>List<CompanyOnlinePresenceReturnDTO></returns>
        public async Task<List<CompanyOnlinePresenceReturnDTO>> GetAllCompanyOnlinePresences()
        {
            #region Declare a return type with initial value.
            List<CompanyOnlinePresenceReturnDTO> allCompanyOnlinePresences = null;
            #endregion
            try
            {
                allCompanyOnlinePresences = await CompanyOnlinePresenceBusinessMapping.GetAllCompanyOnlinePresences();
            }
            catch (Exception exception)  {}
            return allCompanyOnlinePresences;
        }
        /// <summary>
        /// Add CompanyOnlinePresence AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO companyOnlinePresenceAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (companyOnlinePresenceAddDTO != null)
                {
                    isCreated = await CompanyOnlinePresenceBusinessMapping.AddCompanyOnlinePresence(companyOnlinePresenceAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CompanyOnlinePresence By Id 
        /// </summary>
        /// <returns>CompanyOnlinePresenceReturnDTO<CompanyOnlinePresenceReturnDTO></returns>
        public async Task<CompanyOnlinePresenceReturnDTO> GetCompanyOnlinePresenceById(int CompanyOnlinePresenceId)
        {
            #region Declare a return type with initial value.
            CompanyOnlinePresenceReturnDTO CompanyOnlinePresence = null;
            #endregion
            try
            {
                if (CompanyOnlinePresenceId > default(int))
                {
                    CompanyOnlinePresence = await CompanyOnlinePresenceBusinessMapping.GetCompanyOnlinePresenceById(CompanyOnlinePresenceId);
                }
            }
            catch (Exception exception)  {}
            return CompanyOnlinePresence;
        }
        /// <summary>
        /// Updae CompanyOnlinePresence AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO companyOnlinePresenceUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (companyOnlinePresenceUpdateDTO != null)
                {
                    isUpdated = await CompanyOnlinePresenceBusinessMapping.UpdateCompanyOnlinePresence(companyOnlinePresenceUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CompanyOnlinePresence AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCompanyOnlinePresence(int CompanyOnlinePresenceId)
        {
            bool isDeleted = false;
            try
            {
                if (CompanyOnlinePresenceId > default(int))
                {
                    isDeleted = await CompanyOnlinePresenceBusinessMapping.DeleteCompanyOnlinePresence(CompanyOnlinePresenceId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




