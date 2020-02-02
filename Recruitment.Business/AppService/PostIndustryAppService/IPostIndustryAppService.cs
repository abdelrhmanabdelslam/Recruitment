
using Recruitment.DTOS.PostIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IPostIndustryAppService
    {
        Task<List<PostIndustryReturnDTO>> GetAllPostIndustrys();
        Task<bool> AddPostIndustry(PostIndustryAddDTO userAddDTO);
        Task<PostIndustryReturnDTO> GetPostIndustryById(int PostIndustryId);
        Task<bool> UpdatePostIndustry(PostIndustryUpdateDTO userUpdateDTO);
        Task<bool> DeletePostIndustry(int PostIndustryId);
    }
}




