using Recruitment.DTOS.CurrentCareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICurrentCareerLevelBusinessMapping
    {
        Task<List<CurrentCareerLevelReturnDTO>> GetAllCurrentCareerLevels();
        Task<bool> AddCurrentCareerLevel(CurrentCareerLevelAddDTO CurrentCareerLevelAddDTO);
        Task<CurrentCareerLevelReturnDTO> GetCurrentCareerLevelById(int CurrentCareerLevelId);
        Task<bool> UpdateCurrentCareerLevel(CurrentCareerLevelUpdateDTO CurrentCareerLevelUpdateDTO);
        Task<bool> DeleteCurrentCareerLevel(int CurrentCareerLevelId);
    }
}

