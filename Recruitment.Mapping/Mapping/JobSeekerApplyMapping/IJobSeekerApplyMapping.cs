using Recruitment.DTOS.JobSeekerApplyDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerApplyMapping
    {
        List<JobSeekerApplyReturnDTO> MappingJobSeekerApplyToJobSeekerApplyReturnDTO(List<JobSeekerApply> JobSeekerApplyList);
        JobSeekerApply MappingJobSeekerApplyAddDTOToJobSeekerApply(JobSeekerApplyAddDTO JobSeekerApplyAddDTO);
        JobSeekerApply MappingJobSeekerApplyupdateDTOToJobSeekerApply(JobSeekerApply JobSeekerApply,JobSeekerApplyUpdateDTO JobSeekerApplyUpdateDTO);
        JobSeekerApplyReturnDTO MappingJobSeekerApplyToJobSeekerApplyReturnDTO(JobSeekerApply JobSeekerApply);

    }
}




