using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CityDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CityAppService : BaseAppService, ICityAppService
    {
        #region Properties
        public ICityBusinessMapping CityBusinessMapping { get; }
        #endregion

        #region Constructor
        public CityAppService(ICityBusinessMapping cityBusinessMapping)
        {
            CityBusinessMapping = cityBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All City ActionActivity Logs for All Citys
        /// </summary>
        /// <returns>List<CityReturnDTO></returns>
        public async Task<List<CityReturnDTO>> GetAllCitys()
        {
            #region Declare a return type with initial value.
            List<CityReturnDTO> allCitys = null;
            #endregion
            try
            {
                allCitys = await CityBusinessMapping.GetAllCitys();
            }
            catch (Exception exception)  {}
            return allCitys;
        }
        /// <summary>
        /// Add City AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCity(CityAddDTO cityAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (cityAddDTO != null)
                {
                    isCreated = await CityBusinessMapping.AddCity(cityAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  City By Id 
        /// </summary>
        /// <returns>CityReturnDTO<CityReturnDTO></returns>
        public async Task<CityReturnDTO> GetCityById(int CityId)
        {
            #region Declare a return type with initial value.
            CityReturnDTO City = null;
            #endregion
            try
            {
                if (CityId > default(int))
                {
                    City = await CityBusinessMapping.GetCityById(CityId);
                }
            }
            catch (Exception exception)  {}
            return City;
        }
        /// <summary>
        /// Updae City AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCity(CityUpdateDTO cityUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (cityUpdateDTO != null)
                {
                    isUpdated = await CityBusinessMapping.UpdateCity(cityUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete City AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCity(int CityId)
        {
            bool isDeleted = false;
            try
            {
                if (CityId > default(int))
                {
                    isDeleted = await CityBusinessMapping.DeleteCity(CityId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




