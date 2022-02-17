var url = "pagina?argumentos";
var indiceInterrogacao = url.IndexOf('?');
var argumentos = url.Substring(indiceInterrogacao+1);
Console.WriteLine(argumentos);
Console.WriteLine(indiceInterrogacao);