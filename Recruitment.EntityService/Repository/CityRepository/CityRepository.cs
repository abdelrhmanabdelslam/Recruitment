using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

