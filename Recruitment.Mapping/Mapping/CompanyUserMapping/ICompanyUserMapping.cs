using Recruitment.DTOS.CompanyUserDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyUserMapping
    {
        List<CompanyUserReturnDTO> MappingCompanyUserToCompanyUserReturnDTO(List<CompanyUser> CompanyUserList);
        CompanyUser MappingCompanyUserAddDTOToCompanyUser(CompanyUserAddDTO CompanyUserAddDTO);
        CompanyUser MappingCompanyUserupdateDTOToCompanyUser(CompanyUser CompanyUser,CompanyUserUpdateDTO CompanyUserUpdateDTO);
        CompanyUserReturnDTO MappingCompanyUserToCompanyUserReturnDTO(CompanyUser CompanyUser);

    }
}




