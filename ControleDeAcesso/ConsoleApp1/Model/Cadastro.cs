using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Cadastro 
    {
        public Cadastro(List<Usuario> usuarios, List<Ambiente> ambientes)
        {
            usuarios = new List<Usuario> { };
            ambientes= new List<Ambiente> { };  
        }

        public List<Usuario> Usuarios { get; set; }
        public List<Ambiente> Ambientes { get; set; }
        public void CriarUsuario(Usuario usuario)
        {
         Usuarios.Add(usuario);
        }

        public void Remover(Usuario usuario)
        {
            Usuarios.Remove(usuario);   
        }
    }
}
