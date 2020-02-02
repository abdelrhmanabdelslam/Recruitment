
using Recruitment.DTOS.JobSeekerDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerAppService
    {
        Task<List<JobSeekerReturnDTO>> GetAllJobSeekers();
        Task<bool> AddJobSeeker(JobSeekerAddDTO userAddDTO);
        Task<JobSeekerReturnDTO> GetJobSeekerById(int JobSeekerId);
        Task<bool> UpdateJobSeeker(JobSeekerUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeeker(int JobSeekerId);
    }
}




