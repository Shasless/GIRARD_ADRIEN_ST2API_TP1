using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class ex5
    {
        public static void ex5_1(int n, bool deco)
        {
            n++;
            int m=2 * n - 1;
            for(int j =1; j<=n+1;j++)
            {
                int k = (m - j* 2 + 1)/2;

                for(int i =1; i<=m;i++)
                {
                    if (j == n + 1)
                    {
                        if (i==n-2)
                        {
                            Console.Write("| |");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    else if (i <= k || i >= (m-k)-1)
                    {
                        Console.Write(" ");

                    }
                    else
                    {
                        if ((j-1-i)%3==0 && deco)
                        {
                            randdeco();
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }


                } 
                Console.WriteLine("");


            }
        }
       
    public static void randdeco()
    {
        Random rdn = new Random();
        if (rdn.Next() % 5 == 0)
        {
            Console.Write("o");
        }
        else
        {
            Console.Write("i");

        }
    }

    public async static void cligno(int n)
    {
        while (true)
        {
            ex5_1(n,true);
            await Task.Delay(1000);
            Console.Clear();

        }
    }

    }
    
}