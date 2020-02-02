
using Recruitment.DTOS.JobSeekerGradeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerGradeAppService
    {
        Task<List<JobSeekerGradeReturnDTO>> GetAllJobSeekerGrades();
        Task<bool> AddJobSeekerGrade(JobSeekerGradeAddDTO userAddDTO);
        Task<JobSeekerGradeReturnDTO> GetJobSeekerGradeById(int JobSeekerGradeId);
        Task<bool> UpdateJobSeekerGrade(JobSeekerGradeUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerGrade(int JobSeekerGradeId);
    }
}




