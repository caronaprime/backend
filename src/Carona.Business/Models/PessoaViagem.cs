using System;

namespace Business.Models
{
    public class PessoaViagem : Entity
    {
        public Guid PessoaId { get; set; }
        public Guid ViagemId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Viagem Viagem { get; set; }
    }
}
