using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CurrentEducationalLevelBusinessMapping : BaseBusinessMapping, ICurrentEducationalLevelBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICurrentEducationalLevelMapping CurrentEducationalLevelMapping { get; }
        #endregion

        #region Constructor
        public CurrentEducationalLevelBusinessMapping(IUnitOfWork unitOfWork, ICurrentEducationalLevelMapping currentEducationalLevelMapping)
        {
            UnitOfWork = unitOfWork;
            CurrentEducationalLevelMapping = currentEducationalLevelMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CurrentEducationalLevelReturnDTO></returns>
        public async Task<List<CurrentEducationalLevelReturnDTO>> GetAllCurrentEducationalLevels()
        {
            #region Declare Return Var with Intial Value
            List<CurrentEducationalLevelReturnDTO> allCurrentEducationalLevels = null;
            #endregion
            try
            {
                #region Vars
                List<CurrentEducationalLevel> CurrentEducationalLevelList = null;
                #endregion
                CurrentEducationalLevelList = await UnitOfWork.CurrentEducationalLevelRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CurrentEducationalLevelList != null && CurrentEducationalLevelList.Any())
                {
                    allCurrentEducationalLevels = CurrentEducationalLevelMapping.MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(CurrentEducationalLevelList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCurrentEducationalLevels;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCurrentEducationalLevel(CurrentEducationalLevelAddDTO CurrentEducationalLevelAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentEducationalLevelCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CurrentEducationalLevel CurrentEducationalLevel = null;
                    #endregion
                    CurrentEducationalLevel = CurrentEducationalLevelMapping.MappingCurrentEducationalLevelAddDTOToCurrentEducationalLevel(CurrentEducationalLevelAddDTO);
                    if (CurrentEducationalLevel != null)
                    {
                        await UnitOfWork.CurrentEducationalLevelRepository.Insert(CurrentEducationalLevel);
                        isCurrentEducationalLevelCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentEducationalLevelCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CurrentEducationalLevelReturnDTO></returns>
            public async Task<CurrentEducationalLevelReturnDTO> GetCurrentEducationalLevelById(int CurrentEducationalLevelId)
            {
                #region Declare a return type with initial value.
                CurrentEducationalLevelReturnDTO CurrentEducationalLevel = new CurrentEducationalLevelReturnDTO();
                #endregion
                try
                {
                    CurrentEducationalLevel currentEducationalLevel = await UnitOfWork.CurrentEducationalLevelRepository.GetById(CurrentEducationalLevelId);
                    if (currentEducationalLevel != null)
                    {
                        if (currentEducationalLevel.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CurrentEducationalLevel = CurrentEducationalLevelMapping.MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(currentEducationalLevel);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CurrentEducationalLevel;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCurrentEducationalLevel(CurrentEducationalLevelUpdateDTO CurrentEducationalLevelUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentEducationalLevelUpdated = default(bool);
                #endregion
                try
                {
                    if (CurrentEducationalLevelUpdateDTO != null)
                    {
                        #region Vars
                        CurrentEducationalLevel CurrentEducationalLevel = null;
                        #endregion
                        #region Get Activity By Id
                        CurrentEducationalLevel = await UnitOfWork.CurrentEducationalLevelRepository.GetById(CurrentEducationalLevelUpdateDTO.CurrentEducationalLevelId);
                        #endregion
                        if (CurrentEducationalLevel != null)
                        {
                            #region  Mapping
                            CurrentEducationalLevel = CurrentEducationalLevelMapping.MappingCurrentEducationalLevelupdateDTOToCurrentEducationalLevel(CurrentEducationalLevel ,CurrentEducationalLevelUpdateDTO);
                            #endregion
                            if (CurrentEducationalLevel != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CurrentEducationalLevelRepository.Update(CurrentEducationalLevel);
                                isCurrentEducationalLevelUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentEducationalLevelUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCurrentEducationalLevel(int CurrentEducationalLevelId)
            {
                #region Declare a return type with initial value.
                bool isCurrentEducationalLevelDeleted = default(bool);
                #endregion
                try
                {
                    if (CurrentEducationalLevelId > default(int))
                    {
                        #region Vars
                        CurrentEducationalLevel CurrentEducationalLevel = null;
                        #endregion
                        #region Get CurrentEducationalLevel by id
                        CurrentEducationalLevel = await UnitOfWork.CurrentEducationalLevelRepository.GetById(CurrentEducationalLevelId);
                        #endregion
                        #region check if object is not null
                        if (CurrentEducationalLevel != null)
                        {
                            CurrentEducationalLevel.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CurrentEducationalLevelRepository.Update(CurrentEducationalLevel);
                            isCurrentEducationalLevelDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentEducationalLevelDeleted;
            }
#endregion
        }
    }




