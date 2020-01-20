
using Recruitment.DTOS.JobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobRoleAppService
    {
        Task<List<JobRoleReturnDTO>> GetAllJobRoles();
        Task<bool> AddJobRole(JobRoleAddDTO userAddDTO);
        Task<JobRoleReturnDTO> GetJobRoleById(int JobRoleId);
        Task<bool> UpdateJobRole(JobRoleUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobRole(int JobRoleId);
    }
}




