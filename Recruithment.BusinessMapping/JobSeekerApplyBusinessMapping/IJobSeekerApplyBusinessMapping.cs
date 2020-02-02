using Recruitment.DTOS.JobSeekerApplyDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerApplyBusinessMapping
    {
        Task<List<JobSeekerApplyReturnDTO>> GetAllJobSeekerApplys();
        Task<bool> AddJobSeekerApply(JobSeekerApplyAddDTO JobSeekerApplyAddDTO);
        Task<JobSeekerApplyReturnDTO> GetJobSeekerApplyById(int JobSeekerApplyId);
        Task<bool> UpdateJobSeekerApply(JobSeekerApplyUpdateDTO JobSeekerApplyUpdateDTO);
        Task<bool> DeleteJobSeekerApply(int JobSeekerApplyId);
    }
}

