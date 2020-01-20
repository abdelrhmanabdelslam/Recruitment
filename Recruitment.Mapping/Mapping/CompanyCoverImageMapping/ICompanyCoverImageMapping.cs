using Recruitment.DTOS.CompanyCoverImageDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyCoverImageMapping
    {
        List<CompanyCoverImageReturnDTO> MappingCompanyCoverImageToCompanyCoverImageReturnDTO(List<CompanyCoverImage> CompanyCoverImageList);
        CompanyCoverImage MappingCompanyCoverImageAddDTOToCompanyCoverImage(CompanyCoverImageAddDTO CompanyCoverImageAddDTO);
        CompanyCoverImage MappingCompanyCoverImageupdateDTOToCompanyCoverImage(CompanyCoverImage CompanyCoverImage,CompanyCoverImageUpdateDTO CompanyCoverImageUpdateDTO);
        CompanyCoverImageReturnDTO MappingCompanyCoverImageToCompanyCoverImageReturnDTO(CompanyCoverImage CompanyCoverImage);

    }
}




