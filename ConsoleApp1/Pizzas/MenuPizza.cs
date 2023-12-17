using ConsoleApp1.Menus;


namespace ConsoleApp1.Mdelos;
internal class MenuPizza : Menu
{

    public override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {

    }
    public void Menu2()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Cardapio / Registrar");

        Console.WriteLine("\nPizzas                           P              M                G");
        Console.WriteLine("Portuguesa                      R$35,00         R$45,00          R$50,00");
        Console.WriteLine("Calabreza                       R$42,00         R$52,00          R$55,00");
        Console.WriteLine("Caipira                         R$42,00         R$48,00          R$53,00");
        Console.WriteLine("Atum                            R$47,00         R$52,00          R$57,00");
        Console.WriteLine("Baiana                          R$43,00         R$48,00          R$53,00");
        Console.WriteLine("Bacon                           R$41,00         R$46,00          R$51,00");
        Console.WriteLine("Calabresa com Bacon             R$45,00         R$50,00          R$55,00");
        Console.WriteLine("Carne-seca                      R$54,00         R$59,00          R$64,00");
        Console.WriteLine("Fran-Bacon                      R$50,00         R$55,00          R$60,00");
        Console.WriteLine("Carne-seca                      R$54,00         R$59,00          R$64,00");
        Console.WriteLine("À moda da casa                  R$34,00         R$39,00          R$42,00");

        Console.Write("--------------------------------------------------------------------------------");
        Console.Write("\nDigite o nome da pizza que deseja: ");
        string Nome = Console.ReadLine()!;
        Console.Write("--------------------------------------------------------------------------------");
        Console.Write("\nPequena, Media ou Grande: ");
        string TamanhoPizza = Console.ReadLine()!;
        Console.Write("--------------------------------------------------------------------------------");

     


    }


}
