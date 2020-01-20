
using Recruitment.DTOS.EmployerDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IEmployerAppService
    {
        Task<List<EmployerReturnDTO>> GetAllEmployers();
        Task<bool> AddEmployer(EmployerAddDTO userAddDTO);
        Task<EmployerReturnDTO> GetEmployerById(int EmployerId);
        Task<bool> UpdateEmployer(EmployerUpdateDTO userUpdateDTO);
        Task<bool> DeleteEmployer(int EmployerId);
    }
}




