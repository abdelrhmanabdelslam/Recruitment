
using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICurrentEducationalLevelAppService
    {
        Task<List<CurrentEducationalLevelReturnDTO>> GetAllCurrentEducationalLevels();
        Task<bool> AddCurrentEducationalLevel(CurrentEducationalLevelAddDTO userAddDTO);
        Task<CurrentEducationalLevelReturnDTO> GetCurrentEducationalLevelById(int CurrentEducationalLevelId);
        Task<bool> UpdateCurrentEducationalLevel(CurrentEducationalLevelUpdateDTO userUpdateDTO);
        Task<bool> DeleteCurrentEducationalLevel(int CurrentEducationalLevelId);
    }
}




