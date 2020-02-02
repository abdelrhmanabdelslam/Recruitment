using Recruitment.DTOS.LanguageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ILanguageBusinessMapping
    {
        Task<List<LanguageReturnDTO>> GetAllLanguages();
        Task<bool> AddLanguage(LanguageAddDTO LanguageAddDTO);
        Task<LanguageReturnDTO> GetLanguageById(int LanguageId);
        Task<bool> UpdateLanguage(LanguageUpdateDTO LanguageUpdateDTO);
        Task<bool> DeleteLanguage(int LanguageId);
    }
}

