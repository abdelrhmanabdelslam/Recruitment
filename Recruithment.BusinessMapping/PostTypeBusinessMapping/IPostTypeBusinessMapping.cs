using Recruitment.DTOS.PostTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IPostTypeBusinessMapping
    {
        Task<List<PostTypeReturnDTO>> GetAllPostTypes();
        Task<bool> AddPostType(PostTypeAddDTO PostTypeAddDTO);
        Task<PostTypeReturnDTO> GetPostTypeById(int PostTypeId);
        Task<bool> UpdatePostType(PostTypeUpdateDTO PostTypeUpdateDTO);
        Task<bool> DeletePostType(int PostTypeId);
    }
}

