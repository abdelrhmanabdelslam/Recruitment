using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class PostIndustryRepository : BaseRepository<PostIndustry>, IPostIndustryRepository
    {
        public PostIndustryRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

