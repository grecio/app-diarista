using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data
{
    public class DiaristaDbContext : DbContext
    {
        public DiaristaDbContext()
        {
            //
        }

        public DiaristaDbContext(DbContextOptions<DiaristaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
