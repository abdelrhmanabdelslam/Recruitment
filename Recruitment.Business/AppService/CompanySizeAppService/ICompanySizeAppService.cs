
using Recruitment.DTOS.CompanySizeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanySizeAppService
    {
        Task<List<CompanySizeReturnDTO>> GetAllCompanySizes();
        Task<bool> AddCompanySize(CompanySizeAddDTO userAddDTO);
        Task<CompanySizeReturnDTO> GetCompanySizeById(int CompanySizeId);
        Task<bool> UpdateCompanySize(CompanySizeUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanySize(int CompanySizeId);
    }
}




