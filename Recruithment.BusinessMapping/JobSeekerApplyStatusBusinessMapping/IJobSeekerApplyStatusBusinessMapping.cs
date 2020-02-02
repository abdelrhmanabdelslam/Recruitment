using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerApplyStatusBusinessMapping
    {
        Task<List<JobSeekerApplyStatusReturnDTO>> GetAllJobSeekerApplyStatuss();
        Task<bool> AddJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO JobSeekerApplyStatusAddDTO);
        Task<JobSeekerApplyStatusReturnDTO> GetJobSeekerApplyStatusById(int JobSeekerApplyStatusId);
        Task<bool> UpdateJobSeekerApplyStatus(JobSeekerApplyStatusUpdateDTO JobSeekerApplyStatusUpdateDTO);
        Task<bool> DeleteJobSeekerApplyStatus(int JobSeekerApplyStatusId);
    }
}

