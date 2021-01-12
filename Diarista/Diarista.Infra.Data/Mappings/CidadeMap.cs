using Diarista.Core.Models.DataModels;
using Diarista.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data.Mappings
{
    public class CidadeMap : EntityTypeConfiguration<CidadeModel>
    {
        public CidadeMap()
        {
        }

        public override void Map(EntityTypeBuilder<CidadeModel> builder)
        {
            builder.ToTable("Cidade");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id);
            builder.Property(p => p.Nome);
            //Falta imlementar o atributo derivado Estado
        }
    }
}
