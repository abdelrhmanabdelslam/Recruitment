using Recruitment.DTOS.TypeOfJobDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ITypeOfJobMapping
    {
        List<TypeOfJobReturnDTO> MappingTypeOfJobToTypeOfJobReturnDTO(List<TypeOfJob> TypeOfJobList);
        TypeOfJob MappingTypeOfJobAddDTOToTypeOfJob(TypeOfJobAddDTO TypeOfJobAddDTO);
        TypeOfJob MappingTypeOfJobupdateDTOToTypeOfJob(TypeOfJob TypeOfJob,TypeOfJobUpdateDTO TypeOfJobUpdateDTO);
        TypeOfJobReturnDTO MappingTypeOfJobToTypeOfJobReturnDTO(TypeOfJob TypeOfJob);

    }
}




