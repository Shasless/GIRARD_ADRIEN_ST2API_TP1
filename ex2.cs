using System;

namespace ConsoleApplication1
{
    public class ex2
    {
        public static void ex2_1(int n)
        {
            for(int i =0; i<n;i++)
            {
                if (isprime(i))
                {
                    Console.WriteLine("{0}",i);

                }

                
            }
        }

        private static bool isprime(int n)
        {
 
            if(n <= 1) 
            {
                return false;
            }
            else
            {
                for (int i = 2; i<= Math.Sqrt(n); i++) 
                {
                    if ((n % i) == 0)
                    {
                        return false;
                    }
                }
 
                return true;
            }
        }
        
        public static void ex2_2(int n)
        {
            long a =0;
            long b =1;
            long c;
            for(int i =0; i<n;i++)
            {
                
                Console.WriteLine("{0}",a+b);
                c = a;
                a = b;
                b = b + c;

                    
            }
        }
        public static int ex2_3 (int n) {
            if (n == 0)
            {
                return(1);
            }
            else
            {
                return(n*ex2_3(n-1));
            }
        }
    }
}