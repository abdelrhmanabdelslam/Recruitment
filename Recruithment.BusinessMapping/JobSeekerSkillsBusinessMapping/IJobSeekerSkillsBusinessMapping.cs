using Recruitment.DTOS.JobSeekerSkillsDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerSkillsBusinessMapping
    {
        Task<List<JobSeekerSkillsReturnDTO>> GetAllJobSeekerSkillss();
        Task<bool> AddJobSeekerSkills(JobSeekerSkillsAddDTO JobSeekerSkillsAddDTO);
        Task<JobSeekerSkillsReturnDTO> GetJobSeekerSkillsById(int JobSeekerSkillsId);
        Task<bool> UpdateJobSeekerSkills(JobSeekerSkillsUpdateDTO JobSeekerSkillsUpdateDTO);
        Task<bool> DeleteJobSeekerSkills(int JobSeekerSkillsId);
    }
}

