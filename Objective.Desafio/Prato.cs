using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Desafio
{
    public class Prato
    {
        public string Nome { get; set; }

        public Tipo Tipo { get; set; }

        public string? Exclusividade { get; set; }
        public bool Acerto { get; set; }
    }
}
