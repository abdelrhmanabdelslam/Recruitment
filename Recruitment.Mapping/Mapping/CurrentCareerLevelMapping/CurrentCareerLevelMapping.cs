using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentCareerLevelDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CurrentCareerLevelMapping : IDisposable, ICurrentCareerLevelMapping
    {
        public List<CurrentCareerLevelReturnDTO> MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(List<CurrentCareerLevel> CurrentCareerLevelList)
        {

            List<CurrentCareerLevelReturnDTO> CurrentCareerLevelReturnDTOList = null;
            try
            {
                if (CurrentCareerLevelList.Any() && CurrentCareerLevelList != null)
                {
                    CurrentCareerLevelReturnDTOList = CurrentCareerLevelList.Select(u => new CurrentCareerLevelReturnDTO
                    {
                        CurrentCareerLevelId = u.CurrentCareerLevelId,
                        CurrentCareerLevelName  = u.CurrentCareerLevelName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CurrentCareerLevelReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CurrentCareerLevel></returns>
        public CurrentCareerLevel MappingCurrentCareerLevelAddDTOToCurrentCareerLevel(CurrentCareerLevelAddDTO CurrentCareerLevelAddDTO)
            {
                #region Declare a return type with initial value.
                CurrentCareerLevel CurrentCareerLevel = null;
                #endregion
                try
                {
                    CurrentCareerLevel = new CurrentCareerLevel
                    {
                        CurrentCareerLevelName = CurrentCareerLevelAddDTO.CurrentCareerLevelName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CurrentCareerLevel;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CurrentCareerLevel MappingCurrentCareerLevelupdateDTOToCurrentCareerLevel(CurrentCareerLevel currentCareerLevel, CurrentCareerLevelUpdateDTO CurrentCareerLevelUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CurrentCareerLevel CurrentCareerLevel = currentCareerLevel;
                #endregion
                try
                {
                    if (CurrentCareerLevelUpdateDTO.CurrentCareerLevelId > default(int))
                    {
                        CurrentCareerLevel.CurrentCareerLevelId = CurrentCareerLevelUpdateDTO.CurrentCareerLevelId;
                        CurrentCareerLevel.CurrentCareerLevelName = CurrentCareerLevelUpdateDTO.CurrentCareerLevelName;
                    }
                }
                catch (Exception exception) { }
                return CurrentCareerLevel;
            }
            public CurrentCareerLevelReturnDTO MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(CurrentCareerLevel CurrentCareerLevel)
            {
                #region Declare a return type with initial value.
                CurrentCareerLevelReturnDTO CurrentCareerLevelReturnDTO = null;
                #endregion
                try
                {
                    if (CurrentCareerLevel != null)
                    {
                        CurrentCareerLevelReturnDTO = new CurrentCareerLevelReturnDTO
                        {
                            CurrentCareerLevelId = CurrentCareerLevel.CurrentCareerLevelId,
                            CurrentCareerLevelName = CurrentCareerLevel.CurrentCareerLevelName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CurrentCareerLevelReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




