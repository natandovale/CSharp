using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_E_Comerce
{
    public class Catalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("9834", "Livro1", 12.23m));
            livros.Add(new Livro("9835", "Livro2", 12.99m));
            livros.Add(new Livro("9836", "Livro3", 15.99m));
            return livros;
        }
    }
}
