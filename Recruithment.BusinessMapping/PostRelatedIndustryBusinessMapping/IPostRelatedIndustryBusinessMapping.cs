using Recruitment.DTOS.PostRelatedIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IPostRelatedIndustryBusinessMapping
    {
        Task<List<PostRelatedIndustryReturnDTO>> GetAllPostRelatedIndustrys();
        Task<bool> AddPostRelatedIndustry(PostRelatedIndustryAddDTO PostRelatedIndustryAddDTO);
        Task<PostRelatedIndustryReturnDTO> GetPostRelatedIndustryById(int PostRelatedIndustryId);
        Task<bool> UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO PostRelatedIndustryUpdateDTO);
        Task<bool> DeletePostRelatedIndustry(int PostRelatedIndustryId);
    }
}

