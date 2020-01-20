using Recruitment.DTOS.CurrentEducationalLevelDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICurrentEducationalLevelMapping
    {
        List<CurrentEducationalLevelReturnDTO> MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(List<CurrentEducationalLevel> CurrentEducationalLevelList);
        CurrentEducationalLevel MappingCurrentEducationalLevelAddDTOToCurrentEducationalLevel(CurrentEducationalLevelAddDTO CurrentEducationalLevelAddDTO);
        CurrentEducationalLevel MappingCurrentEducationalLevelupdateDTOToCurrentEducationalLevel(CurrentEducationalLevel CurrentEducationalLevel,CurrentEducationalLevelUpdateDTO CurrentEducationalLevelUpdateDTO);
        CurrentEducationalLevelReturnDTO MappingCurrentEducationalLevelToCurrentEducationalLevelReturnDTO(CurrentEducationalLevel CurrentEducationalLevel);

    }
}




