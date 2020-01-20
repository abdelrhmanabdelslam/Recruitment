using Recruitment.DTOS.CareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICareerLevelBusinessMapping
    {
        Task<List<CareerLevelReturnDTO>> GetAllCareerLevels();
        Task<bool> AddCareerLevel(CareerLevelAddDTO CareerLevelAddDTO);
        Task<CareerLevelReturnDTO> GetCareerLevelById(int CareerLevelId);
        Task<bool> UpdateCareerLevel(CareerLevelUpdateDTO CareerLevelUpdateDTO);
        Task<bool> DeleteCareerLevel(int CareerLevelId);
    }
}

