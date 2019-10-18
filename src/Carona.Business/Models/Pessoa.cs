using System.Collections.Generic;

namespace Business.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public IEnumerable<PessoaAmigo> Amigos { get; set; }
        public IEnumerable<PessoaGrupo> Grupos { get; set; }
        public IEnumerable<PessoaViagem> Viagens { get; set; }
    }
}