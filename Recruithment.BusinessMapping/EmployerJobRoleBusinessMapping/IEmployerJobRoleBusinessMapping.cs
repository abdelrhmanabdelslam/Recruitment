using Recruitment.DTOS.EmployerJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IEmployerJobRoleBusinessMapping
    {
        Task<List<EmployerJobRoleReturnDTO>> GetAllEmployerJobRoles();
        Task<bool> AddEmployerJobRole(EmployerJobRoleAddDTO EmployerJobRoleAddDTO);
        Task<EmployerJobRoleReturnDTO> GetEmployerJobRoleById(int EmployerJobRoleId);
        Task<bool> UpdateEmployerJobRole(EmployerJobRoleUpdateDTO EmployerJobRoleUpdateDTO);
        Task<bool> DeleteEmployerJobRole(int EmployerJobRoleId);
    }
}

