using Recruitment.DTOS.CompanyCoverImageDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyCoverImageBusinessMapping
    {
        Task<List<CompanyCoverImageReturnDTO>> GetAllCompanyCoverImages();
        Task<bool> AddCompanyCoverImage(CompanyCoverImageAddDTO CompanyCoverImageAddDTO);
        Task<CompanyCoverImageReturnDTO> GetCompanyCoverImageById(int CompanyCoverImageId);
        Task<bool> UpdateCompanyCoverImage(CompanyCoverImageUpdateDTO CompanyCoverImageUpdateDTO);
        Task<bool> DeleteCompanyCoverImage(int CompanyCoverImageId);
    }
}

