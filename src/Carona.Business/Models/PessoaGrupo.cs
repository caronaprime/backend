using System;

namespace Business.Models
{
    public class PessoaGrupo : Entity
    {
        public Guid PessoaId { get; set; }
        public Guid GrupoId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Grupo Grupo { get; set; }
    }
}
