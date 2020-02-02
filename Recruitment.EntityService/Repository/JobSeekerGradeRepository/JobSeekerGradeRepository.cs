using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerGradeRepository : BaseRepository<JobSeekerGrade>, IJobSeekerGradeRepository
    {
        public JobSeekerGradeRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

