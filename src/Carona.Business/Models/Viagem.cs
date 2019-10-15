﻿using Carona.Business.Enums;
using System;
using System.Collections.Generic;

namespace Carona.Business.Models
{
    public class Viagem : Entity
    {
        public DateTime Hora { get; set; }
        public DiaDaSemana DiaDaSemana { get; set; }
        public Pessoa Motorista { get; set; }
        public IEnumerable<Pessoa> Caroneiros { get; set; }
    }
}