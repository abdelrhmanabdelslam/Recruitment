using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class TypeOfJobRepository : BaseRepository<TypeOfJob>, ITypeOfJobRepository
    {
        public TypeOfJobRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

