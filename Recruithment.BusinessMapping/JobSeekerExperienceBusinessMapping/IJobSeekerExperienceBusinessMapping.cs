using Recruitment.DTOS.JobSeekerExperienceDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerExperienceBusinessMapping
    {
        Task<List<JobSeekerExperienceReturnDTO>> GetAllJobSeekerExperiences();
        Task<bool> AddJobSeekerExperience(JobSeekerExperienceAddDTO JobSeekerExperienceAddDTO);
        Task<JobSeekerExperienceReturnDTO> GetJobSeekerExperienceById(int JobSeekerExperienceId);
        Task<bool> UpdateJobSeekerExperience(JobSeekerExperienceUpdateDTO JobSeekerExperienceUpdateDTO);
        Task<bool> DeleteJobSeekerExperience(int JobSeekerExperienceId);
    }
}

