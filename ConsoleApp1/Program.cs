using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;
using Console = Colorful.Console;
using System.Drawing;
using Pizzaria.Esfihas;






Pizza chocolate = new Pizza("Chocolate");
Pizza calabreza = new Pizza("calabreza");
Pizza Portuguesa = new Pizza("portuguesa");
Pizza Caipira = new Pizza("caipira");
Pizza Atum = new Pizza("baiana");
Pizza Baiana = new Pizza("bacon");
Pizza Bacon = new Pizza("calabresa com bacon");
chocolate.AdicionarNota(new Avaliacao(10));

Pizza pacote1 = new Pizza("pacote 1");
Pizza pacote2 = new Pizza("pacote 2");
Pizza pacote3 = new Pizza("pacote 3");
Pizza pacote4 = new Pizza("pacote 4");


Dictionary<int, Menu> opcoes = new();

opcoes.Add(1, new RegistrarPizza());
opcoes.Add(2, new RegistrarEsfihas());
opcoes.Add(3, new AvaliarPizza());
opcoes.Add(4, new AvaliarUmaEsfiha());


Dictionary<string, Pizza> pizzasRegistradas = new();

pizzasRegistradas.Add(chocolate.Nome, chocolate);
pizzasRegistradas.Add(calabreza.Nome, calabreza);
pizzasRegistradas.Add(Portuguesa.Nome, Portuguesa);
pizzasRegistradas.Add(Caipira.Nome, Caipira);
pizzasRegistradas.Add(Atum.Nome, Atum);
pizzasRegistradas.Add(Baiana.Nome, Baiana);
pizzasRegistradas.Add(Bacon.Nome, Bacon);


// Esfihas notas

pizzasRegistradas.Add(pacote1.Nome, pacote1);
pizzasRegistradas.Add(pacote2.Nome, pacote2);
pizzasRegistradas.Add(pacote3.Nome, pacote3);
pizzasRegistradas.Add(pacote4.Nome, pacote4);




void LogoTipo()


{
    string logo = (@"
██╗░░░░░███████╗██████╗░██╗░░░░░░█████╗░███╗░░██╗
██║░░░░░██╔════╝██╔══██╗██║░░░░░██╔══██╗████╗░██║
██║░░░░░█████╗░░██████╦╝██║░░░░░██║░░██║██╔██╗██║
██║░░░░░██╔══╝░░██╔══██╗██║░░░░░██║░░██║██║╚████║
███████╗███████╗██████╦╝███████╗╚█████╔╝██║░╚███║
╚══════╝╚══════╝╚═════╝░╚══════╝░╚════╝░╚═╝░░╚══╝
");
 Console.WriteLine(logo, Color.Tan);
    
}

void ExibirMenu()

{
    LogoTipo();
    Console.WriteLine("Bem vindo(a) a Pizzaria Leblon !");
    Console.WriteLine("\n");
    Say("1", "Registrar uma pizza");
    Say("2", "Registrar combo de esfiha");
    Say("3", "Avaliar uma pizza");
    Say("4", "Avaliar um combo de Esfiha");


    Console.Write("\nEscolha a sua opção: ");

    string  opcaoEscolhinha = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhinha);


    if (opcoes.ContainsKey(opcaoNumerica))
    {
        Menu menu = opcoes[opcaoNumerica];
        menu.Executar(pizzasRegistradas);   
        if (opcaoNumerica > 0) ExibirMenu();

    }


}
  void Say(string prefix, string message)
{
    Console.Write("[");
    Console.Write(prefix, Color.Tan);
    Console.WriteLine("] " + message);
}



ExibirMenu();






