using Recruitment.DTOS.JobSeekerRoleDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobSeekerRoleMapping
    {
        List<JobSeekerRoleReturnDTO> MappingJobSeekerRoleToJobSeekerRoleReturnDTO(List<JobSeekerRole> JobSeekerRoleList);
        JobSeekerRole MappingJobSeekerRoleAddDTOToJobSeekerRole(JobSeekerRoleAddDTO JobSeekerRoleAddDTO);
        JobSeekerRole MappingJobSeekerRoleupdateDTOToJobSeekerRole(JobSeekerRole JobSeekerRole,JobSeekerRoleUpdateDTO JobSeekerRoleUpdateDTO);
        JobSeekerRoleReturnDTO MappingJobSeekerRoleToJobSeekerRoleReturnDTO(JobSeekerRole JobSeekerRole);

    }
}




