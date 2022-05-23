using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ex1 ex1;
            ex2 ex2;
            ex3 ex3;
            ex4 ex4;
            ex5 ex5;
            
            Console.WriteLine("TP1 Adrien GIRARD");
            Console.WriteLine("Tout les exercices s'execute dans l'ordre");
            Console.WriteLine("Exercice 1");
            Console.WriteLine("toute les tables");

            ex1.ex1_1();
            Console.WriteLine("table resultat impaire");

            ex1.ex1_2();
            Console.WriteLine("table au choix");

            ex1.ex1_3(AskUserForParameter());
            Console.WriteLine("Exercice 2");
            Console.WriteLine("nombre premier");

            ex2.ex2_1(AskUserForParameter());
            Console.WriteLine("fibonacci");

            ex2.ex2_2(AskUserForParameter());
            Console.WriteLine("factoriel");

            ex2.ex2_3(AskUserForParameter());
            Console.WriteLine("Exercice 3");

            ex3.ex3_1();
            Console.WriteLine("Exercice 4");

            ex4.ex4_1(AskUserForParametertwo(),AskUserForParameter());
            Console.WriteLine("Exercice 5");
            
            ex5.ex5_1(AskUserForParameter(),true);
            

        }

        

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        private static int AskUserForParametertwo()
        {
            Console.WriteLine("Please write a two number with a space between :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        

        
    }
}


