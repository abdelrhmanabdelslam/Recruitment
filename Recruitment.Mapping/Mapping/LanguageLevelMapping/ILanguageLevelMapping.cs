using Recruitment.DTOS.LanguageLevelDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ILanguageLevelMapping
    {
        List<LanguageLevelReturnDTO> MappingLanguageLevelToLanguageLevelReturnDTO(List<LanguageLevel> LanguageLevelList);
        LanguageLevel MappingLanguageLevelAddDTOToLanguageLevel(LanguageLevelAddDTO LanguageLevelAddDTO);
        LanguageLevel MappingLanguageLevelupdateDTOToLanguageLevel(LanguageLevel LanguageLevel,LanguageLevelUpdateDTO LanguageLevelUpdateDTO);
        LanguageLevelReturnDTO MappingLanguageLevelToLanguageLevelReturnDTO(LanguageLevel LanguageLevel);

    }
}




