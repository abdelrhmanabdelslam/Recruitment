using Recruitment.DTOS.PostIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IPostIndustryBusinessMapping
    {
        Task<List<PostIndustryReturnDTO>> GetAllPostIndustrys();
        Task<bool> AddPostIndustry(PostIndustryAddDTO PostIndustryAddDTO);
        Task<PostIndustryReturnDTO> GetPostIndustryById(int PostIndustryId);
        Task<bool> UpdatePostIndustry(PostIndustryUpdateDTO PostIndustryUpdateDTO);
        Task<bool> DeletePostIndustry(int PostIndustryId);
    }
}

