using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.LanguageLevelDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class LanguageLevelAppService : BaseAppService, ILanguageLevelAppService
    {
        #region Properties
        public ILanguageLevelBusinessMapping LanguageLevelBusinessMapping { get; }
        #endregion

        #region Constructor
        public LanguageLevelAppService(ILanguageLevelBusinessMapping languageLevelBusinessMapping)
        {
            LanguageLevelBusinessMapping = languageLevelBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All LanguageLevel ActionActivity Logs for All LanguageLevels
        /// </summary>
        /// <returns>List<LanguageLevelReturnDTO></returns>
        public async Task<List<LanguageLevelReturnDTO>> GetAllLanguageLevels()
        {
            #region Declare a return type with initial value.
            List<LanguageLevelReturnDTO> allLanguageLevels = null;
            #endregion
            try
            {
                allLanguageLevels = await LanguageLevelBusinessMapping.GetAllLanguageLevels();
            }
            catch (Exception exception)  {}
            return allLanguageLevels;
        }
        /// <summary>
        /// Add LanguageLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddLanguageLevel(LanguageLevelAddDTO languageLevelAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (languageLevelAddDTO != null)
                {
                    isCreated = await LanguageLevelBusinessMapping.AddLanguageLevel(languageLevelAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  LanguageLevel By Id 
        /// </summary>
        /// <returns>LanguageLevelReturnDTO<LanguageLevelReturnDTO></returns>
        public async Task<LanguageLevelReturnDTO> GetLanguageLevelById(int LanguageLevelId)
        {
            #region Declare a return type with initial value.
            LanguageLevelReturnDTO LanguageLevel = null;
            #endregion
            try
            {
                if (LanguageLevelId > default(int))
                {
                    LanguageLevel = await LanguageLevelBusinessMapping.GetLanguageLevelById(LanguageLevelId);
                }
            }
            catch (Exception exception)  {}
            return LanguageLevel;
        }
        /// <summary>
        /// Updae LanguageLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateLanguageLevel(LanguageLevelUpdateDTO languageLevelUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (languageLevelUpdateDTO != null)
                {
                    isUpdated = await LanguageLevelBusinessMapping.UpdateLanguageLevel(languageLevelUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete LanguageLevel AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteLanguageLevel(int LanguageLevelId)
        {
            bool isDeleted = false;
            try
            {
                if (LanguageLevelId > default(int))
                {
                    isDeleted = await LanguageLevelBusinessMapping.DeleteLanguageLevel(LanguageLevelId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




