using System;

namespace ConsoleApplication1
{
    public class ex1
    {
        public static void ex1_1()
        {
            for(int i =0; i<11;i++)
            {
                Console.WriteLine("Table of {0}",i);
                for(int j =0; j<11;j++)
                {
                    
                    Console.WriteLine("{0}*{1}={2}",i,j,i*j);

                }
            }
        }
        public static void ex1_2()
        {
            for(int i =0; i<11;i++)
            {
                Console.WriteLine("Table of {0}",i);
                for(int j =0; j<11;j++)
                {
                    if (i * j % 2 == 1)
                    {
                        Console.WriteLine("{0}*{1}={2}",i,j,i*j);
                    }

                }
            }
        }
        public static void ex1_3(int n)
        {
            for(int i =0; i<11;i++)
            {
                Console.WriteLine("{0}*{1}={2}",n,i,i*n);

                
            }
        }
    }
}