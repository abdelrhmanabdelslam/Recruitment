using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerFieldOfStudyBusinessMapping
    {
        Task<List<JobSeekerFieldOfStudyReturnDTO>> GetAllJobSeekerFieldOfStudys();
        Task<bool> AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO JobSeekerFieldOfStudyAddDTO);
        Task<JobSeekerFieldOfStudyReturnDTO> GetJobSeekerFieldOfStudyById(int JobSeekerFieldOfStudyId);
        Task<bool> UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO JobSeekerFieldOfStudyUpdateDTO);
        Task<bool> DeleteJobSeekerFieldOfStudy(int JobSeekerFieldOfStudyId);
    }
}

