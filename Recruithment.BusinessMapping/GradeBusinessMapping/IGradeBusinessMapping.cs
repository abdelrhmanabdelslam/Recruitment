using Recruitment.DTOS.GradeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IGradeBusinessMapping
    {
        Task<List<GradeReturnDTO>> GetAllGrades();
        Task<bool> AddGrade(GradeAddDTO GradeAddDTO);
        Task<GradeReturnDTO> GetGradeById(int GradeId);
        Task<bool> UpdateGrade(GradeUpdateDTO GradeUpdateDTO);
        Task<bool> DeleteGrade(int GradeId);
    }
}

