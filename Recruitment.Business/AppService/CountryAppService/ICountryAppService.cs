
using Recruitment.DTOS.CountryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICountryAppService
    {
        Task<List<CountryReturnDTO>> GetAllCountrys();
        Task<bool> AddCountry(CountryAddDTO userAddDTO);
        Task<CountryReturnDTO> GetCountryById(int CountryId);
        Task<bool> UpdateCountry(CountryUpdateDTO userUpdateDTO);
        Task<bool> DeleteCountry(int CountryId);
    }
}




