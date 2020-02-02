using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.LanguageLevelDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class LanguageLevelBusinessMapping : BaseBusinessMapping, ILanguageLevelBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ILanguageLevelMapping LanguageLevelMapping { get; }
        #endregion

        #region Constructor
        public LanguageLevelBusinessMapping(IUnitOfWork unitOfWork, ILanguageLevelMapping languageLevelMapping)
        {
            UnitOfWork = unitOfWork;
            LanguageLevelMapping = languageLevelMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<LanguageLevelReturnDTO></returns>
        public async Task<List<LanguageLevelReturnDTO>> GetAllLanguageLevels()
        {
            #region Declare Return Var with Intial Value
            List<LanguageLevelReturnDTO> allLanguageLevels = null;
            #endregion
            try
            {
                #region Vars
                List<LanguageLevel> LanguageLevelList = null;
                #endregion
                LanguageLevelList = await UnitOfWork.LanguageLevelRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (LanguageLevelList != null && LanguageLevelList.Any())
                {
                    allLanguageLevels = LanguageLevelMapping.MappingLanguageLevelToLanguageLevelReturnDTO(LanguageLevelList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allLanguageLevels;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddLanguageLevel(LanguageLevelAddDTO LanguageLevelAddDTO)
            {
                #region Declare a return type with initial value.
                bool isLanguageLevelCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    LanguageLevel LanguageLevel = null;
                    #endregion
                    LanguageLevel = LanguageLevelMapping.MappingLanguageLevelAddDTOToLanguageLevel(LanguageLevelAddDTO);
                    if (LanguageLevel != null)
                    {
                        await UnitOfWork.LanguageLevelRepository.Insert(LanguageLevel);
                        isLanguageLevelCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageLevelCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<LanguageLevelReturnDTO></returns>
            public async Task<LanguageLevelReturnDTO> GetLanguageLevelById(int LanguageLevelId)
            {
                #region Declare a return type with initial value.
                LanguageLevelReturnDTO LanguageLevel = new LanguageLevelReturnDTO();
                #endregion
                try
                {
                    LanguageLevel languageLevel = await UnitOfWork.LanguageLevelRepository.GetById(LanguageLevelId);
                    if (languageLevel != null)
                    {
                        if (languageLevel.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            LanguageLevel = LanguageLevelMapping.MappingLanguageLevelToLanguageLevelReturnDTO(languageLevel);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return LanguageLevel;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateLanguageLevel(LanguageLevelUpdateDTO LanguageLevelUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isLanguageLevelUpdated = default(bool);
                #endregion
                try
                {
                    if (LanguageLevelUpdateDTO != null)
                    {
                        #region Vars
                        LanguageLevel LanguageLevel = null;
                        #endregion
                        #region Get Activity By Id
                        LanguageLevel = await UnitOfWork.LanguageLevelRepository.GetById(LanguageLevelUpdateDTO.LanguageLevelId);
                        #endregion
                        if (LanguageLevel != null)
                        {
                            #region  Mapping
                            LanguageLevel = LanguageLevelMapping.MappingLanguageLevelupdateDTOToLanguageLevel(LanguageLevel ,LanguageLevelUpdateDTO);
                            #endregion
                            if (LanguageLevel != null)
                            {
                                #region  Update Entity
                                UnitOfWork.LanguageLevelRepository.Update(LanguageLevel);
                                isLanguageLevelUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageLevelUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteLanguageLevel(int LanguageLevelId)
            {
                #region Declare a return type with initial value.
                bool isLanguageLevelDeleted = default(bool);
                #endregion
                try
                {
                    if (LanguageLevelId > default(int))
                    {
                        #region Vars
                        LanguageLevel LanguageLevel = null;
                        #endregion
                        #region Get LanguageLevel by id
                        LanguageLevel = await UnitOfWork.LanguageLevelRepository.GetById(LanguageLevelId);
                        #endregion
                        #region check if object is not null
                        if (LanguageLevel != null)
                        {
                            LanguageLevel.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.LanguageLevelRepository.Update(LanguageLevel);
                            isLanguageLevelDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isLanguageLevelDeleted;
            }
#endregion
        }
    }




