using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CurrentJobSearchStatusBusinessMapping : BaseBusinessMapping, ICurrentJobSearchStatusBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICurrentJobSearchStatusMapping CurrentJobSearchStatusMapping { get; }
        #endregion

        #region Constructor
        public CurrentJobSearchStatusBusinessMapping(IUnitOfWork unitOfWork, ICurrentJobSearchStatusMapping currentJobSearchStatusMapping)
        {
            UnitOfWork = unitOfWork;
            CurrentJobSearchStatusMapping = currentJobSearchStatusMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CurrentJobSearchStatusReturnDTO></returns>
        public async Task<List<CurrentJobSearchStatusReturnDTO>> GetAllCurrentJobSearchStatuss()
        {
            #region Declare Return Var with Intial Value
            List<CurrentJobSearchStatusReturnDTO> allCurrentJobSearchStatuss = null;
            #endregion
            try
            {
                #region Vars
                List<CurrentJobSearchStatus> CurrentJobSearchStatusList = null;
                #endregion
                CurrentJobSearchStatusList = await UnitOfWork.CurrentJobSearchStatusRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CurrentJobSearchStatusList != null && CurrentJobSearchStatusList.Any())
                {
                    allCurrentJobSearchStatuss = CurrentJobSearchStatusMapping.MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(CurrentJobSearchStatusList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCurrentJobSearchStatuss;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO CurrentJobSearchStatusAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentJobSearchStatusCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CurrentJobSearchStatus CurrentJobSearchStatus = null;
                    #endregion
                    CurrentJobSearchStatus = CurrentJobSearchStatusMapping.MappingCurrentJobSearchStatusAddDTOToCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO);
                    if (CurrentJobSearchStatus != null)
                    {
                        await UnitOfWork.CurrentJobSearchStatusRepository.Insert(CurrentJobSearchStatus);
                        isCurrentJobSearchStatusCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentJobSearchStatusCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CurrentJobSearchStatusReturnDTO></returns>
            public async Task<CurrentJobSearchStatusReturnDTO> GetCurrentJobSearchStatusById(int CurrentJobSearchStatusId)
            {
                #region Declare a return type with initial value.
                CurrentJobSearchStatusReturnDTO CurrentJobSearchStatus = new CurrentJobSearchStatusReturnDTO();
                #endregion
                try
                {
                    CurrentJobSearchStatus currentJobSearchStatus = await UnitOfWork.CurrentJobSearchStatusRepository.GetById(CurrentJobSearchStatusId);
                    if (currentJobSearchStatus != null)
                    {
                        if (currentJobSearchStatus.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CurrentJobSearchStatus = CurrentJobSearchStatusMapping.MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(currentJobSearchStatus);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CurrentJobSearchStatus;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO CurrentJobSearchStatusUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentJobSearchStatusUpdated = default(bool);
                #endregion
                try
                {
                    if (CurrentJobSearchStatusUpdateDTO != null)
                    {
                        #region Vars
                        CurrentJobSearchStatus CurrentJobSearchStatus = null;
                        #endregion
                        #region Get Activity By Id
                        CurrentJobSearchStatus = await UnitOfWork.CurrentJobSearchStatusRepository.GetById(CurrentJobSearchStatusUpdateDTO.CurrentJobSearchStatusId);
                        #endregion
                        if (CurrentJobSearchStatus != null)
                        {
                            #region  Mapping
                            CurrentJobSearchStatus = CurrentJobSearchStatusMapping.MappingCurrentJobSearchStatusupdateDTOToCurrentJobSearchStatus(CurrentJobSearchStatus ,CurrentJobSearchStatusUpdateDTO);
                            #endregion
                            if (CurrentJobSearchStatus != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CurrentJobSearchStatusRepository.Update(CurrentJobSearchStatus);
                                isCurrentJobSearchStatusUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentJobSearchStatusUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCurrentJobSearchStatus(int CurrentJobSearchStatusId)
            {
                #region Declare a return type with initial value.
                bool isCurrentJobSearchStatusDeleted = default(bool);
                #endregion
                try
                {
                    if (CurrentJobSearchStatusId > default(int))
                    {
                        #region Vars
                        CurrentJobSearchStatus CurrentJobSearchStatus = null;
                        #endregion
                        #region Get CurrentJobSearchStatus by id
                        CurrentJobSearchStatus = await UnitOfWork.CurrentJobSearchStatusRepository.GetById(CurrentJobSearchStatusId);
                        #endregion
                        #region check if object is not null
                        if (CurrentJobSearchStatus != null)
                        {
                            CurrentJobSearchStatus.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CurrentJobSearchStatusRepository.Update(CurrentJobSearchStatus);
                            isCurrentJobSearchStatusDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentJobSearchStatusDeleted;
            }
#endregion
        }
    }




