// See https://aka.ms/new-console-template for more information
using System;

namespace Bomba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bomba";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;

            int num01;
            int num02;

            Console.Write("Podaj liczbę: ");

            num01 = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Podaj kolejną liczbę: ");

            num02 = Convert.ToInt32( Console.ReadLine() );

            int result = num01 * num02;

            Console.WriteLine("Jesteś Gejem");

        
            
            Console.ReadKey();
        }
    }
}