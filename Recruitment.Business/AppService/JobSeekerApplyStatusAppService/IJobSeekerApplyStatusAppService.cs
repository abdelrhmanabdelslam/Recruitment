
using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerApplyStatusAppService
    {
        Task<List<JobSeekerApplyStatusReturnDTO>> GetAllJobSeekerApplyStatuss();
        Task<bool> AddJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO userAddDTO);
        Task<JobSeekerApplyStatusReturnDTO> GetJobSeekerApplyStatusById(int JobSeekerApplyStatusId);
        Task<bool> UpdateJobSeekerApplyStatus(JobSeekerApplyStatusUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerApplyStatus(int JobSeekerApplyStatusId);
    }
}




