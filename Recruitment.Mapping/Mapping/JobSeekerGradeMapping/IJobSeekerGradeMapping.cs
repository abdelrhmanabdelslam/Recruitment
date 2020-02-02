using Recruitment.DTOS.JobSeekerGradeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerGradeMapping
    {
        List<JobSeekerGradeReturnDTO> MappingJobSeekerGradeToJobSeekerGradeReturnDTO(List<JobSeekerGrade> JobSeekerGradeList);
        JobSeekerGrade MappingJobSeekerGradeAddDTOToJobSeekerGrade(JobSeekerGradeAddDTO JobSeekerGradeAddDTO);
        JobSeekerGrade MappingJobSeekerGradeupdateDTOToJobSeekerGrade(JobSeekerGrade JobSeekerGrade,JobSeekerGradeUpdateDTO JobSeekerGradeUpdateDTO);
        JobSeekerGradeReturnDTO MappingJobSeekerGradeToJobSeekerGradeReturnDTO(JobSeekerGrade JobSeekerGrade);

    }
}




