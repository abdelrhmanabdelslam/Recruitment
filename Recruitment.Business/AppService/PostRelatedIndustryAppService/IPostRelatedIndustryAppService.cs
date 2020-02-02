
using Recruitment.DTOS.PostRelatedIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IPostRelatedIndustryAppService
    {
        Task<List<PostRelatedIndustryReturnDTO>> GetAllPostRelatedIndustrys();
        Task<bool> AddPostRelatedIndustry(PostRelatedIndustryAddDTO userAddDTO);
        Task<PostRelatedIndustryReturnDTO> GetPostRelatedIndustryById(int PostRelatedIndustryId);
        Task<bool> UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO userUpdateDTO);
        Task<bool> DeletePostRelatedIndustry(int PostRelatedIndustryId);
    }
}




