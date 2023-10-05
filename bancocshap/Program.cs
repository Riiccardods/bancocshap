using bancocshap.Models;

Console.WriteLine("****************************************");
Console.WriteLine("************ Banco Csharp **************");
Console.WriteLine("****************************************");
Console.WriteLine();

var endereco = new Endereco
{
    Cep = "2890030",
    Rua = "rua xyz",
    Numero = 53



};

var titular01 = new Titular("jose","12345","219997788");
titular01.Endereco = endereco;



var conta01 = new ContaBancaria(titular01, 100.0);

Console.WriteLine(titular01.Telefone);