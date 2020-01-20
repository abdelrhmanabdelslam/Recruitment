using Recruitment.DTOS.CurrentCareerLevelDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICurrentCareerLevelMapping
    {
        List<CurrentCareerLevelReturnDTO> MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(List<CurrentCareerLevel> CurrentCareerLevelList);
        CurrentCareerLevel MappingCurrentCareerLevelAddDTOToCurrentCareerLevel(CurrentCareerLevelAddDTO CurrentCareerLevelAddDTO);
        CurrentCareerLevel MappingCurrentCareerLevelupdateDTOToCurrentCareerLevel(CurrentCareerLevel CurrentCareerLevel,CurrentCareerLevelUpdateDTO CurrentCareerLevelUpdateDTO);
        CurrentCareerLevelReturnDTO MappingCurrentCareerLevelToCurrentCareerLevelReturnDTO(CurrentCareerLevel CurrentCareerLevel);

    }
}




