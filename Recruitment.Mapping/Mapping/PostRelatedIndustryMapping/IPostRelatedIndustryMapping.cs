using Recruitment.DTOS.PostRelatedIndustryDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IPostRelatedIndustryMapping
    {
        List<PostRelatedIndustryReturnDTO> MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(List<PostRelatedIndustry> PostRelatedIndustryList);
        PostRelatedIndustry MappingPostRelatedIndustryAddDTOToPostRelatedIndustry(PostRelatedIndustryAddDTO PostRelatedIndustryAddDTO);
        PostRelatedIndustry MappingPostRelatedIndustryupdateDTOToPostRelatedIndustry(PostRelatedIndustry PostRelatedIndustry,PostRelatedIndustryUpdateDTO PostRelatedIndustryUpdateDTO);
        PostRelatedIndustryReturnDTO MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(PostRelatedIndustry PostRelatedIndustry);

    }
}




