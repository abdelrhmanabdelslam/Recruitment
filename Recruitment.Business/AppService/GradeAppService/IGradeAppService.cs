
using Recruitment.DTOS.GradeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IGradeAppService
    {
        Task<List<GradeReturnDTO>> GetAllGrades();
        Task<bool> AddGrade(GradeAddDTO userAddDTO);
        Task<GradeReturnDTO> GetGradeById(int GradeId);
        Task<bool> UpdateGrade(GradeUpdateDTO userUpdateDTO);
        Task<bool> DeleteGrade(int GradeId);
    }
}




