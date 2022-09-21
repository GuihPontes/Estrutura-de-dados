using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Data
    {
        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }

        public override string ToString()
        {
            return $"{Dia}/{Mes}/{Ano}";
        }
    }
}
