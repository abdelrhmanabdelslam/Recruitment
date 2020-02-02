
using Recruitment.DTOS.PostJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IPostJobRoleAppService
    {
        Task<List<PostJobRoleReturnDTO>> GetAllPostJobRoles();
        Task<bool> AddPostJobRole(PostJobRoleAddDTO userAddDTO);
        Task<PostJobRoleReturnDTO> GetPostJobRoleById(int PostJobRoleId);
        Task<bool> UpdatePostJobRole(PostJobRoleUpdateDTO userUpdateDTO);
        Task<bool> DeletePostJobRole(int PostJobRoleId);
    }
}




