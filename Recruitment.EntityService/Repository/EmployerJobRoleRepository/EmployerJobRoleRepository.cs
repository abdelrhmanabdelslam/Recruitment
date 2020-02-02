using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class EmployerJobRoleRepository : BaseRepository<EmployerJobRole>, IEmployerJobRoleRepository
    {
        public EmployerJobRoleRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

