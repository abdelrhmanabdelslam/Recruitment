using Recruitment.DTOS.CompanyInformationDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyInformationMapping
    {
        List<CompanyInformationReturnDTO> MappingCompanyInformationToCompanyInformationReturnDTO(List<CompanyInformation> CompanyInformationList);
        CompanyInformation MappingCompanyInformationAddDTOToCompanyInformation(CompanyInformationAddDTO CompanyInformationAddDTO);
        CompanyInformation MappingCompanyInformationupdateDTOToCompanyInformation(CompanyInformation CompanyInformation,CompanyInformationUpdateDTO CompanyInformationUpdateDTO);
        CompanyInformationReturnDTO MappingCompanyInformationToCompanyInformationReturnDTO(CompanyInformation CompanyInformation);

    }
}




