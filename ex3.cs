using System;

namespace ConsoleApplication1
{
    public class ex3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) -4);
        }
        
        public static void ex3_1()
        {
            for(int i =-3; i<=3;i++)

            {

                try
                {
                    Console.WriteLine(10/PowerFunction(i));

                }
                catch
                {
                    Console.WriteLine("skoiur");
                }


            }
            
        }
    }
}