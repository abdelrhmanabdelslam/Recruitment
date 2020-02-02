using Recruitment.DTOS.PostJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IPostJobRoleBusinessMapping
    {
        Task<List<PostJobRoleReturnDTO>> GetAllPostJobRoles();
        Task<bool> AddPostJobRole(PostJobRoleAddDTO PostJobRoleAddDTO);
        Task<PostJobRoleReturnDTO> GetPostJobRoleById(int PostJobRoleId);
        Task<bool> UpdatePostJobRole(PostJobRoleUpdateDTO PostJobRoleUpdateDTO);
        Task<bool> DeletePostJobRole(int PostJobRoleId);
    }
}

