using Diarista.Core.Models.DataModels;
using Diarista.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data.Mappings
{
    public class EstadoMap : EntityTypeConfiguration<EstadoModel>
    {
        public EstadoMap()
        {
        }

        public override void Map(EntityTypeBuilder<EstadoModel> builder)
        {
            builder.ToTable("Estado");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id);
            builder.Property(p => p.Nome);
            builder.Property(p => p.Sigla);

        }
    }
}
