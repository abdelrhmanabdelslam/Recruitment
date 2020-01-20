using Recruitment.DTOS.CompanySizeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanySizeMapping
    {
        List<CompanySizeReturnDTO> MappingCompanySizeToCompanySizeReturnDTO(List<CompanySize> CompanySizeList);
        CompanySize MappingCompanySizeAddDTOToCompanySize(CompanySizeAddDTO CompanySizeAddDTO);
        CompanySize MappingCompanySizeupdateDTOToCompanySize(CompanySize CompanySize,CompanySizeUpdateDTO CompanySizeUpdateDTO);
        CompanySizeReturnDTO MappingCompanySizeToCompanySizeReturnDTO(CompanySize CompanySize);

    }
}




