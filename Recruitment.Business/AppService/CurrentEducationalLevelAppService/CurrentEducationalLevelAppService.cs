using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CurrentEducationalLevelAppService : BaseAppService, ICurrentEducationalLevelAppService
    {
        #region Properties
        public ICurrentEducationalLevelBusinessMapping CurrentEducationalLevelBusinessMapping { get; }
        #endregion

        #region Constructor
        public CurrentEducationalLevelAppService(ICurrentEducationalLevelBusinessMapping currentEducationalLevelBusinessMapping)
        {
            CurrentEducationalLevelBusinessMapping = currentEducationalLevelBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CurrentEducationalLevel ActionActivity Logs for All CurrentEducationalLevels
        /// </summary>
        /// <returns>List<CurrentEducationalLevelReturnDTO></returns>
        public async Task<List<CurrentEducationalLevelReturnDTO>> GetAllCurrentEducationalLevels()
        {
            #region Declare a return type with initial value.
            List<CurrentEducationalLevelReturnDTO> allCurrentEducationalLevels = null;
            #endregion
            try
            {
                allCurrentEducationalLevels = await CurrentEducationalLevelBusinessMapping.GetAllCurrentEducationalLevels();
            }
            catch (Exception exception)  {}
            return allCurrentEducationalLevels;
        }
        /// <summary>
        /// Add CurrentEducationalLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCurrentEducationalLevel(CurrentEducationalLevelAddDTO currentEducationalLevelAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (currentEducationalLevelAddDTO != null)
                {
                    isCreated = await CurrentEducationalLevelBusinessMapping.AddCurrentEducationalLevel(currentEducationalLevelAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CurrentEducationalLevel By Id 
        /// </summary>
        /// <returns>CurrentEducationalLevelReturnDTO<CurrentEducationalLevelReturnDTO></returns>
        public async Task<CurrentEducationalLevelReturnDTO> GetCurrentEducationalLevelById(int CurrentEducationalLevelId)
        {
            #region Declare a return type with initial value.
            CurrentEducationalLevelReturnDTO CurrentEducationalLevel = null;
            #endregion
            try
            {
                if (CurrentEducationalLevelId > default(int))
                {
                    CurrentEducationalLevel = await CurrentEducationalLevelBusinessMapping.GetCurrentEducationalLevelById(CurrentEducationalLevelId);
                }
            }
            catch (Exception exception)  {}
            return CurrentEducationalLevel;
        }
        /// <summary>
        /// Updae CurrentEducationalLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCurrentEducationalLevel(CurrentEducationalLevelUpdateDTO currentEducationalLevelUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (currentEducationalLevelUpdateDTO != null)
                {
                    isUpdated = await CurrentEducationalLevelBusinessMapping.UpdateCurrentEducationalLevel(currentEducationalLevelUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CurrentEducationalLevel AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCurrentEducationalLevel(int CurrentEducationalLevelId)
        {
            bool isDeleted = false;
            try
            {
                if (CurrentEducationalLevelId > default(int))
                {
                    isDeleted = await CurrentEducationalLevelBusinessMapping.DeleteCurrentEducationalLevel(CurrentEducationalLevelId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




