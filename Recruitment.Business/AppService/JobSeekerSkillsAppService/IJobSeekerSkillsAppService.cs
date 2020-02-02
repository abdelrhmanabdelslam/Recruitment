
using Recruitment.DTOS.JobSeekerSkillsDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerSkillsAppService
    {
        Task<List<JobSeekerSkillsReturnDTO>> GetAllJobSeekerSkillss();
        Task<bool> AddJobSeekerSkills(JobSeekerSkillsAddDTO userAddDTO);
        Task<JobSeekerSkillsReturnDTO> GetJobSeekerSkillsById(int JobSeekerSkillsId);
        Task<bool> UpdateJobSeekerSkills(JobSeekerSkillsUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerSkills(int JobSeekerSkillsId);
    }
}




