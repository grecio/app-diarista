using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data
{
    class DiaristaDbContextFactory : IDesignTimeDbContextFactory<DiaristaDbContext>
    {
    
        public DiaristaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DiaristaDbContext>();

            optionsBuilder.UseSqlServer("Server=144.217.49.13,1433;Database=DiaristaDb;User Id=sa;Password=buga@tec_buga1;");

            return new DiaristaDbContext(optionsBuilder.Options);
        }
    }
}
