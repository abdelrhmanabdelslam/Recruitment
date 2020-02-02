
using Recruitment.DTOS.JobSeekerRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerRoleAppService
    {
        Task<List<JobSeekerRoleReturnDTO>> GetAllJobSeekerRoles();
        Task<bool> AddJobSeekerRole(JobSeekerRoleAddDTO userAddDTO);
        Task<JobSeekerRoleReturnDTO> GetJobSeekerRoleById(int JobSeekerRoleId);
        Task<bool> UpdateJobSeekerRole(JobSeekerRoleUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerRole(int JobSeekerRoleId);
    }
}




