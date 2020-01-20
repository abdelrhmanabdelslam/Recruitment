
using Recruitment.DTOS.CompanyImageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyImageAppService
    {
        Task<List<CompanyImageReturnDTO>> GetAllCompanyImages();
        Task<bool> AddCompanyImage(CompanyImageAddDTO userAddDTO);
        Task<CompanyImageReturnDTO> GetCompanyImageById(int CompanyImageId);
        Task<bool> UpdateCompanyImage(CompanyImageUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyImage(int CompanyImageId);
    }
}




