using ConsoleApp1.Mdelos;
using ConsoleApp1.Menus;

namespace ConsoleApp1.Mdelos
{
    internal class Esfiha : Menu
    {

        private List<Avaliacao> notas = new List<Avaliacao>();

        public string Resumo { get; set; }
        public Esfiha(string nome)
        {
            Nome = nome;

        }



        public string Nome { get; }


        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }




    }

}

