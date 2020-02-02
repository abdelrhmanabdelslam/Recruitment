
using Recruitment.DTOS.PostTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IPostTypeAppService
    {
        Task<List<PostTypeReturnDTO>> GetAllPostTypes();
        Task<bool> AddPostType(PostTypeAddDTO userAddDTO);
        Task<PostTypeReturnDTO> GetPostTypeById(int PostTypeId);
        Task<bool> UpdatePostType(PostTypeUpdateDTO userUpdateDTO);
        Task<bool> DeletePostType(int PostTypeId);
    }
}




