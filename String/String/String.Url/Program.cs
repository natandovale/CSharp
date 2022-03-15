using System.Text.RegularExpressions;
using String.Url;

var url = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar";
var extrator = new ExtratorValorDeArgumentosURL(url);

var valor1 = extrator.GetValor("moedaOrigem");
Console.WriteLine(valor1);

var valor2 = extrator.GetValor("moedaDestino");
Console.WriteLine(valor2);

/// <summary>
/// ///////////////////////////////////
/// </summary>
/// 


//string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
//string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
//string padrao = "[0-9]{4}[-][0-9]{4}";
//string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
string padrao = "[0-9]{4,5}-?[0-9]{4}";
string texto = "Meu número é: 2342-3453";

Match match = Regex.Match(texto, padrao);
Console.WriteLine(match.Value);

Console.ReadLine();