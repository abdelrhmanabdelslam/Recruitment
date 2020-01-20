using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CurrentJobSearchStatusAppService : BaseAppService, ICurrentJobSearchStatusAppService
    {
        #region Properties
        public ICurrentJobSearchStatusBusinessMapping CurrentJobSearchStatusBusinessMapping { get; }
        #endregion

        #region Constructor
        public CurrentJobSearchStatusAppService(ICurrentJobSearchStatusBusinessMapping currentJobSearchStatusBusinessMapping)
        {
            CurrentJobSearchStatusBusinessMapping = currentJobSearchStatusBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CurrentJobSearchStatus ActionActivity Logs for All CurrentJobSearchStatuss
        /// </summary>
        /// <returns>List<CurrentJobSearchStatusReturnDTO></returns>
        public async Task<List<CurrentJobSearchStatusReturnDTO>> GetAllCurrentJobSearchStatuss()
        {
            #region Declare a return type with initial value.
            List<CurrentJobSearchStatusReturnDTO> allCurrentJobSearchStatuss = null;
            #endregion
            try
            {
                allCurrentJobSearchStatuss = await CurrentJobSearchStatusBusinessMapping.GetAllCurrentJobSearchStatuss();
            }
            catch (Exception exception)  {}
            return allCurrentJobSearchStatuss;
        }
        /// <summary>
        /// Add CurrentJobSearchStatus AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO currentJobSearchStatusAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (currentJobSearchStatusAddDTO != null)
                {
                    isCreated = await CurrentJobSearchStatusBusinessMapping.AddCurrentJobSearchStatus(currentJobSearchStatusAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CurrentJobSearchStatus By Id 
        /// </summary>
        /// <returns>CurrentJobSearchStatusReturnDTO<CurrentJobSearchStatusReturnDTO></returns>
        public async Task<CurrentJobSearchStatusReturnDTO> GetCurrentJobSearchStatusById(int CurrentJobSearchStatusId)
        {
            #region Declare a return type with initial value.
            CurrentJobSearchStatusReturnDTO CurrentJobSearchStatus = null;
            #endregion
            try
            {
                if (CurrentJobSearchStatusId > default(int))
                {
                    CurrentJobSearchStatus = await CurrentJobSearchStatusBusinessMapping.GetCurrentJobSearchStatusById(CurrentJobSearchStatusId);
                }
            }
            catch (Exception exception)  {}
            return CurrentJobSearchStatus;
        }
        /// <summary>
        /// Updae CurrentJobSearchStatus AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO currentJobSearchStatusUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (currentJobSearchStatusUpdateDTO != null)
                {
                    isUpdated = await CurrentJobSearchStatusBusinessMapping.UpdateCurrentJobSearchStatus(currentJobSearchStatusUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CurrentJobSearchStatus AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCurrentJobSearchStatus(int CurrentJobSearchStatusId)
        {
            bool isDeleted = false;
            try
            {
                if (CurrentJobSearchStatusId > default(int))
                {
                    isDeleted = await CurrentJobSearchStatusBusinessMapping.DeleteCurrentJobSearchStatus(CurrentJobSearchStatusId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




