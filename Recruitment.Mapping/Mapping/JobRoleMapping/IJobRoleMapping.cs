using Recruitment.DTOS.JobRoleDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IJobRoleMapping
    {
        List<JobRoleReturnDTO> MappingJobRoleToJobRoleReturnDTO(List<JobRole> JobRoleList);
        JobRole MappingJobRoleAddDTOToJobRole(JobRoleAddDTO JobRoleAddDTO);
        JobRole MappingJobRoleupdateDTOToJobRole(JobRole JobRole,JobRoleUpdateDTO JobRoleUpdateDTO);
        JobRoleReturnDTO MappingJobRoleToJobRoleReturnDTO(JobRole JobRole);

    }
}




