using Recruitment.DTOS.AdminDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IAdminMapping
    {
        List<AdminReturnDTO> MappingAdminToAdminReturnDTO(List<Admin> AdminList);
        Admin MappingAdminAddDTOToAdmin(AdminAddDTO AdminAddDTO);
        Admin MappingAdminupdateDTOToAdmin(Admin Admin,AdminUpdateDTO AdminUpdateDTO);
        AdminReturnDTO MappingAdminToAdminReturnDTO(Admin Admin);

    }
}




