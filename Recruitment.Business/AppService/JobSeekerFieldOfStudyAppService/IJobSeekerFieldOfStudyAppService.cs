
using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerFieldOfStudyAppService
    {
        Task<List<JobSeekerFieldOfStudyReturnDTO>> GetAllJobSeekerFieldOfStudys();
        Task<bool> AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO userAddDTO);
        Task<JobSeekerFieldOfStudyReturnDTO> GetJobSeekerFieldOfStudyById(int JobSeekerFieldOfStudyId);
        Task<bool> UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerFieldOfStudy(int JobSeekerFieldOfStudyId);
    }
}




