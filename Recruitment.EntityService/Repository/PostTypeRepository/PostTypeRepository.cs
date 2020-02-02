using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class PostTypeRepository : BaseRepository<PostType>, IPostTypeRepository
    {
        public PostTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

