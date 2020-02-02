using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IJobSeekerProfessionalInformationBusinessMapping
    {
        Task<List<JobSeekerProfessionalInformationReturnDTO>> GetAllJobSeekerProfessionalInformations();
        Task<bool> AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO JobSeekerProfessionalInformationAddDTO);
        Task<JobSeekerProfessionalInformationReturnDTO> GetJobSeekerProfessionalInformationById(int JobSeekerProfessionalInformationId);
        Task<bool> UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO JobSeekerProfessionalInformationUpdateDTO);
        Task<bool> DeleteJobSeekerProfessionalInformation(int JobSeekerProfessionalInformationId);
    }
}

