using Recruitment.DTOS.EmployerDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IEmployerBusinessMapping
    {
        Task<List<EmployerReturnDTO>> GetAllEmployers();
        Task<bool> AddEmployer(EmployerAddDTO EmployerAddDTO);
        Task<EmployerReturnDTO> GetEmployerById(int EmployerId);
        Task<bool> UpdateEmployer(EmployerUpdateDTO EmployerUpdateDTO);
        Task<bool> DeleteEmployer(int EmployerId);
    }
}

