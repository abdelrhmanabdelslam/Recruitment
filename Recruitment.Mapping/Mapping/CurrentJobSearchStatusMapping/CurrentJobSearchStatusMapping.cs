using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CurrentJobSearchStatusMapping : IDisposable, ICurrentJobSearchStatusMapping
    {
        public List<CurrentJobSearchStatusReturnDTO> MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(List<CurrentJobSearchStatus> CurrentJobSearchStatusList)
        {

            List<CurrentJobSearchStatusReturnDTO> CurrentJobSearchStatusReturnDTOList = null;
            try
            {
                if (CurrentJobSearchStatusList.Any() && CurrentJobSearchStatusList != null)
                {
                    CurrentJobSearchStatusReturnDTOList = CurrentJobSearchStatusList.Select(u => new CurrentJobSearchStatusReturnDTO
                    {
                        CurrentJobSearchStatusId = u.CurrentJobSearchStatusId,
                        CurrentJobSearchStatusName  = u.CurrentJobSearchStatusName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CurrentJobSearchStatusReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CurrentJobSearchStatus></returns>
        public CurrentJobSearchStatus MappingCurrentJobSearchStatusAddDTOToCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO CurrentJobSearchStatusAddDTO)
            {
                #region Declare a return type with initial value.
                CurrentJobSearchStatus CurrentJobSearchStatus = null;
                #endregion
                try
                {
                    CurrentJobSearchStatus = new CurrentJobSearchStatus
                    {
                        CurrentJobSearchStatusName = CurrentJobSearchStatusAddDTO.CurrentJobSearchStatusName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CurrentJobSearchStatus;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CurrentJobSearchStatus MappingCurrentJobSearchStatusupdateDTOToCurrentJobSearchStatus(CurrentJobSearchStatus currentJobSearchStatus, CurrentJobSearchStatusUpdateDTO CurrentJobSearchStatusUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CurrentJobSearchStatus CurrentJobSearchStatus = currentJobSearchStatus;
                #endregion
                try
                {
                    if (CurrentJobSearchStatusUpdateDTO.CurrentJobSearchStatusId > default(int))
                    {
                        CurrentJobSearchStatus.CurrentJobSearchStatusId = CurrentJobSearchStatusUpdateDTO.CurrentJobSearchStatusId;
                        CurrentJobSearchStatus.CurrentJobSearchStatusName = CurrentJobSearchStatusUpdateDTO.CurrentJobSearchStatusName;
                    }
                }
                catch (Exception exception) { }
                return CurrentJobSearchStatus;
            }
            public CurrentJobSearchStatusReturnDTO MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(CurrentJobSearchStatus CurrentJobSearchStatus)
            {
                #region Declare a return type with initial value.
                CurrentJobSearchStatusReturnDTO CurrentJobSearchStatusReturnDTO = null;
                #endregion
                try
                {
                    if (CurrentJobSearchStatus != null)
                    {
                        CurrentJobSearchStatusReturnDTO = new CurrentJobSearchStatusReturnDTO
                        {
                            CurrentJobSearchStatusId = CurrentJobSearchStatus.CurrentJobSearchStatusId,
                            CurrentJobSearchStatusName = CurrentJobSearchStatus.CurrentJobSearchStatusName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CurrentJobSearchStatusReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




