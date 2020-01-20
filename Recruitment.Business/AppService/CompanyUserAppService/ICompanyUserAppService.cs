
using Recruitment.DTOS.CompanyUserDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyUserAppService
    {
        Task<List<CompanyUserReturnDTO>> GetAllCompanyUsers();
        Task<bool> AddCompanyUser(CompanyUserAddDTO userAddDTO);
        Task<CompanyUserReturnDTO> GetCompanyUserById(int CompanyUserId);
        Task<bool> UpdateCompanyUser(CompanyUserUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyUser(int CompanyUserId);
    }
}




