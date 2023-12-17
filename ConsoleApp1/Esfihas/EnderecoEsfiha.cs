using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Menus;

namespace ConsoleApp1.Esfihas;

internal class EnderecoEsfiha : Menu
{

    public void Endereco()
    {
        Console.WriteLine("\nInforme seu endereço");
        Console.Write("Rua / Número: ");
        string Rua = Console.ReadLine()!;

        Console.Write("CEP: ");
        string Cep = Console.ReadLine()!;
        Console.Clear();



    }
   

}

