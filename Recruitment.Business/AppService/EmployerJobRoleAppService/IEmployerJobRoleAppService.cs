
using Recruitment.DTOS.EmployerJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IEmployerJobRoleAppService
    {
        Task<List<EmployerJobRoleReturnDTO>> GetAllEmployerJobRoles();
        Task<bool> AddEmployerJobRole(EmployerJobRoleAddDTO userAddDTO);
        Task<EmployerJobRoleReturnDTO> GetEmployerJobRoleById(int EmployerJobRoleId);
        Task<bool> UpdateEmployerJobRole(EmployerJobRoleUpdateDTO userUpdateDTO);
        Task<bool> DeleteEmployerJobRole(int EmployerJobRoleId);
    }
}




