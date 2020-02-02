using Recruitment.DTOS.JobSeekerDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerBusinessMapping
    {
        Task<List<JobSeekerReturnDTO>> GetAllJobSeekers();
        Task<bool> AddJobSeeker(JobSeekerAddDTO JobSeekerAddDTO);
        Task<JobSeekerReturnDTO> GetJobSeekerById(int JobSeekerId);
        Task<bool> UpdateJobSeeker(JobSeekerUpdateDTO JobSeekerUpdateDTO);
        Task<bool> DeleteJobSeeker(int JobSeekerId);
    }
}

