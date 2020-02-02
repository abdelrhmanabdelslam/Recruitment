using Recruitment.DTOS.PostIndustryDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IPostIndustryMapping
    {
        List<PostIndustryReturnDTO> MappingPostIndustryToPostIndustryReturnDTO(List<PostIndustry> PostIndustryList);
        PostIndustry MappingPostIndustryAddDTOToPostIndustry(PostIndustryAddDTO PostIndustryAddDTO);
        PostIndustry MappingPostIndustryupdateDTOToPostIndustry(PostIndustry PostIndustry,PostIndustryUpdateDTO PostIndustryUpdateDTO);
        PostIndustryReturnDTO MappingPostIndustryToPostIndustryReturnDTO(PostIndustry PostIndustry);

    }
}




