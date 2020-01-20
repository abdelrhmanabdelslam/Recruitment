using Recruitment.DTOS.CompanyUserDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyUserBusinessMapping
    {
        Task<List<CompanyUserReturnDTO>> GetAllCompanyUsers();
        Task<bool> AddCompanyUser(CompanyUserAddDTO CompanyUserAddDTO);
        Task<CompanyUserReturnDTO> GetCompanyUserById(int CompanyUserId);
        Task<bool> UpdateCompanyUser(CompanyUserUpdateDTO CompanyUserUpdateDTO);
        Task<bool> DeleteCompanyUser(int CompanyUserId);
    }
}

