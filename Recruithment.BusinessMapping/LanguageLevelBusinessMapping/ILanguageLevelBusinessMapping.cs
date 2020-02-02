using Recruitment.DTOS.LanguageLevelDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ILanguageLevelBusinessMapping
    {
        Task<List<LanguageLevelReturnDTO>> GetAllLanguageLevels();
        Task<bool> AddLanguageLevel(LanguageLevelAddDTO LanguageLevelAddDTO);
        Task<LanguageLevelReturnDTO> GetLanguageLevelById(int LanguageLevelId);
        Task<bool> UpdateLanguageLevel(LanguageLevelUpdateDTO LanguageLevelUpdateDTO);
        Task<bool> DeleteLanguageLevel(int LanguageLevelId);
    }
}

