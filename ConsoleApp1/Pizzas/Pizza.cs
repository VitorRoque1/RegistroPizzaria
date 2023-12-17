using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;

namespace ConsoleApp1.Mdelos;

internal class Pizza : Menu
{

    private List<Avaliacao> notas = new List<Avaliacao>();



    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);

        }
    }

    public Pizza(string nome)
    {
        Nome = nome;

    }



    public string Nome { get; }
    public string Resumo { get; }


    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);


    }

}

