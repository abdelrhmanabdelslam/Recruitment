
using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerTypeOfJobAppService
    {
        Task<List<JobSeekerTypeOfJobReturnDTO>> GetAllJobSeekerTypeOfJobs();
        Task<bool> AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO userAddDTO);
        Task<JobSeekerTypeOfJobReturnDTO> GetJobSeekerTypeOfJobById(int JobSeekerTypeOfJobId);
        Task<bool> UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerTypeOfJob(int JobSeekerTypeOfJobId);
    }
}




