using Recruitment.DTOS.PostDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IPostMapping
    {
        List<PostReturnDTO> MappingPostToPostReturnDTO(List<Post> PostList);
        Post MappingPostAddDTOToPost(PostAddDTO PostAddDTO);
        Post MappingPostupdateDTOToPost(Post Post,PostUpdateDTO PostUpdateDTO);
        PostReturnDTO MappingPostToPostReturnDTO(Post Post);

    }
}




