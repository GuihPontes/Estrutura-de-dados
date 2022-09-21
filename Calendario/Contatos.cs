using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contatos
    {
       public readonly List<Contato> Agenda;

        public Contatos(List<Contato> agenda)
        {
            Agenda = agenda;
        }

        public bool Adicionar(Contato c)
        {
          Agenda.Add(c); 
           return true;
        }

        public IEnumerable<Contato> Pesquisar(string c)
        {
            var pesquisa = Agenda.Where(x => x.Nome.ToLower().Contains(c.ToLower()));
            return pesquisa;
        }

        public bool Remover(Contato c )
        {
            Agenda.Remove(c);
            return true;
        }

        public bool Alterar(Contato c)
        {
            
        }

        

    }
}
