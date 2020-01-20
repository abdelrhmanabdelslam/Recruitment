using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CountryDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CountryAppService : BaseAppService, ICountryAppService
    {
        #region Properties
        public ICountryBusinessMapping CountryBusinessMapping { get; }
        #endregion

        #region Constructor
        public CountryAppService(ICountryBusinessMapping countryBusinessMapping)
        {
            CountryBusinessMapping = countryBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Country ActionActivity Logs for All Countrys
        /// </summary>
        /// <returns>List<CountryReturnDTO></returns>
        public async Task<List<CountryReturnDTO>> GetAllCountrys()
        {
            #region Declare a return type with initial value.
            List<CountryReturnDTO> allCountrys = null;
            #endregion
            try
            {
                allCountrys = await CountryBusinessMapping.GetAllCountrys();
            }
            catch (Exception exception)  {}
            return allCountrys;
        }
        /// <summary>
        /// Add Country AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCountry(CountryAddDTO countryAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (countryAddDTO != null)
                {
                    isCreated = await CountryBusinessMapping.AddCountry(countryAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Country By Id 
        /// </summary>
        /// <returns>CountryReturnDTO<CountryReturnDTO></returns>
        public async Task<CountryReturnDTO> GetCountryById(int CountryId)
        {
            #region Declare a return type with initial value.
            CountryReturnDTO Country = null;
            #endregion
            try
            {
                if (CountryId > default(int))
                {
                    Country = await CountryBusinessMapping.GetCountryById(CountryId);
                }
            }
            catch (Exception exception)  {}
            return Country;
        }
        /// <summary>
        /// Updae Country AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCountry(CountryUpdateDTO countryUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (countryUpdateDTO != null)
                {
                    isUpdated = await CountryBusinessMapping.UpdateCountry(countryUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Country AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCountry(int CountryId)
        {
            bool isDeleted = false;
            try
            {
                if (CountryId > default(int))
                {
                    isDeleted = await CountryBusinessMapping.DeleteCountry(CountryId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




