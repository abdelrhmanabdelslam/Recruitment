
using Recruitment.DTOS.LanguageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ILanguageAppService
    {
        Task<List<LanguageReturnDTO>> GetAllLanguages();
        Task<bool> AddLanguage(LanguageAddDTO userAddDTO);
        Task<LanguageReturnDTO> GetLanguageById(int LanguageId);
        Task<bool> UpdateLanguage(LanguageUpdateDTO userUpdateDTO);
        Task<bool> DeleteLanguage(int LanguageId);
    }
}




