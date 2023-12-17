
using ConsoleApp1.Mdelos;


namespace ConsoleApp1.Menus;

internal class ExibirDetalhes : Menu
{
    public  override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {
        base.Executar(pizzasRegistradas);

       

        ExibirTituloDaOpcao("Exibigr Detalhes da pizza");
        Console.WriteLine("Digite nome da pizza para conhecer melhor");
        string nomeDapizza = Console.ReadLine()!;
        if (pizzasRegistradas.ContainsKey(nomeDapizza))
        {
            Pizza pizza = pizzasRegistradas[nomeDapizza];
            Console.WriteLine(pizza.Resumo);
       

        }
    }

}
