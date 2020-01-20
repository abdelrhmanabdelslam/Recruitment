using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CityDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CityBusinessMapping : BaseBusinessMapping, ICityBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICityMapping CityMapping { get; }
        #endregion

        #region Constructor
        public CityBusinessMapping(IUnitOfWork unitOfWork, ICityMapping cityMapping)
        {
            UnitOfWork = unitOfWork;
            CityMapping = cityMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CityReturnDTO></returns>
        public async Task<List<CityReturnDTO>> GetAllCitys()
        {
            #region Declare Return Var with Intial Value
            List<CityReturnDTO> allCitys = null;
            #endregion
            try
            {
                #region Vars
                List<City> CityList = null;
                #endregion
                CityList = await UnitOfWork.CityRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CityList != null && CityList.Any())
                {
                    allCitys = CityMapping.MappingCityToCityReturnDTO(CityList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCitys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCity(CityAddDTO CityAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCityCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    City City = null;
                    #endregion
                    City = CityMapping.MappingCityAddDTOToCity(CityAddDTO);
                    if (City != null)
                    {
                        await UnitOfWork.CityRepository.Insert(City);
                        isCityCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCityCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CityReturnDTO></returns>
            public async Task<CityReturnDTO> GetCityById(int CityId)
            {
                #region Declare a return type with initial value.
                CityReturnDTO City = new CityReturnDTO();
                #endregion
                try
                {
                    City city = await UnitOfWork.CityRepository.GetById(CityId);
                    if (city != null)
                    {
                        if (city.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            City = CityMapping.MappingCityToCityReturnDTO(city);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return City;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCity(CityUpdateDTO CityUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCityUpdated = default(bool);
                #endregion
                try
                {
                    if (CityUpdateDTO != null)
                    {
                        #region Vars
                        City City = null;
                        #endregion
                        #region Get Activity By Id
                        City = await UnitOfWork.CityRepository.GetById(CityUpdateDTO.CityId);
                        #endregion
                        if (City != null)
                        {
                            #region  Mapping
                            City = CityMapping.MappingCityupdateDTOToCity(City ,CityUpdateDTO);
                            #endregion
                            if (City != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CityRepository.Update(City);
                                isCityUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCityUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCity(int CityId)
            {
                #region Declare a return type with initial value.
                bool isCityDeleted = default(bool);
                #endregion
                try
                {
                    if (CityId > default(int))
                    {
                        #region Vars
                        City City = null;
                        #endregion
                        #region Get City by id
                        City = await UnitOfWork.CityRepository.GetById(CityId);
                        #endregion
                        #region check if object is not null
                        if (City != null)
                        {
                            City.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CityRepository.Update(City);
                            isCityDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCityDeleted;
            }
#endregion
        }
    }




