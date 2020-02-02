
using Recruitment.DTOS.JobSeekerExperienceDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerExperienceAppService
    {
        Task<List<JobSeekerExperienceReturnDTO>> GetAllJobSeekerExperiences();
        Task<bool> AddJobSeekerExperience(JobSeekerExperienceAddDTO userAddDTO);
        Task<JobSeekerExperienceReturnDTO> GetJobSeekerExperienceById(int JobSeekerExperienceId);
        Task<bool> UpdateJobSeekerExperience(JobSeekerExperienceUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerExperience(int JobSeekerExperienceId);
    }
}




