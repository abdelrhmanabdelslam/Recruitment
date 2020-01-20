using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobRoleRepository : BaseRepository<JobRole>, IJobRoleRepository
    {
        public JobRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

