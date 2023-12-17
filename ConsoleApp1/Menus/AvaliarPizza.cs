using ConsoleApp1.Mdelos;
using OpenAI_API;


 namespace ConsoleApp1.Menus;

    internal class AvaliarPizza : Menu

{
    public override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {
        base.Executar(pizzasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Avalie uma pizza");
        Console.Write("Digite o nome da pizza que deseja avaliar: ");
        string nomeDaPizza = Console.ReadLine()!;

        if (pizzasRegistradas.ContainsKey(nomeDaPizza))
        {

            Pizza pizaa = pizzasRegistradas[nomeDaPizza];
            Console.Write($"Qual a nota que a pizza {nomeDaPizza} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            pizaa.AdicionarNota(nota);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a pizza {nomeDaPizza}");
            Thread.Sleep(4000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA pizza {nomeDaPizza} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }

}