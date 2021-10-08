using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVC_E_Comerce
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}