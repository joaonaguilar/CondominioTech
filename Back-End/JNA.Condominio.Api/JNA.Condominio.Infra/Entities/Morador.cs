using JNA.Condominio.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Infra.Entities
{
    public class MoradorConfiguration : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {
            builder.HasKey(e => e.CPF);
            builder.Property(e => e.CPF).HasMaxLength(11).IsRequired();
            builder.Property(e => e.Nome).HasMaxLength(100).IsRequired();
            builder.Property(e => e.DataNascimento).IsRequired();
            builder.Property(e => e.Sexo).IsRequired();
            builder.Property(e => e.EstadoCivil).IsRequired();
        }
    }
}
