using Recruitment.DTOS.CompanyUserTypeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyUserTypeMapping
    {
        List<CompanyUserTypeReturnDTO> MappingCompanyUserTypeToCompanyUserTypeReturnDTO(List<CompanyUserType> CompanyUserTypeList);
        CompanyUserType MappingCompanyUserTypeAddDTOToCompanyUserType(CompanyUserTypeAddDTO CompanyUserTypeAddDTO);
        CompanyUserType MappingCompanyUserTypeupdateDTOToCompanyUserType(CompanyUserType CompanyUserType,CompanyUserTypeUpdateDTO CompanyUserTypeUpdateDTO);
        CompanyUserTypeReturnDTO MappingCompanyUserTypeToCompanyUserTypeReturnDTO(CompanyUserType CompanyUserType);

    }
}




