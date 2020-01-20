
using Recruitment.DTOS.IndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IIndustryAppService
    {
        Task<List<IndustryReturnDTO>> GetAllIndustrys();
        Task<bool> AddIndustry(GradeAddDTO userAddDTO);
        Task<IndustryReturnDTO> GetIndustryById(int IndustryId);
        Task<bool> UpdateIndustry(GradeUpdateDTO userUpdateDTO);
        Task<bool> DeleteIndustry(int IndustryId);
    }
}


