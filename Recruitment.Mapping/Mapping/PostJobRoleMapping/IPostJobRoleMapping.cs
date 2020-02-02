using Recruitment.DTOS.PostJobRoleDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IPostJobRoleMapping
    {
        List<PostJobRoleReturnDTO> MappingPostJobRoleToPostJobRoleReturnDTO(List<PostJobRole> PostJobRoleList);
        PostJobRole MappingPostJobRoleAddDTOToPostJobRole(PostJobRoleAddDTO PostJobRoleAddDTO);
        PostJobRole MappingPostJobRoleupdateDTOToPostJobRole(PostJobRole PostJobRole,PostJobRoleUpdateDTO PostJobRoleUpdateDTO);
        PostJobRoleReturnDTO MappingPostJobRoleToPostJobRoleReturnDTO(PostJobRole PostJobRole);

    }
}




