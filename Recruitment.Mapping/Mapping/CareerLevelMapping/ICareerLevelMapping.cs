using Recruitment.DTOS.CareerLevelDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICareerLevelMapping
    {
        List<CareerLevelReturnDTO> MappingCareerLevelToCareerLevelReturnDTO(List<CareerLevel> CareerLevelList);
        CareerLevel MappingCareerLevelAddDTOToCareerLevel(CareerLevelAddDTO CareerLevelAddDTO);
        CareerLevel MappingCareerLevelupdateDTOToCareerLevel(CareerLevel CareerLevel,CareerLevelUpdateDTO CareerLevelUpdateDTO);
        CareerLevelReturnDTO MappingCareerLevelToCareerLevelReturnDTO(CareerLevel CareerLevel);

    }
}




