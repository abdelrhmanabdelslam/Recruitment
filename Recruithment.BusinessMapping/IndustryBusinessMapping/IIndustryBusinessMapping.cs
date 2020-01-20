using Recruitment.DTOS.IndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IIndustryBusinessMapping
    {
        Task<List<IndustryReturnDTO>> GetAllIndustrys();
        Task<bool> AddIndustry(GradeAddDTO IndustryAddDTO);
        Task<IndustryReturnDTO> GetIndustryById(int IndustryId);
        Task<bool> UpdateIndustry(GradeUpdateDTO IndustryUpdateDTO);
        Task<bool> DeleteIndustry(int IndustryId);
    }
}


