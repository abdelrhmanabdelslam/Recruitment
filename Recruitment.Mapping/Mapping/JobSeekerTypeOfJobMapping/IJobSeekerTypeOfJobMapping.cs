using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerTypeOfJobMapping
    {
        List<JobSeekerTypeOfJobReturnDTO> MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(List<JobSeekerTypeOfJob> JobSeekerTypeOfJobList);
        JobSeekerTypeOfJob MappingJobSeekerTypeOfJobAddDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO JobSeekerTypeOfJobAddDTO);
        JobSeekerTypeOfJob MappingJobSeekerTypeOfJobupdateDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJob JobSeekerTypeOfJob,JobSeekerTypeOfJobUpdateDTO JobSeekerTypeOfJobUpdateDTO);
        JobSeekerTypeOfJobReturnDTO MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(JobSeekerTypeOfJob JobSeekerTypeOfJob);

    }
}




