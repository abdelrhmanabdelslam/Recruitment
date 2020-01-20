using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CountryDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CountryMapping : IDisposable, ICountryMapping
    {
        public List<CountryReturnDTO> MappingCountryToCountryReturnDTO(List<Country> CountryList)
        {

            List<CountryReturnDTO> CountryReturnDTOList = null;
            try
            {
                if (CountryList.Any() && CountryList != null)
                {
                    CountryReturnDTOList = CountryList.Select(u => new CountryReturnDTO
                    {
                        CountryId = u.CountryId,
                        CountryName  = u.CountryName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CountryReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Country></returns>
        public Country MappingCountryAddDTOToCountry(CountryAddDTO CountryAddDTO)
            {
                #region Declare a return type with initial value.
                Country Country = null;
                #endregion
                try
                {
                    Country = new Country
                    {
                        CountryName = CountryAddDTO.CountryName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Country;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Country MappingCountryupdateDTOToCountry(Country country, CountryUpdateDTO CountryUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Country Country = country;
                #endregion
                try
                {
                    if (CountryUpdateDTO.CountryId > default(int))
                    {
                        Country.CountryId = CountryUpdateDTO.CountryId;
                        Country.CountryName = CountryUpdateDTO.CountryName;
                    }
                }
                catch (Exception exception) { }
                return Country;
            }
            public CountryReturnDTO MappingCountryToCountryReturnDTO(Country Country)
            {
                #region Declare a return type with initial value.
                CountryReturnDTO CountryReturnDTO = null;
                #endregion
                try
                {
                    if (Country != null)
                    {
                        CountryReturnDTO = new CountryReturnDTO
                        {
                            CountryId = Country.CountryId,
                            CountryName = Country.CountryName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CountryReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




