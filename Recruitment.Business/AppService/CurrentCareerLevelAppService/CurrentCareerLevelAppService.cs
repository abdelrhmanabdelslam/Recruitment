using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CurrentCareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CurrentCareerLevelAppService : BaseAppService, ICurrentCareerLevelAppService
    {
        #region Properties
        public ICurrentCareerLevelBusinessMapping CurrentCareerLevelBusinessMapping { get; }
        #endregion

        #region Constructor
        public CurrentCareerLevelAppService(ICurrentCareerLevelBusinessMapping currentCareerLevelBusinessMapping)
        {
            CurrentCareerLevelBusinessMapping = currentCareerLevelBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CurrentCareerLevel ActionActivity Logs for All CurrentCareerLevels
        /// </summary>
        /// <returns>List<CurrentCareerLevelReturnDTO></returns>
        public async Task<List<CurrentCareerLevelReturnDTO>> GetAllCurrentCareerLevels()
        {
            #region Declare a return type with initial value.
            List<CurrentCareerLevelReturnDTO> allCurrentCareerLevels = null;
            #endregion
            try
            {
                allCurrentCareerLevels = await CurrentCareerLevelBusinessMapping.GetAllCurrentCareerLevels();
            }
            catch (Exception exception)  {}
            return allCurrentCareerLevels;
        }
        /// <summary>
        /// Add CurrentCareerLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCurrentCareerLevel(CurrentCareerLevelAddDTO currentCareerLevelAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (currentCareerLevelAddDTO != null)
                {
                    isCreated = await CurrentCareerLevelBusinessMapping.AddCurrentCareerLevel(currentCareerLevelAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CurrentCareerLevel By Id 
        /// </summary>
        /// <returns>CurrentCareerLevelReturnDTO<CurrentCareerLevelReturnDTO></returns>
        public async Task<CurrentCareerLevelReturnDTO> GetCurrentCareerLevelById(int CurrentCareerLevelId)
        {
            #region Declare a return type with initial value.
            CurrentCareerLevelReturnDTO CurrentCareerLevel = null;
            #endregion
            try
            {
                if (CurrentCareerLevelId > default(int))
                {
                    CurrentCareerLevel = await CurrentCareerLevelBusinessMapping.GetCurrentCareerLevelById(CurrentCareerLevelId);
                }
            }
            catch (Exception exception)  {}
            return CurrentCareerLevel;
        }
        /// <summary>
        /// Updae CurrentCareerLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCurrentCareerLevel(CurrentCareerLevelUpdateDTO currentCareerLevelUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (currentCareerLevelUpdateDTO != null)
                {
                    isUpdated = await CurrentCareerLevelBusinessMapping.UpdateCurrentCareerLevel(currentCareerLevelUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CurrentCareerLevel AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCurrentCareerLevel(int CurrentCareerLevelId)
        {
            bool isDeleted = false;
            try
            {
                if (CurrentCareerLevelId > default(int))
                {
                    isDeleted = await CurrentCareerLevelBusinessMapping.DeleteCurrentCareerLevel(CurrentCareerLevelId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




