using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerApplyStatusMapping
    {
        List<JobSeekerApplyStatusReturnDTO> MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(List<JobSeekerApplyStatus> JobSeekerApplyStatusList);
        JobSeekerApplyStatus MappingJobSeekerApplyStatusAddDTOToJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO JobSeekerApplyStatusAddDTO);
        JobSeekerApplyStatus MappingJobSeekerApplyStatusupdateDTOToJobSeekerApplyStatus(JobSeekerApplyStatus JobSeekerApplyStatus,JobSeekerApplyStatusUpdateDTO JobSeekerApplyStatusUpdateDTO);
        JobSeekerApplyStatusReturnDTO MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(JobSeekerApplyStatus JobSeekerApplyStatus);

    }
}




