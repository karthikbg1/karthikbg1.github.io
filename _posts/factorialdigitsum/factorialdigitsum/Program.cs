using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factorialdigitsum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            BigInteger p=100,m=0,sum=0;
           m= factor(p);
           while (m / 10 != 0)
           {
               m = m / 10;
               sum += m % 10;

           }
           DateTime end = DateTime.Now;
           TimeSpan time = end - start;
            Console.WriteLine("{0},{1}",sum,time.Milliseconds);
            Console.ReadLine();
        }
       static BigInteger factor(BigInteger n)
        {
            BigInteger result;
            if (n == 0) return 1;
            else
            {
                result = n * factor(n - 1);
            }
            return result;
        }
                

            }

        }
    
