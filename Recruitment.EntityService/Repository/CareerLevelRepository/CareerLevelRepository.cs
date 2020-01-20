using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CareerLevelRepository : BaseRepository<CareerLevel>, ICareerLevelRepository
    {
        public CareerLevelRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

