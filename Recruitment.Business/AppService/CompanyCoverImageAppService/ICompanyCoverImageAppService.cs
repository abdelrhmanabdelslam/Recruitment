
using Recruitment.DTOS.CompanyCoverImageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyCoverImageAppService
    {
        Task<List<CompanyCoverImageReturnDTO>> GetAllCompanyCoverImages();
        Task<bool> AddCompanyCoverImage(CompanyCoverImageAddDTO userAddDTO);
        Task<CompanyCoverImageReturnDTO> GetCompanyCoverImageById(int CompanyCoverImageId);
        Task<bool> UpdateCompanyCoverImage(CompanyCoverImageUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyCoverImage(int CompanyCoverImageId);
    }
}




