using System.Collections.Generic;

namespace Business.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public IEnumerable<Pessoa> Amigos { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
        public IEnumerable<Viagem> Viagens { get; set; }
    }
}