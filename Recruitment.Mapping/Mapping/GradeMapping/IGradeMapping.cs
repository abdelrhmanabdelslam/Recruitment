using Recruitment.DTOS.GradeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IGradeMapping
    {
        List<GradeReturnDTO> MappingGradeToGradeReturnDTO(List<Grade> GradeList);
        Grade MappingGradeAddDTOToGrade(GradeAddDTO GradeAddDTO);
        Grade MappingGradeupdateDTOToGrade(Grade Grade, GradeUpdateDTO GradeUpdateDTO);
        GradeReturnDTO MappingGradeToGradeReturnDTO(Grade Grade);

    }
}


