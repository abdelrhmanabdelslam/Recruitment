using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.LanguageDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class LanguageMapping : IDisposable, ILanguageMapping
    {
        public List<LanguageReturnDTO> MappingLanguageToLanguageReturnDTO(List<Language> LanguageList)
        {

            List<LanguageReturnDTO> LanguageReturnDTOList = null;
            try
            {
                if (LanguageList.Any() && LanguageList != null)
                {
                    LanguageReturnDTOList = LanguageList.Select(u => new LanguageReturnDTO
                    {
                        LanguageId = u.LanguageId,
                        LanguageName  = u.LanguageName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return LanguageReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Language></returns>
        public Language MappingLanguageAddDTOToLanguage(LanguageAddDTO LanguageAddDTO)
            {
                #region Declare a return type with initial value.
                Language Language = null;
                #endregion
                try
                {
                    Language = new Language
                    {
                        LanguageName = LanguageAddDTO.LanguageName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Language;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Language MappingLanguageupdateDTOToLanguage(Language language, LanguageUpdateDTO LanguageUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Language Language = language;
                #endregion
                try
                {
                    if (LanguageUpdateDTO.LanguageId > default(int))
                    {
                        Language.LanguageId = LanguageUpdateDTO.LanguageId;
                        Language.LanguageName = LanguageUpdateDTO.LanguageName;
                    }
                }
                catch (Exception exception) { }
                return Language;
            }
            public LanguageReturnDTO MappingLanguageToLanguageReturnDTO(Language Language)
            {
                #region Declare a return type with initial value.
                LanguageReturnDTO LanguageReturnDTO = null;
                #endregion
                try
                {
                    if (Language != null)
                    {
                        LanguageReturnDTO = new LanguageReturnDTO
                        {
                            LanguageId = Language.LanguageId,
                            LanguageName = Language.LanguageName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return LanguageReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




