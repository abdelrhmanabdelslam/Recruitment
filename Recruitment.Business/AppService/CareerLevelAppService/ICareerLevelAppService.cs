
using Recruitment.DTOS.CareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICareerLevelAppService
    {
        Task<List<CareerLevelReturnDTO>> GetAllCareerLevels();
        Task<bool> AddCareerLevel(CareerLevelAddDTO userAddDTO);
        Task<CareerLevelReturnDTO> GetCareerLevelById(int CareerLevelId);
        Task<bool> UpdateCareerLevel(CareerLevelUpdateDTO userUpdateDTO);
        Task<bool> DeleteCareerLevel(int CareerLevelId);
    }
}




