namespace String.Url
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("url");

            var indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();
            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }    

            return resultado.Remove(indiceEComercial);
        }
    }
}
