using System;
using System.Diagnostics;
using System.Net.Http;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "01001000";
            string url = "https://viacep.com.br/ws/" + cep + "/json";
            string result = new HttpClient().GetStringAsync(url).Result;
            Debug.WriteLine(result);
        }
    }
}
