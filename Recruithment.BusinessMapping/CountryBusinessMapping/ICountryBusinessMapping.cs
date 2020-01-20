using Recruitment.DTOS.CountryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICountryBusinessMapping
    {
        Task<List<CountryReturnDTO>> GetAllCountrys();
        Task<bool> AddCountry(CountryAddDTO CountryAddDTO);
        Task<CountryReturnDTO> GetCountryById(int CountryId);
        Task<bool> UpdateCountry(CountryUpdateDTO CountryUpdateDTO);
        Task<bool> DeleteCountry(int CountryId);
    }
}

