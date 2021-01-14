using Diarista.Core.Models.DataModels;
using Diarista.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data.Mappings
{
    public class ApartamentoMap : EntityTypeConfiguration<ApartamentoModel>
    {
        public ApartamentoMap()
        {
        }

        public override void Map(EntityTypeBuilder<ApartamentoModel> builder)
        {
            builder.ToTable("Apartamento");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id);
            builder.Property(p => p.Nome);
            builder.Property(p => p.QtdQuartos);
            builder.Property(p => p.QtdBanheiros);
            builder.Property(p => p.QtdCozinhas);
            builder.Property(p => p.QtdSalas);
            //Falta imlementar o atributo derivado Endereço

            builder.HasOne(p => p.Endereco)
                .WithOne(p => p.Apartamento)
                .HasForeignKey<EnderecoModel>(p => p.ApartamentoEnderecoId);           

        }
    }
}
