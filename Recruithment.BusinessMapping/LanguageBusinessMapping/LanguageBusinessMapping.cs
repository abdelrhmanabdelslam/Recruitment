using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.LanguageDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class LanguageBusinessMapping : BaseBusinessMapping, ILanguageBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ILanguageMapping LanguageMapping { get; }
        #endregion

        #region Constructor
        public LanguageBusinessMapping(IUnitOfWork unitOfWork, ILanguageMapping languageMapping)
        {
            UnitOfWork = unitOfWork;
            LanguageMapping = languageMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<LanguageReturnDTO></returns>
        public async Task<List<LanguageReturnDTO>> GetAllLanguages()
        {
            #region Declare Return Var with Intial Value
            List<LanguageReturnDTO> allLanguages = null;
            #endregion
            try
            {
                #region Vars
                List<Language> LanguageList = null;
                #endregion
                LanguageList = await UnitOfWork.LanguageRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (LanguageList != null && LanguageList.Any())
                {
                    allLanguages = LanguageMapping.MappingLanguageToLanguageReturnDTO(LanguageList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allLanguages;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddLanguage(LanguageAddDTO LanguageAddDTO)
            {
                #region Declare a return type with initial value.
                bool isLanguageCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Language Language = null;
                    #endregion
                    Language = LanguageMapping.MappingLanguageAddDTOToLanguage(LanguageAddDTO);
                    if (Language != null)
                    {
                        await UnitOfWork.LanguageRepository.Insert(Language);
                        isLanguageCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<LanguageReturnDTO></returns>
            public async Task<LanguageReturnDTO> GetLanguageById(int LanguageId)
            {
                #region Declare a return type with initial value.
                LanguageReturnDTO Language = new LanguageReturnDTO();
                #endregion
                try
                {
                    Language language = await UnitOfWork.LanguageRepository.GetById(LanguageId);
                    if (language != null)
                    {
                        if (language.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Language = LanguageMapping.MappingLanguageToLanguageReturnDTO(language);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Language;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateLanguage(LanguageUpdateDTO LanguageUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isLanguageUpdated = default(bool);
                #endregion
                try
                {
                    if (LanguageUpdateDTO != null)
                    {
                        #region Vars
                        Language Language = null;
                        #endregion
                        #region Get Activity By Id
                        Language = await UnitOfWork.LanguageRepository.GetById(LanguageUpdateDTO.LanguageId);
                        #endregion
                        if (Language != null)
                        {
                            #region  Mapping
                            Language = LanguageMapping.MappingLanguageupdateDTOToLanguage(Language ,LanguageUpdateDTO);
                            #endregion
                            if (Language != null)
                            {
                                #region  Update Entity
                                UnitOfWork.LanguageRepository.Update(Language);
                                isLanguageUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteLanguage(int LanguageId)
            {
                #region Declare a return type with initial value.
                bool isLanguageDeleted = default(bool);
                #endregion
                try
                {
                    if (LanguageId > default(int))
                    {
                        #region Vars
                        Language Language = null;
                        #endregion
                        #region Get Language by id
                        Language = await UnitOfWork.LanguageRepository.GetById(LanguageId);
                        #endregion
                        #region check if object is not null
                        if (Language != null)
                        {
                            Language.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.LanguageRepository.Update(Language);
                            isLanguageDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageDeleted;
            }
#endregion
        }
    }




