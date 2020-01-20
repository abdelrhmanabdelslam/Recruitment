
using Recruitment.DTOS.CurrentCareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICurrentCareerLevelAppService
    {
        Task<List<CurrentCareerLevelReturnDTO>> GetAllCurrentCareerLevels();
        Task<bool> AddCurrentCareerLevel(CurrentCareerLevelAddDTO userAddDTO);
        Task<CurrentCareerLevelReturnDTO> GetCurrentCareerLevelById(int CurrentCareerLevelId);
        Task<bool> UpdateCurrentCareerLevel(CurrentCareerLevelUpdateDTO userUpdateDTO);
        Task<bool> DeleteCurrentCareerLevel(int CurrentCareerLevelId);
    }
}




