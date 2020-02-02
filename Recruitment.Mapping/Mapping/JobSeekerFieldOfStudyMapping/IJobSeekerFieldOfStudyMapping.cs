using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerFieldOfStudyMapping
    {
        List<JobSeekerFieldOfStudyReturnDTO> MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(List<JobSeekerFieldOfStudy> JobSeekerFieldOfStudyList);
        JobSeekerFieldOfStudy MappingJobSeekerFieldOfStudyAddDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO JobSeekerFieldOfStudyAddDTO);
        JobSeekerFieldOfStudy MappingJobSeekerFieldOfStudyupdateDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudy JobSeekerFieldOfStudy,JobSeekerFieldOfStudyUpdateDTO JobSeekerFieldOfStudyUpdateDTO);
        JobSeekerFieldOfStudyReturnDTO MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(JobSeekerFieldOfStudy JobSeekerFieldOfStudy);

    }
}




