

using ConsoleApp1.Mdelos;

namespace ConsoleApp1.Menus;


internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '=');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public virtual void Executar(Dictionary<string, Pizza> pizzasRegistradas)
    {
        Console.Clear();
    }


    public virtual void Executar(Dictionary<string, Esfiha> esfihasRegistradas)
    {
        Console.Clear();
    }

    internal void Executar(object esfihasRegistradas)
    {
        throw new NotImplementedException();
    }
}
