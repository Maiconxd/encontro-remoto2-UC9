// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//instanciar um objeto da classe PessoaFisica
using Cadastro_Pessoas_UC9.Classes;

PessoaFisica novaPf = new PessoaFisica();
//atribuimos valores para os atributos do objeto
novaPf.Nome = "Mayck";
novaPf.Rendimento = 50000.54f;
//imprimimos no console os valores desses atributos
Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.Rendimento);

//instanciar um objeto da classe PessoaJuridica
PessoaJuridica novaPj = new PessoaJuridica();

novaPj.RazaoSocial = "Senai informática";

Console.WriteLine("Razão social: "+ novaPj.RazaoSocial); //concatenação

Console.WriteLine($"Razão social: {novaPj.RazaoSocial}"); //interpolação