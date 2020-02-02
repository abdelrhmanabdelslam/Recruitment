using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.LanguageLevelDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class LanguageLevelMapping : IDisposable, ILanguageLevelMapping
    {
        public List<LanguageLevelReturnDTO> MappingLanguageLevelToLanguageLevelReturnDTO(List<LanguageLevel> LanguageLevelList)
        {

            List<LanguageLevelReturnDTO> LanguageLevelReturnDTOList = null;
            try
            {
                if (LanguageLevelList.Any() && LanguageLevelList != null)
                {
                    LanguageLevelReturnDTOList = LanguageLevelList.Select(u => new LanguageLevelReturnDTO
                    {
                        LanguageLevelId = u.LanguageLevelId,
                        LanguageLevelName  = u.LanguageLevelName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return LanguageLevelReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<LanguageLevel></returns>
        public LanguageLevel MappingLanguageLevelAddDTOToLanguageLevel(LanguageLevelAddDTO LanguageLevelAddDTO)
            {
                #region Declare a return type with initial value.
                LanguageLevel LanguageLevel = null;
                #endregion
                try
                {
                    LanguageLevel = new LanguageLevel
                    {
                        LanguageLevelName = LanguageLevelAddDTO.LanguageLevelName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return LanguageLevel;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public LanguageLevel MappingLanguageLevelupdateDTOToLanguageLevel(LanguageLevel languageLevel, LanguageLevelUpdateDTO LanguageLevelUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                LanguageLevel LanguageLevel = languageLevel;
                #endregion
                try
                {
                    if (LanguageLevelUpdateDTO.LanguageLevelId > default(int))
                    {
                        LanguageLevel.LanguageLevelId = LanguageLevelUpdateDTO.LanguageLevelId;
                        LanguageLevel.LanguageLevelName = LanguageLevelUpdateDTO.LanguageLevelName;
                    }
                }
                catch (Exception exception) { }
                return LanguageLevel;
            }
            public LanguageLevelReturnDTO MappingLanguageLevelToLanguageLevelReturnDTO(LanguageLevel LanguageLevel)
            {
                #region Declare a return type with initial value.
                LanguageLevelReturnDTO LanguageLevelReturnDTO = null;
                #endregion
                try
                {
                    if (LanguageLevel != null)
                    {
                        LanguageLevelReturnDTO = new LanguageLevelReturnDTO
                        {
                            LanguageLevelId = LanguageLevel.LanguageLevelId,
                            LanguageLevelName = LanguageLevel.LanguageLevelName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return LanguageLevelReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




