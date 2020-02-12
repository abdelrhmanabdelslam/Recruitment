
using Recruitment.DTOS.AdminDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IAdminAppService
    {
        Task<List<AdminReturnDTO>> GetAllAdmins();
        Task<bool> AddAdmin(AdminAddDTO userAddDTO);
        Task<AdminReturnDTO> GetAdminById(int AdminId);
        Task<bool> UpdateAdmin(AdminUpdateDTO userUpdateDTO);
        Task<bool> DeleteAdmin(int AdminId);
    }
}




