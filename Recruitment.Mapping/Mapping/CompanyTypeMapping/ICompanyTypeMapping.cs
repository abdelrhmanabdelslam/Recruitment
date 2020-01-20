using Recruitment.DTOS.CompanyTypeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyTypeMapping
    {
        List<CompanyTypeReturnDTO> MappingCompanyTypeToCompanyTypeReturnDTO(List<CompanyType> CompanyTypeList);
        CompanyType MappingCompanyTypeAddDTOToCompanyType(CompanyTypeAddDTO CompanyTypeAddDTO);
        CompanyType MappingCompanyTypeupdateDTOToCompanyType(CompanyType CompanyType,CompanyTypeUpdateDTO CompanyTypeUpdateDTO);
        CompanyTypeReturnDTO MappingCompanyTypeToCompanyTypeReturnDTO(CompanyType CompanyType);

    }
}




