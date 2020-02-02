using Recruitment.DTOS.LanguageDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ILanguageMapping
    {
        List<LanguageReturnDTO> MappingLanguageToLanguageReturnDTO(List<Language> LanguageList);
        Language MappingLanguageAddDTOToLanguage(LanguageAddDTO LanguageAddDTO);
        Language MappingLanguageupdateDTOToLanguage(Language Language,LanguageUpdateDTO LanguageUpdateDTO);
        LanguageReturnDTO MappingLanguageToLanguageReturnDTO(Language Language);

    }
}




