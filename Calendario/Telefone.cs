using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Telefone
    {
        public Telefone(string tipo, string numero, bool asPrincipal)
        {
            Tipo = tipo;
            Numero = numero;
            AsPrincipal = asPrincipal;
        }

        public string Tipo { get; private set; }
        public string Numero { get; private set; }
        public bool AsPrincipal { get; private set; }

    }
}
