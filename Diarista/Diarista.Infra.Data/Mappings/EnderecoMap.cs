using Diarista.Core.Models.DataModels;
using Diarista.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Infra.Data.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<EnderecoModel>
    {
        public EnderecoMap()
        {
        }

        public override void Map(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id);
            builder.Property(p => p.Logradouro);
            builder.Property(p => p.Numero);
            builder.Property(p => p.Complemento);
            builder.Property(p => p.Bairro);
            //Falta imlementar os atributo derivado Cidade & Estado

            builder.HasOne<CidadeModel>(p => p.Cidade)
                .WithOne(p => p.Endereco)
                .HasForeignKey<CidadeModel>(p => p.CidadeEnderecoId);


            builder.HasOne<EstadoModel>(p => p.Estado)
               .WithOne(p => p.Endereco)
               .HasForeignKey<EstadoModel>(p => p.EstadoEnderecoId);

        }
    }
}
