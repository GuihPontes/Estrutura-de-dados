using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Ambiente> Ambientes { get; set; }

    }
}
