using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class PostRelatedIndustryRepository : BaseRepository<PostRelatedIndustry>, IPostRelatedIndustryRepository
    {
        public PostRelatedIndustryRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

