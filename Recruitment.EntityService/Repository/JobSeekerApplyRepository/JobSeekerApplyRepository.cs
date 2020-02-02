using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerApplyRepository : BaseRepository<JobSeekerApply>, IJobSeekerApplyRepository
    {
        public JobSeekerApplyRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

