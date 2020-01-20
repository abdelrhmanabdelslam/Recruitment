using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Entity.Models
{
    public partial class RecruitmentContext : DbContext
    {
        #region Properties
        private string ConnectionString { get; }
        #endregion
        #region Constructor
        public RecruitmentContext(string connectionString, int commandTimeout)
        {
            this.ConnectionString = connectionString;
            this.Database.SetCommandTimeout(commandTimeout);
        }
        #endregion
        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
        #endregion
    }
}
