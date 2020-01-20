using Recruitment.DTOS.CompanyImageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyImageBusinessMapping
    {
        Task<List<CompanyImageReturnDTO>> GetAllCompanyImages();
        Task<bool> AddCompanyImage(CompanyImageAddDTO CompanyImageAddDTO);
        Task<CompanyImageReturnDTO> GetCompanyImageById(int CompanyImageId);
        Task<bool> UpdateCompanyImage(CompanyImageUpdateDTO CompanyImageUpdateDTO);
        Task<bool> DeleteCompanyImage(int CompanyImageId);
    }
}

