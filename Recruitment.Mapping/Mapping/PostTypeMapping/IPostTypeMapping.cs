using Recruitment.DTOS.PostTypeDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IPostTypeMapping
    {
        List<PostTypeReturnDTO> MappingPostTypeToPostTypeReturnDTO(List<PostType> PostTypeList);
        PostType MappingPostTypeAddDTOToPostType(PostTypeAddDTO PostTypeAddDTO);
        PostType MappingPostTypeupdateDTOToPostType(PostType PostType,PostTypeUpdateDTO PostTypeUpdateDTO);
        PostTypeReturnDTO MappingPostTypeToPostTypeReturnDTO(PostType PostType);

    }
}




