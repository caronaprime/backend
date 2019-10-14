using System.Collections.Generic;

namespace Carona.Business.Models
{
    public class Grupo : Entity
    {
        public string Nome { get; set; }
        public Administrador Administrador { get; set; }
        public IEnumerable<Pessoa> Membros { get; set; }
        public IEnumerable<Rota> Rotas { get; set; }
    }
}