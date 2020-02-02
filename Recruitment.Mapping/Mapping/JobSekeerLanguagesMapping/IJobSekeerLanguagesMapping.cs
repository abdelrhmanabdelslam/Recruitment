using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSekeerLanguagesMapping
    {
        List<JobSekeerLanguagesReturnDTO> MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(List<JobSekeerLanguages> JobSekeerLanguagesList);
        JobSekeerLanguages MappingJobSekeerLanguagesAddDTOToJobSekeerLanguages(JobSekeerLanguagesAddDTO JobSekeerLanguagesAddDTO);
        JobSekeerLanguages MappingJobSekeerLanguagesupdateDTOToJobSekeerLanguages(JobSekeerLanguages JobSekeerLanguages,JobSekeerLanguagesUpdateDTO JobSekeerLanguagesUpdateDTO);
        JobSekeerLanguagesReturnDTO MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(JobSekeerLanguages JobSekeerLanguages);

    }
}




