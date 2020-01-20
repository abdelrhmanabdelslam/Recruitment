using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class EmployerRepository : BaseRepository<Employer>, IEmployerRepository
    {
        public EmployerRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

