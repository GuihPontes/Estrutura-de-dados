using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato(string email, string nome, Data dataNasciento, List<Telefone> telefones)
        {
            Email = email;
            Nome = nome;
            DataNasciento = dataNasciento;
            Telefones = telefones;
        }

        public string Email { get; private set; }
        public string Nome { get; private set; }
        public Data DataNasciento { get;private set; }
        public List<Telefone> Telefones { get; private set; }

       
    }
}
