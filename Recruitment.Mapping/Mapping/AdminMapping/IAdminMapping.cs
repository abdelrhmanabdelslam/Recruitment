using IPMATS.Common.Auth;
using Recruitment.DTOS.AdminDTOS;
using Recruitment.DTOS.EmployerDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IAdminMapping
    {
        List<AdminReturnDTO> MappingAdminToAdminReturnDTO(List<Admin> AdminList);
        Admin MappingAdminAddDTOToAdmin(AdminAddDTO AdminAddDTO, UserPasswordDTO userPasswordDTO);
        Admin MappingAdminupdateDTOToAdmin(Admin Admin,AdminUpdateDTO AdminUpdateDTO);
        AdminReturnDTO MappingAdminToAdminReturnDTO(Admin Admin);
        UserDTO MappingAdminToUserDTO(Admin Admin);

    }
}




