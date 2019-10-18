using System;

namespace Business.Models
{
    public class PessoaAmigo : Entity
    {
        public Guid PessoaOrigemId { get; set; }
        public Guid PessoaDestinoId { get; set; }
        public Pessoa Origem { get; set; }
        public Pessoa Destino { get; set; }
    }
}
