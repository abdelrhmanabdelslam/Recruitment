using Recruitment.DTOS.JobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobRoleBusinessMapping
    {
        Task<List<JobRoleReturnDTO>> GetAllJobRoles();
        Task<bool> AddJobRole(JobRoleAddDTO JobRoleAddDTO);
        Task<JobRoleReturnDTO> GetJobRoleById(int JobRoleId);
        Task<bool> UpdateJobRole(JobRoleUpdateDTO JobRoleUpdateDTO);
        Task<bool> DeleteJobRole(int JobRoleId);
    }
}

