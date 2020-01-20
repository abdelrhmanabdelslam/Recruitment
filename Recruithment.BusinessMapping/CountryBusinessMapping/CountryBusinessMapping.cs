using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CountryDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CountryBusinessMapping : BaseBusinessMapping, ICountryBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICountryMapping CountryMapping { get; }
        #endregion

        #region Constructor
        public CountryBusinessMapping(IUnitOfWork unitOfWork, ICountryMapping countryMapping)
        {
            UnitOfWork = unitOfWork;
            CountryMapping = countryMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CountryReturnDTO></returns>
        public async Task<List<CountryReturnDTO>> GetAllCountrys()
        {
            #region Declare Return Var with Intial Value
            List<CountryReturnDTO> allCountrys = null;
            #endregion
            try
            {
                #region Vars
                List<Country> CountryList = null;
                #endregion
                CountryList = await UnitOfWork.CountryRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CountryList != null && CountryList.Any())
                {
                    allCountrys = CountryMapping.MappingCountryToCountryReturnDTO(CountryList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCountrys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCountry(CountryAddDTO CountryAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCountryCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Country Country = null;
                    #endregion
                    Country = CountryMapping.MappingCountryAddDTOToCountry(CountryAddDTO);
                    if (Country != null)
                    {
                        await UnitOfWork.CountryRepository.Insert(Country);
                        isCountryCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCountryCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CountryReturnDTO></returns>
            public async Task<CountryReturnDTO> GetCountryById(int CountryId)
            {
                #region Declare a return type with initial value.
                CountryReturnDTO Country = new CountryReturnDTO();
                #endregion
                try
                {
                    Country country = await UnitOfWork.CountryRepository.GetById(CountryId);
                    if (country != null)
                    {
                        if (country.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Country = CountryMapping.MappingCountryToCountryReturnDTO(country);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Country;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCountry(CountryUpdateDTO CountryUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCountryUpdated = default(bool);
                #endregion
                try
                {
                    if (CountryUpdateDTO != null)
                    {
                        #region Vars
                        Country Country = null;
                        #endregion
                        #region Get Activity By Id
                        Country = await UnitOfWork.CountryRepository.GetById(CountryUpdateDTO.CountryId);
                        #endregion
                        if (Country != null)
                        {
                            #region  Mapping
                            Country = CountryMapping.MappingCountryupdateDTOToCountry(Country ,CountryUpdateDTO);
                            #endregion
                            if (Country != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CountryRepository.Update(Country);
                                isCountryUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCountryUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCountry(int CountryId)
            {
                #region Declare a return type with initial value.
                bool isCountryDeleted = default(bool);
                #endregion
                try
                {
                    if (CountryId > default(int))
                    {
                        #region Vars
                        Country Country = null;
                        #endregion
                        #region Get Country by id
                        Country = await UnitOfWork.CountryRepository.GetById(CountryId);
                        #endregion
                        #region check if object is not null
                        if (Country != null)
                        {
                            Country.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CountryRepository.Update(Country);
                            isCountryDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCountryDeleted;
            }
#endregion
        }
    }




