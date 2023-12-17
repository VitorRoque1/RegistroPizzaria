using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Mdelos;

namespace ConsoleApp1.Mdelos;

internal class MenuEsfiha: Menu
{
    
    public void Menu3()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Cardapio / Registrar");

        Console.WriteLine("\nPacote de Esfihas                                                                   Valor");
        Console.WriteLine("Pacote 1: 10 Carne, 10 Queijo,5 Calabresa, 5 Mussarela                              R$64,00");
        Console.WriteLine("Pacote 2: 10 Carne, 5 Calabresa, 5 Mussarela, 5 Qjo Branco, 5 Fragon c/ Catupiry    R$65,00");
        Console.WriteLine("Pacote 3: 10 Carne, 10 Queijo, 10 FGO c/ Catupiry                                   R$63,00");
        Console.WriteLine("Pacote 4: 20 Carne, 10 Queijo Branco                                                R$60,00");

        //Console.WriteLine("\nEsfihas Tradicionais                P              M                G");
        //Console.WriteLine("Carne                               R35,00         R45,00          R50,00");
        //Console.WriteLine("Queijo                              R35,00         R45,00          R50,00");
        //Console.WriteLine("Frango                              R35,00         R45,00          R50,00");
        //Console.WriteLine("Calabresa                           R35,00         R45,00          R50,00");
        //Console.WriteLine("\nEsfihas Especiais");
        //Console.WriteLine("Tomate                              R35,00         R45,00          R50,00");
        //Console.WriteLine("Frango c/Milho                      R35,00         R45,00          R50,00");
        //Console.WriteLine("Frango c/ Queijo                    R35,00         R45,00          R50,00");
        //Console.WriteLine("Frango c/ Catupiry                  R35,00         R45,00          R50,00");
        //Console.WriteLine("\nEsfihas Doces");
        //Console.WriteLine("Frango c/ Catupiry                    R35,00         R45,00          R50,00");

        Console.Write("--------------------------------------------------------------------------------");
        Console.Write("\nInforme o com que deseja: ");
        string Nome = Console.ReadLine()!;
        Console.Write("--------------------------------------------------------------------------------");
       

    }


}
