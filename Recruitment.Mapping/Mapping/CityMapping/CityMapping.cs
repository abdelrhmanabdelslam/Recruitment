using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CityDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CityMapping : IDisposable, ICityMapping
    {
        public List<CityReturnDTO> MappingCityToCityReturnDTO(List<City> CityList)
        {

            List<CityReturnDTO> CityReturnDTOList = null;
            try
            {
                if (CityList.Any() && CityList != null)
                {
                    CityReturnDTOList = CityList.Select(u => new CityReturnDTO
                    {
                        CityId = u.CityId,
                        CountyId =(int) u.CountyId ,
                        CityName  = u.CityName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CityReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<City></returns>
        public City MappingCityAddDTOToCity(CityAddDTO CityAddDTO)
            {
                #region Declare a return type with initial value.
                City City = null;
                #endregion
                try
                {
                    City = new City
                    {
                        CityName = CityAddDTO.CityName,
                        CountyId = CityAddDTO.CountyId ,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return City;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public City MappingCityupdateDTOToCity(City city, CityUpdateDTO CityUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                City City = city;
                #endregion
                try
                {
                    if (CityUpdateDTO.CityId > default(int))
                    {
                        City.CityId = CityUpdateDTO.CityId;
                        City.CountyId  = CityUpdateDTO.CountyId ;
                    City.CityName = CityUpdateDTO.CityName;
                    }
                }
                catch (Exception exception) { }
                return City;
            }
            public CityReturnDTO MappingCityToCityReturnDTO(City City)
            {
                #region Declare a return type with initial value.
                CityReturnDTO CityReturnDTO = null;
                #endregion
                try
                {
                    if (City != null)
                    {
                        CityReturnDTO = new CityReturnDTO
                        {
                            CityId = City.CityId,
                            CountyId = (int)City.CountyId,
                            CityName = City.CityName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CityReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




