using Recruitment.DTOS.IndustryDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IIndustryMapping
    {
        List<IndustryReturnDTO> MappingIndustryToIndustryReturnDTO(List<Industry> IndustryList);
        Industry MappingIndustryAddDTOToIndustry(GradeAddDTO IndustryAddDTO);
        Industry MappingIndustryupdateDTOToIndustry(Industry Industry,GradeUpdateDTO IndustryUpdateDTO);
        IndustryReturnDTO MappingIndustryToIndustryReturnDTO(Industry Industry);

    }
}


