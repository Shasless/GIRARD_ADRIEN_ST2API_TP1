using System;

namespace ConsoleApplication1
{
    public class ex4
    {
        public static void ex4_1(int n, int m)
        
        
        {
            Console.WriteLine("n = {0}, m={1}",n,m);
            n--;
            m--;
            if (n == 1 && m == 1)
            {
                Console.WriteLine("0");
            }
            
            for(int i =0; i<=n;i++)
                
            {
                Console.WriteLine("");
                for(int j =0; j<=m;j++)
                {
                    if (i == 0 && j == 0 || j == 0 && i == n || i == n && j == m || j == m && i == 0)
                    {
                        Console.Write("0");
                    }
                    else if(i==0 || i ==n )
                    {
                        Console.Write("_");
                    }
                    else if(j==0 || j ==m )
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        if ( j%3==i%3)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.WriteLine("");

        }
    }
}