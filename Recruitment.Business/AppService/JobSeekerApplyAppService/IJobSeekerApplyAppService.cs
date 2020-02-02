
using Recruitment.DTOS.JobSeekerApplyDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerApplyAppService
    {
        Task<List<JobSeekerApplyReturnDTO>> GetAllJobSeekerApplys();
        Task<bool> AddJobSeekerApply(JobSeekerApplyAddDTO userAddDTO);
        Task<JobSeekerApplyReturnDTO> GetJobSeekerApplyById(int JobSeekerApplyId);
        Task<bool> UpdateJobSeekerApply(JobSeekerApplyUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerApply(int JobSeekerApplyId);
    }
}




