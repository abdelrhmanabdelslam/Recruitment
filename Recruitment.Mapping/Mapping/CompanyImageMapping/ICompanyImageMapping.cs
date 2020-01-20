using Recruitment.DTOS.CompanyImageDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyImageMapping
    {
        List<CompanyImageReturnDTO> MappingCompanyImageToCompanyImageReturnDTO(List<CompanyImage> CompanyImageList);
        CompanyImage MappingCompanyImageAddDTOToCompanyImage(CompanyImageAddDTO CompanyImageAddDTO);
        CompanyImage MappingCompanyImageupdateDTOToCompanyImage(CompanyImage CompanyImage,CompanyImageUpdateDTO CompanyImageUpdateDTO);
        CompanyImageReturnDTO MappingCompanyImageToCompanyImageReturnDTO(CompanyImage CompanyImage);

    }
}




