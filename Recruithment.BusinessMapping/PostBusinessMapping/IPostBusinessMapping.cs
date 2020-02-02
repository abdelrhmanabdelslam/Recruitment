using Recruitment.DTOS.PostDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IPostBusinessMapping
    {
        Task<List<PostReturnDTO>> GetAllPosts();
        Task<bool> AddPost(PostAddDTO PostAddDTO);
        Task<PostReturnDTO> GetPostById(int PostId);
        Task<bool> UpdatePost(PostUpdateDTO PostUpdateDTO);
        Task<bool> DeletePost(int PostId);
    }
}

