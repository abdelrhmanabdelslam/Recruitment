using Recruitment.DTOS.CompanySizeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanySizeBusinessMapping
    {
        Task<List<CompanySizeReturnDTO>> GetAllCompanySizes();
        Task<bool> AddCompanySize(CompanySizeAddDTO CompanySizeAddDTO);
        Task<CompanySizeReturnDTO> GetCompanySizeById(int CompanySizeId);
        Task<bool> UpdateCompanySize(CompanySizeUpdateDTO CompanySizeUpdateDTO);
        Task<bool> DeleteCompanySize(int CompanySizeId);
    }
}

