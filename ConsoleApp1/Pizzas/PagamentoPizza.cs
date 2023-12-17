using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using Console = Colorful.Console;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mdelos;

internal class PagamentoPizza : Menu
{
    
    public void PagamentaPizza()
    {
     

        ExibirTituloDaOpcao("Pagamento");
        Console.WriteLine("--------------------------------------------------------------------------------");
        Say("1", "Cartão debito / credito");
        Say("2", "Dinheiro");
        Say("3", "Ticket Refeição");
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.Write("\nEscolha sua opcão: ");
        string OpcaoEscolhida = Console.ReadLine()!;

        
        int OpcaoEscolha = int.Parse(OpcaoEscolhida);


        switch (OpcaoEscolha)
        {

            case 1:

                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"\n OK, sua pizza foi registrada com sucesso");
                Thread.Sleep(4000);
                Console.Clear();




                break;

            case 2:

                Console.Write("\nPrecisa de troco?: ");


                string Troco = Console.ReadLine()!;



                if (Troco == "sim")
                {

                    Console.Write("\nInforme o valor para levar o troco corretamente: ");
                    int Troco2 = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"\n OK, sua pizza foi registrada com sucesso");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"\n OK, sua pizza foi registrada com sucesso");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                break;

            case 3:
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"\n OK, seu pedido foi registrado com sucesso");
                Thread.Sleep(4000);
                Console.Clear();
                break;
        }
    }

    void Say(string prefix, string message)
    {
        Console.Write("[");
        Console.Write(prefix, Color.Tan);
        Console.WriteLine("] " + message);
    }

}
