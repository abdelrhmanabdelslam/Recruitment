using Recruitment.DTOS.JobSeekerDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerMapping
    {
        List<JobSeekerReturnDTO> MappingJobSeekerToJobSeekerReturnDTO(List<JobSeeker> JobSeekerList);
        JobSeeker MappingJobSeekerAddDTOToJobSeeker(JobSeekerAddDTO JobSeekerAddDTO);
        JobSeeker MappingJobSeekerupdateDTOToJobSeeker(JobSeeker JobSeeker,JobSeekerUpdateDTO JobSeekerUpdateDTO);
        JobSeekerReturnDTO MappingJobSeekerToJobSeekerReturnDTO(JobSeeker JobSeeker);

    }
}




