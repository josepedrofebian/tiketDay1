using System;

namespace JosePedro_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiple3or5 m = new Multiple3or5();
            Fibonacci f = new Fibonacci();
            SummationOfPrimes sop = new SummationOfPrimes();

            Console.WriteLine("sum of the modulus 3 or 5 below 1000");
            Console.WriteLine(m.multiple(1000));

            Console.WriteLine("sum fibonacci of the even-valued below 4 millions");
            Console.WriteLine(f.sumFibonacci(100));

            Console.WriteLine("sum of all the prime below 2 million");
            Console.WriteLine(sop.sumOfPrimes(10));
            
        }
    }
}
