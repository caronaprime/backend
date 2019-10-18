using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class PessoaAmigoMapping : IEntityTypeConfiguration<PessoaAmigo>
    {
        public void Configure(EntityTypeBuilder<PessoaAmigo> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne(pessoaAmigo => pessoaAmigo.Origem)
                .WithMany(pessoa => pessoa.Amigos)
                .HasForeignKey(pessoaAmigo => pessoaAmigo.PessoaOrigemId);

            builder
                .HasOne(pessoaAmigo => pessoaAmigo.Destino)
                .WithMany(pessoa => pessoa.Amigos)
                .HasForeignKey(pessoaAmigo => pessoaAmigo.PessoaDestinoId);
        }
    }
}
