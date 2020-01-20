using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CurrentEducationalLevelMapping : IDisposable, ICurrentEducationalLevelMapping
    {
        public List<CurrentEducationalLevelReturnDTO> MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(List<CurrentEducationalLevel> CurrentEducationalLevelList)
        {

            List<CurrentEducationalLevelReturnDTO> CurrentEducationalLevelReturnDTOList = null;
            try
            {
                if (CurrentEducationalLevelList.Any() && CurrentEducationalLevelList != null)
                {
                    CurrentEducationalLevelReturnDTOList = CurrentEducationalLevelList.Select(u => new CurrentEducationalLevelReturnDTO
                    {
                        CurrentEducationalLevelId = u.CurrentEducationalLevelId,
                        CurrentEducationalLevelName  = u.CurrentEducationalLevelName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CurrentEducationalLevelReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CurrentEducationalLevel></returns>
        public CurrentEducationalLevel MappingCurrentEducationalLevelAddDTOToCurrentEducationalLevel(CurrentEducationalLevelAddDTO CurrentEducationalLevelAddDTO)
            {
                #region Declare a return type with initial value.
                CurrentEducationalLevel CurrentEducationalLevel = null;
                #endregion
                try
                {
                    CurrentEducationalLevel = new CurrentEducationalLevel
                    {
                        CurrentEducationalLevelName = CurrentEducationalLevelAddDTO.CurrentEducationalLevelName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CurrentEducationalLevel;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CurrentEducationalLevel MappingCurrentEducationalLevelupdateDTOToCurrentEducationalLevel(CurrentEducationalLevel currentEducationalLevel, CurrentEducationalLevelUpdateDTO CurrentEducationalLevelUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CurrentEducationalLevel CurrentEducationalLevel = currentEducationalLevel;
                #endregion
                try
                {
                    if (CurrentEducationalLevelUpdateDTO.CurrentEducationalLevelId > default(int))
                    {
                        CurrentEducationalLevel.CurrentEducationalLevelId = CurrentEducationalLevelUpdateDTO.CurrentEducationalLevelId;
                        CurrentEducationalLevel.CurrentEducationalLevelName = CurrentEducationalLevelUpdateDTO.CurrentEducationalLevelName;
                    }
                }
                catch (Exception exception) { }
                return CurrentEducationalLevel;
            }
            public CurrentEducationalLevelReturnDTO MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(CurrentEducationalLevel CurrentEducationalLevel)
            {
                #region Declare a return type with initial value.
                CurrentEducationalLevelReturnDTO CurrentEducationalLevelReturnDTO = null;
                #endregion
                try
                {
                    if (CurrentEducationalLevel != null)
                    {
                        CurrentEducationalLevelReturnDTO = new CurrentEducationalLevelReturnDTO
                        {
                            CurrentEducationalLevelId = CurrentEducationalLevel.CurrentEducationalLevelId,
                            CurrentEducationalLevelName = CurrentEducationalLevel.CurrentEducationalLevelName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CurrentEducationalLevelReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




