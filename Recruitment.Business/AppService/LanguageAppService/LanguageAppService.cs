using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.LanguageDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class LanguageAppService : BaseAppService, ILanguageAppService
    {
        #region Properties
        public ILanguageBusinessMapping LanguageBusinessMapping { get; }
        #endregion

        #region Constructor
        public LanguageAppService(ILanguageBusinessMapping languageBusinessMapping)
        {
            LanguageBusinessMapping = languageBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Language ActionActivity Logs for All Languages
        /// </summary>
        /// <returns>List<LanguageReturnDTO></returns>
        public async Task<List<LanguageReturnDTO>> GetAllLanguages()
        {
            #region Declare a return type with initial value.
            List<LanguageReturnDTO> allLanguages = null;
            #endregion
            try
            {
                allLanguages = await LanguageBusinessMapping.GetAllLanguages();
            }
            catch (Exception exception)  {}
            return allLanguages;
        }
        /// <summary>
        /// Add Language AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddLanguage(LanguageAddDTO languageAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (languageAddDTO != null)
                {
                    isCreated = await LanguageBusinessMapping.AddLanguage(languageAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Language By Id 
        /// </summary>
        /// <returns>LanguageReturnDTO<LanguageReturnDTO></returns>
        public async Task<LanguageReturnDTO> GetLanguageById(int LanguageId)
        {
            #region Declare a return type with initial value.
            LanguageReturnDTO Language = null;
            #endregion
            try
            {
                if (LanguageId > default(int))
                {
                    Language = await LanguageBusinessMapping.GetLanguageById(LanguageId);
                }
            }
            catch (Exception exception)  {}
            return Language;
        }
        /// <summary>
        /// Updae Language AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateLanguage(LanguageUpdateDTO languageUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (languageUpdateDTO != null)
                {
                    isUpdated = await LanguageBusinessMapping.UpdateLanguage(languageUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Language AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteLanguage(int LanguageId)
        {
            bool isDeleted = false;
            try
            {
                if (LanguageId > default(int))
                {
                    isDeleted = await LanguageBusinessMapping.DeleteLanguage(LanguageId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




