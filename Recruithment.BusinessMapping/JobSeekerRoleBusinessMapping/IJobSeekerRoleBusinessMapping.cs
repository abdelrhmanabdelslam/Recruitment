using Recruitment.DTOS.JobSeekerRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerRoleBusinessMapping
    {
        Task<List<JobSeekerRoleReturnDTO>> GetAllJobSeekerRoles();
        Task<bool> AddJobSeekerRole(JobSeekerRoleAddDTO JobSeekerRoleAddDTO);
        Task<JobSeekerRoleReturnDTO> GetJobSeekerRoleById(int JobSeekerRoleId);
        Task<bool> UpdateJobSeekerRole(JobSeekerRoleUpdateDTO JobSeekerRoleUpdateDTO);
        Task<bool> DeleteJobSeekerRole(int JobSeekerRoleId);
    }
}

