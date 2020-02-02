using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSekeerLanguagesBusinessMapping
    {
        Task<List<JobSekeerLanguagesReturnDTO>> GetAllJobSekeerLanguagess();
        Task<bool> AddJobSekeerLanguages(JobSekeerLanguagesAddDTO JobSekeerLanguagesAddDTO);
        Task<JobSekeerLanguagesReturnDTO> GetJobSekeerLanguagesById(int JobSekeerLanguagesId);
        Task<bool> UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO JobSekeerLanguagesUpdateDTO);
        Task<bool> DeleteJobSekeerLanguages(int JobSekeerLanguagesId);
    }
}

