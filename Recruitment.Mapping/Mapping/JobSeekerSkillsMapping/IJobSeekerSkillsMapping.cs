using Recruitment.DTOS.JobSeekerSkillsDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerSkillsMapping
    {
        List<JobSeekerSkillsReturnDTO> MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(List<JobSeekerSkills> JobSeekerSkillsList);
        JobSeekerSkills MappingJobSeekerSkillsAddDTOToJobSeekerSkills(JobSeekerSkillsAddDTO JobSeekerSkillsAddDTO);
        JobSeekerSkills MappingJobSeekerSkillsupdateDTOToJobSeekerSkills(JobSeekerSkills JobSeekerSkills,JobSeekerSkillsUpdateDTO JobSeekerSkillsUpdateDTO);
        JobSeekerSkillsReturnDTO MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(JobSeekerSkills JobSeekerSkills);

    }
}




