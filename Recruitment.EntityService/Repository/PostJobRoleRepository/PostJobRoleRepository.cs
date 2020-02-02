using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class PostJobRoleRepository : BaseRepository<PostJobRole>, IPostJobRoleRepository
    {
        public PostJobRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

