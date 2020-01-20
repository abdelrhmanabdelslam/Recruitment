using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CareerLevelDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CareerLevelBusinessMapping : BaseBusinessMapping, ICareerLevelBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICareerLevelMapping CareerLevelMapping { get; }
        #endregion

        #region Constructor
        public CareerLevelBusinessMapping(IUnitOfWork unitOfWork, ICareerLevelMapping careerLevelMapping)
        {
            UnitOfWork = unitOfWork;
            CareerLevelMapping = careerLevelMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CareerLevelReturnDTO></returns>
        public async Task<List<CareerLevelReturnDTO>> GetAllCareerLevels()
        {
            #region Declare Return Var with Intial Value
            List<CareerLevelReturnDTO> allCareerLevels = null;
            #endregion
            try
            {
                #region Vars
                List<CareerLevel> CareerLevelList = null;
                #endregion
                CareerLevelList = await UnitOfWork.CareerLevelRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CareerLevelList != null && CareerLevelList.Any())
                {
                    allCareerLevels = CareerLevelMapping.MappingCareerLevelToCareerLevelReturnDTO(CareerLevelList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCareerLevels;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCareerLevel(CareerLevelAddDTO CareerLevelAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCareerLevelCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CareerLevel CareerLevel = null;
                    #endregion
                    CareerLevel = CareerLevelMapping.MappingCareerLevelAddDTOToCareerLevel(CareerLevelAddDTO);
                    if (CareerLevel != null)
                    {
                        await UnitOfWork.CareerLevelRepository.Insert(CareerLevel);
                        isCareerLevelCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCareerLevelCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CareerLevelReturnDTO></returns>
            public async Task<CareerLevelReturnDTO> GetCareerLevelById(int CareerLevelId)
            {
                #region Declare a return type with initial value.
                CareerLevelReturnDTO CareerLevel = new CareerLevelReturnDTO();
                #endregion
                try
                {
                    CareerLevel careerLevel = await UnitOfWork.CareerLevelRepository.GetById((byte)CareerLevelId);
                    if (careerLevel != null)
                    {
                        if (careerLevel.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CareerLevel = CareerLevelMapping.MappingCareerLevelToCareerLevelReturnDTO(careerLevel);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CareerLevel;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCareerLevel(CareerLevelUpdateDTO CareerLevelUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCareerLevelUpdated = default(bool);
                #endregion
                try
                {
                    if (CareerLevelUpdateDTO != null)
                    {
                        #region Vars
                        CareerLevel CareerLevel = null;
                        #endregion
                        #region Get Activity By Id
                        CareerLevel = await UnitOfWork.CareerLevelRepository.GetById((byte)CareerLevelUpdateDTO.CareerLevelId);
                        #endregion
                        if (CareerLevel != null)
                        {
                            #region  Mapping
                            CareerLevel = CareerLevelMapping.MappingCareerLevelupdateDTOToCareerLevel(CareerLevel ,CareerLevelUpdateDTO);
                            #endregion
                            if (CareerLevel != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CareerLevelRepository.Update(CareerLevel);
                                isCareerLevelUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCareerLevelUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCareerLevel(int CareerLevelId)
            {
                #region Declare a return type with initial value.
                bool isCareerLevelDeleted = default(bool);
                #endregion
                try
                {
                    if (CareerLevelId > default(int))
                    {
                        #region Vars
                        CareerLevel CareerLevel = null;
                        #endregion
                        #region Get CareerLevel by id
                        CareerLevel = await UnitOfWork.CareerLevelRepository.GetById((byte)CareerLevelId);
                        #endregion
                        #region check if object is not null
                        if (CareerLevel != null)
                        {
                            CareerLevel.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CareerLevelRepository.Update(CareerLevel);
                            isCareerLevelDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCareerLevelDeleted;
            }
#endregion
        }
    }




