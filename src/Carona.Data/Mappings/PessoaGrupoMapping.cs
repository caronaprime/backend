using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class PessoaGrupoMapping : IEntityTypeConfiguration<PessoaGrupo>
    {
        public void Configure(EntityTypeBuilder<PessoaGrupo> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne(pessoaGrupo => pessoaGrupo.Grupo)
                .WithMany(grupo => grupo.Membros)
                .HasForeignKey(pessoaGrupo => pessoaGrupo.GrupoId);

            builder
                .HasOne(pessoaGrupo => pessoaGrupo.Pessoa)
                .WithMany(pessoa => pessoa.Grupos)
                .HasForeignKey(pessoaGrupo => pessoaGrupo.PessoaId);

        }
    }
}
