using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_E_Comerce
{
    public class Relatorio
    {
        private readonly Catalogo _catalogo;

        public Relatorio(Catalogo catalogo)
        {
            this._catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in _catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco.ToString("C"),10}\r\n");
            }
        }
    }
}
