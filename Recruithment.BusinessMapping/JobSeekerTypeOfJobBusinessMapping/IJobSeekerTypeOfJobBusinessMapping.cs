using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerTypeOfJobBusinessMapping
    {
        Task<List<JobSeekerTypeOfJobReturnDTO>> GetAllJobSeekerTypeOfJobs();
        Task<bool> AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO JobSeekerTypeOfJobAddDTO);
        Task<JobSeekerTypeOfJobReturnDTO> GetJobSeekerTypeOfJobById(int JobSeekerTypeOfJobId);
        Task<bool> UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO JobSeekerTypeOfJobUpdateDTO);
        Task<bool> DeleteJobSeekerTypeOfJob(int JobSeekerTypeOfJobId);
    }
}

