using Recruitment.DTOS.JobSeekerGradeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerGradeBusinessMapping
    {
        Task<List<JobSeekerGradeReturnDTO>> GetAllJobSeekerGrades();
        Task<bool> AddJobSeekerGrade(JobSeekerGradeAddDTO JobSeekerGradeAddDTO);
        Task<JobSeekerGradeReturnDTO> GetJobSeekerGradeById(int JobSeekerGradeId);
        Task<bool> UpdateJobSeekerGrade(JobSeekerGradeUpdateDTO JobSeekerGradeUpdateDTO);
        Task<bool> DeleteJobSeekerGrade(int JobSeekerGradeId);
    }
}

