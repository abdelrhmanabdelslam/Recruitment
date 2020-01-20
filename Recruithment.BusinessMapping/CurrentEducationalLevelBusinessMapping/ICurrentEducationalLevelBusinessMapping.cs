using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICurrentEducationalLevelBusinessMapping
    {
        Task<List<CurrentEducationalLevelReturnDTO>> GetAllCurrentEducationalLevels();
        Task<bool> AddCurrentEducationalLevel(CurrentEducationalLevelAddDTO CurrentEducationalLevelAddDTO);
        Task<CurrentEducationalLevelReturnDTO> GetCurrentEducationalLevelById(int CurrentEducationalLevelId);
        Task<bool> UpdateCurrentEducationalLevel(CurrentEducationalLevelUpdateDTO CurrentEducationalLevelUpdateDTO);
        Task<bool> DeleteCurrentEducationalLevel(int CurrentEducationalLevelId);
    }
}

