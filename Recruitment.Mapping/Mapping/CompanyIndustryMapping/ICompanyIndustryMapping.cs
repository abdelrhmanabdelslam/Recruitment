using Recruitment.DTOS.CompanyIndustryDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyIndustryMapping
    {
        List<CompanyIndustryReturnDTO> MappingCompanyIndustryToCompanyIndustryReturnDTO(List<CompanyIndustry> CompanyIndustryList);
        CompanyIndustry MappingCompanyIndustryAddDTOToCompanyIndustry(CompanyIndustryAddDTO CompanyIndustryAddDTO);
        CompanyIndustry MappingCompanyIndustryupdateDTOToCompanyIndustry(CompanyIndustry CompanyIndustry,CompanyIndustryUpdateDTO CompanyIndustryUpdateDTO);
        CompanyIndustryReturnDTO MappingCompanyIndustryToCompanyIndustryReturnDTO(CompanyIndustry CompanyIndustry);

    }
}




