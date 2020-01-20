using Recruitment.DTOS.CityDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICityBusinessMapping
    {
        Task<List<CityReturnDTO>> GetAllCitys();
        Task<bool> AddCity(CityAddDTO CityAddDTO);
        Task<CityReturnDTO> GetCityById(int CityId);
        Task<bool> UpdateCity(CityUpdateDTO CityUpdateDTO);
        Task<bool> DeleteCity(int CityId);
    }
}

