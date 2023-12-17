using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;

namespace Pizzaria.Esfihas;

internal class AvaliarUmaEsfiha: Menu
{
    public override void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {
        base.Executar(pizzasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Avalie um combo de esfiha");
        Console.Write("Digite o número do pacote de esfiha: ");
        string combo = Console.ReadLine()!;

        if (pizzasRegistradas.ContainsKey(combo))
        {

            Pizza pizaa = pizzasRegistradas[combo];
            Console.Write($"Qual a nota que o combo de esfiha {combo} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            pizaa.AdicionarNota(nota);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o {combo} de esfihas");
            Thread.Sleep(4000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA pizza {combo} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}