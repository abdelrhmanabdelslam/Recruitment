
using Recruitment.DTOS.PostDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IPostAppService
    {
        Task<List<PostReturnDTO>> GetAllPosts();
        Task<bool> AddPost(PostAddDTO userAddDTO);
        Task<PostReturnDTO> GetPostById(int PostId);
        Task<bool> UpdatePost(PostUpdateDTO userUpdateDTO);
        Task<bool> DeletePost(int PostId);
    }
}




