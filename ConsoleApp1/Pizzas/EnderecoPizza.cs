using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mdelos;

internal class EnderecoPizza: Menu
{
    public void Endereco()
    {
       
        Console.WriteLine("\nInforme seu endereço");
            Console.Write("Rua / Número: ");
            string Rua = Console.ReadLine()!;

            Console.Write("CEP: ");
            string Cep = Console.ReadLine()!;
        

    }


 }




