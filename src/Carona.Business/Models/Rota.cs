using System.Collections.Generic;

namespace Business.Models
{
    public class Rota : Entity
    {
        public string Nome { get; set; }
        public IEnumerable<Viagem> Viagens { get; set; }
        public Local Origem { get; set; }
        public Local Destino { get; set; }
    }
}