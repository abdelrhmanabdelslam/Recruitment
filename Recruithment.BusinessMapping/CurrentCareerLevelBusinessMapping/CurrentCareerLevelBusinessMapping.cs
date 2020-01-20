using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CurrentCareerLevelDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CurrentCareerLevelBusinessMapping : BaseBusinessMapping, ICurrentCareerLevelBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICurrentCareerLevelMapping CurrentCareerLevelMapping { get; }
        #endregion

        #region Constructor
        public CurrentCareerLevelBusinessMapping(IUnitOfWork unitOfWork, ICurrentCareerLevelMapping currentCareerLevelMapping)
        {
            UnitOfWork = unitOfWork;
            CurrentCareerLevelMapping = currentCareerLevelMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CurrentCareerLevelReturnDTO></returns>
        public async Task<List<CurrentCareerLevelReturnDTO>> GetAllCurrentCareerLevels()
        {
            #region Declare Return Var with Intial Value
            List<CurrentCareerLevelReturnDTO> allCurrentCareerLevels = null;
            #endregion
            try
            {
                #region Vars
                List<CurrentCareerLevel> CurrentCareerLevelList = null;
                #endregion
                CurrentCareerLevelList = await UnitOfWork.CurrentCareerLevelRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CurrentCareerLevelList != null && CurrentCareerLevelList.Any())
                {
                    allCurrentCareerLevels = CurrentCareerLevelMapping.MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(CurrentCareerLevelList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCurrentCareerLevels;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCurrentCareerLevel(CurrentCareerLevelAddDTO CurrentCareerLevelAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentCareerLevelCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CurrentCareerLevel CurrentCareerLevel = null;
                    #endregion
                    CurrentCareerLevel = CurrentCareerLevelMapping.MappingCurrentCareerLevelAddDTOToCurrentCareerLevel(CurrentCareerLevelAddDTO);
                    if (CurrentCareerLevel != null)
                    {
                        await UnitOfWork.CurrentCareerLevelRepository.Insert(CurrentCareerLevel);
                        isCurrentCareerLevelCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentCareerLevelCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CurrentCareerLevelReturnDTO></returns>
            public async Task<CurrentCareerLevelReturnDTO> GetCurrentCareerLevelById(int CurrentCareerLevelId)
            {
                #region Declare a return type with initial value.
                CurrentCareerLevelReturnDTO CurrentCareerLevel = new CurrentCareerLevelReturnDTO();
                #endregion
                try
                {
                    CurrentCareerLevel currentCareerLevel = await UnitOfWork.CurrentCareerLevelRepository.GetById((byte)CurrentCareerLevelId);
                    if (currentCareerLevel != null)
                    {
                        if (currentCareerLevel.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CurrentCareerLevel = CurrentCareerLevelMapping.MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(currentCareerLevel);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CurrentCareerLevel;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCurrentCareerLevel(CurrentCareerLevelUpdateDTO CurrentCareerLevelUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCurrentCareerLevelUpdated = default(bool);
                #endregion
                try
                {
                    if (CurrentCareerLevelUpdateDTO != null)
                    {
                        #region Vars
                        CurrentCareerLevel CurrentCareerLevel = null;
                        #endregion
                        #region Get Activity By Id
                        CurrentCareerLevel = await UnitOfWork.CurrentCareerLevelRepository.GetById((byte)CurrentCareerLevelUpdateDTO.CurrentCareerLevelId);
                        #endregion
                        if (CurrentCareerLevel != null)
                        {
                            #region  Mapping
                            CurrentCareerLevel = CurrentCareerLevelMapping.MappingCurrentCareerLevelupdateDTOToCurrentCareerLevel(CurrentCareerLevel ,CurrentCareerLevelUpdateDTO);
                            #endregion
                            if (CurrentCareerLevel != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CurrentCareerLevelRepository.Update(CurrentCareerLevel);
                                isCurrentCareerLevelUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentCareerLevelUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCurrentCareerLevel(int CurrentCareerLevelId)
            {
                #region Declare a return type with initial value.
                bool isCurrentCareerLevelDeleted = default(bool);
                #endregion
                try
                {
                    if (CurrentCareerLevelId > default(int))
                    {
                        #region Vars
                        CurrentCareerLevel CurrentCareerLevel = null;
                        #endregion
                        #region Get CurrentCareerLevel by id
                        CurrentCareerLevel = await UnitOfWork.CurrentCareerLevelRepository.GetById((byte)CurrentCareerLevelId);
                        #endregion
                        #region check if object is not null
                        if (CurrentCareerLevel != null)
                        {
                            CurrentCareerLevel.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CurrentCareerLevelRepository.Update(CurrentCareerLevel);
                            isCurrentCareerLevelDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCurrentCareerLevelDeleted;
            }
#endregion
        }
    }




