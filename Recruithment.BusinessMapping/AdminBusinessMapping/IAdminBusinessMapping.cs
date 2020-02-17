using IPMATS.Common.Auth;
using Recruitment.DTOS.AdminDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IAdminBusinessMapping
    {
        Task<List<AdminReturnDTO>> GetAllAdmins();
        Task<bool> AddAdmin(AdminAddDTO AdminAddDTO);
        Task<AdminReturnDTO> GetAdminById(int AdminId);
        Task<bool> UpdateAdmin(AdminUpdateDTO AdminUpdateDTO);
        Task<bool> DeleteAdmin(int AdminId);
        Task<UserDTO> AdminLoginAsync(UserLoginDTO adminLoginDTO);
    }
}

