
using Recruitment.DTOS.LanguageLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ILanguageLevelAppService
    {
        Task<List<LanguageLevelReturnDTO>> GetAllLanguageLevels();
        Task<bool> AddLanguageLevel(LanguageLevelAddDTO userAddDTO);
        Task<LanguageLevelReturnDTO> GetLanguageLevelById(int LanguageLevelId);
        Task<bool> UpdateLanguageLevel(LanguageLevelUpdateDTO userUpdateDTO);
        Task<bool> DeleteLanguageLevel(int LanguageLevelId);
    }
}




