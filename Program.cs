using System;
using System.Collections.Generic;
using System.Linq;

namespace Vs 
{
    public class Program
    {
        public static void Main(string[] args)
        {
                int result = 0;
            
            do
            {
                Console.WriteLine("Escolha uma opção: 1- Cidades, 2- Paises, 3- Continentes, 0- fechar");
                Console.WriteLine("Digite a opção: ");
                ConsoleKeyInfo input = Console.ReadKey();
                result = int.Parse(input.KeyChar.ToString());
            


            
                if (result == 1)
                {
                    menu1();                   
                }
                else if (result == 2)
                {
                    menu2();
                }
                else if (result == 3)
                {
                    menu3();
                }

            } while (result != 0);



            static void menu1(){
                    Console.WriteLine();
                    Console.WriteLine("ESCOLHEU OPÇÃO UM - CIDADES!");
                    Console.WriteLine();
                    Console.WriteLine("Aqui estão algumas cidades do mundo.");
                    Console.WriteLine("________");
                    Console.WriteLine();
                    Console.WriteLine("Londres");
                    Console.WriteLine("Nova York");
                    Console.WriteLine("São Paulo");
                    Console.WriteLine("São Petersburgo");
                    Console.WriteLine("Tokyo");
                    Console.WriteLine("________");
            }

            static void menu2(){
                    Console.WriteLine();
                    Console.WriteLine("ESCOLHEU OPÇÃO DOIS - PAISES!");
                    Console.WriteLine();
                    Console.WriteLine("Aqui estão alguns paises do mundo.");
                    Console.WriteLine("________");
                    Console.WriteLine();
                    Console.WriteLine("Estados Unidos");
                    Console.WriteLine("Rússia");
                    Console.WriteLine("Peru");
                    Console.WriteLine("Holanda");
                    Console.WriteLine("Brasil");
                    Console.WriteLine("________");

            }

            static void menu3(){
                    Console.WriteLine();
                    Console.WriteLine("ESCOLHEU OPÇÃO TRÊS - CONTINENTES!");
                    Console.WriteLine();
                    Console.WriteLine("Aqui estão alguns continentes do mundo.");
                    Console.WriteLine("________");
                    Console.WriteLine();
                    Console.WriteLine("Ásia");
                    Console.WriteLine("África");
                    Console.WriteLine("Oceania");
                    Console.WriteLine("America");
                    Console.WriteLine("Europa");
                    Console.WriteLine("________");
           }



        }
    }
}