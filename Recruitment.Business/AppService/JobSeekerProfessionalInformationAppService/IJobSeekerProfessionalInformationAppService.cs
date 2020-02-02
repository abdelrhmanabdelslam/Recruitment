
using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IJobSeekerProfessionalInformationAppService
    {
        Task<List<JobSeekerProfessionalInformationReturnDTO>> GetAllJobSeekerProfessionalInformations();
        Task<bool> AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO userAddDTO);
        Task<JobSeekerProfessionalInformationReturnDTO> GetJobSeekerProfessionalInformationById(int JobSeekerProfessionalInformationId);
        Task<bool> UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO userUpdateDTO);
        Task<bool> DeleteJobSeekerProfessionalInformation(int JobSeekerProfessionalInformationId);
    }
}




