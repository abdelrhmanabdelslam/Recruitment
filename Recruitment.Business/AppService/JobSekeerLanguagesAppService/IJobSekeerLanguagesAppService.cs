
using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSekeerLanguagesAppService
    {
        Task<List<JobSekeerLanguagesReturnDTO>> GetAllJobSekeerLanguagess();
        Task<bool> AddJobSekeerLanguages(JobSekeerLanguagesAddDTO userAddDTO);
        Task<JobSekeerLanguagesReturnDTO> GetJobSekeerLanguagesById(int JobSekeerLanguagesId);
        Task<bool> UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSekeerLanguages(int JobSekeerLanguagesId);
    }
}




