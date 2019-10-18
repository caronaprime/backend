using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class PessoaViagemMapping : IEntityTypeConfiguration<PessoaViagem>
    {
        public void Configure(EntityTypeBuilder<PessoaViagem> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne(pessoaViagem => pessoaViagem.Pessoa)
                .WithMany(pessoa => pessoa.Viagens)
                .HasForeignKey(pessoaViagem => pessoaViagem.PessoaId);

            builder
                .HasOne(pessoaViagem => pessoaViagem.Viagem)
                .WithMany(viagem => viagem.Caroneiros)
                .HasForeignKey(pessoaViagem => pessoaViagem.ViagemId);

        }
    }
}
