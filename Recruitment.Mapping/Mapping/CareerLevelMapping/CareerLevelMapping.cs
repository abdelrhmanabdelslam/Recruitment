using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CareerLevelDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CareerLevelMapping : IDisposable, ICareerLevelMapping
    {
        public List<CareerLevelReturnDTO> MappingCareerLevelToCareerLevelReturnDTO(List<CareerLevel> CareerLevelList)
        {

            List<CareerLevelReturnDTO> CareerLevelReturnDTOList = null;
            try
            {
                if (CareerLevelList.Any() && CareerLevelList != null)
                {
                    CareerLevelReturnDTOList = CareerLevelList.Select(u => new CareerLevelReturnDTO
                    {
                        CareerLevelId = u.CareerLevelId,
                        CareerLevelName  = u.CareerLevelName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CareerLevelReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CareerLevel></returns>
        public CareerLevel MappingCareerLevelAddDTOToCareerLevel(CareerLevelAddDTO CareerLevelAddDTO)
            {
                #region Declare a return type with initial value.
                CareerLevel CareerLevel = null;
                #endregion
                try
                {
                    CareerLevel = new CareerLevel
                    {
                        CareerLevelName = CareerLevelAddDTO.CareerLevelName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CareerLevel;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CareerLevel MappingCareerLevelupdateDTOToCareerLevel(CareerLevel careerLevel, CareerLevelUpdateDTO CareerLevelUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CareerLevel CareerLevel = careerLevel;
                #endregion
                try
                {
                    if (CareerLevelUpdateDTO.CareerLevelId > default(int))
                    {
                        CareerLevel.CareerLevelId = CareerLevelUpdateDTO.CareerLevelId;
                        CareerLevel.CareerLevelName = CareerLevelUpdateDTO.CareerLevelName;
                    }
                }
                catch (Exception exception) { }
                return CareerLevel;
            }
            public CareerLevelReturnDTO MappingCareerLevelToCareerLevelReturnDTO(CareerLevel CareerLevel)
            {
                #region Declare a return type with initial value.
                CareerLevelReturnDTO CareerLevelReturnDTO = null;
                #endregion
                try
                {
                    if (CareerLevel != null)
                    {
                        CareerLevelReturnDTO = new CareerLevelReturnDTO
                        {
                            CareerLevelId = CareerLevel.CareerLevelId,
                            CareerLevelName = CareerLevel.CareerLevelName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CareerLevelReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




