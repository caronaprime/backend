using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .HasMany(pessoa => pessoa.Amigos)
                .WithOne(pessoaAmigo => pessoaAmigo.Destino)
                .HasForeignKey(pessoaAmigo => pessoaAmigo.PessoaDestinoId);

            builder
                .HasMany(pessoa => pessoa.Amigos)
                .WithOne(pessoaAmigo => pessoaAmigo.Origem)
                .HasForeignKey(pessoAmigo => pessoAmigo.PessoaOrigemId);

            builder
                .HasMany(pessoa => pessoa.Grupos)
                .WithOne(pessoaGrupo => pessoaGrupo.Pessoa)
                .HasForeignKey(pessoaGrupo => pessoaGrupo.PessoaId);

            builder
                .HasMany(pessoa => pessoa.Viagens)
                .WithOne(pessoaViagem => pessoaViagem.Pessoa)
                .HasForeignKey(pessoaVigem => pessoaVigem.PessoaId);

            builder.ToTable("Pessoas", "CaronaPrime");
        }
    }
}
