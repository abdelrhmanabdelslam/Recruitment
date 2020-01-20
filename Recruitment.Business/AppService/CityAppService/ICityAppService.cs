
using Recruitment.DTOS.CityDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICityAppService
    {
        Task<List<CityReturnDTO>> GetAllCitys();
        Task<bool> AddCity(CityAddDTO userAddDTO);
        Task<CityReturnDTO> GetCityById(int CityId);
        Task<bool> UpdateCity(CityUpdateDTO userUpdateDTO);
        Task<bool> DeleteCity(int CityId);
    }
}




