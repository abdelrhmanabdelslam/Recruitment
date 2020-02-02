using Recruitment.DTOS.JobSeekerExperienceDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerExperienceMapping
    {
        List<JobSeekerExperienceReturnDTO> MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(List<JobSeekerExperience> JobSeekerExperienceList);
        JobSeekerExperience MappingJobSeekerExperienceAddDTOToJobSeekerExperience(JobSeekerExperienceAddDTO JobSeekerExperienceAddDTO);
        JobSeekerExperience MappingJobSeekerExperienceupdateDTOToJobSeekerExperience(JobSeekerExperience JobSeekerExperience,JobSeekerExperienceUpdateDTO JobSeekerExperienceUpdateDTO);
        JobSeekerExperienceReturnDTO MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(JobSeekerExperience JobSeekerExperience);

    }
}




