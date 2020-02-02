using Recruitment.DTOS.EmployerJobRoleDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IEmployerJobRoleMapping
    {
        List<EmployerJobRoleReturnDTO> MappingEmployerJobRoleToEmployerJobRoleReturnDTO(List<EmployerJobRole> EmployerJobRoleList);
        EmployerJobRole MappingEmployerJobRoleAddDTOToEmployerJobRole(EmployerJobRoleAddDTO EmployerJobRoleAddDTO);
        EmployerJobRole MappingEmployerJobRoleupdateDTOToEmployerJobRole(EmployerJobRole EmployerJobRole,EmployerJobRoleUpdateDTO EmployerJobRoleUpdateDTO);
        EmployerJobRoleReturnDTO MappingEmployerJobRoleToEmployerJobRoleReturnDTO(EmployerJobRole EmployerJobRole);

    }
}




