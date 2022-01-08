using System;
using System.Collections.Generic;
using System.Linq;

namespace Vs 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção: 1- Cidades, 2- Paises, 3- Estados");
            Console.WriteLine("Digite a opção: ");
            ConsoleKeyInfo input = Console.ReadKey();
            int result = int.Parse(input.KeyChar.ToString());
            Console.WriteLine();
            Console.WriteLine("Você escolheu: ", result);
            
            if (result == 1){
                Console.WriteLine("ESCOLHEU OPÇÃO UM!");
            }
        }
    }
}