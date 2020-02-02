using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerRoleRepository : BaseRepository<JobSeekerRole>, IJobSeekerRoleRepository
    {
        public JobSeekerRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

