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
            CountingSundays cs = new CountingSundays();
            PowerDigitSum pds = new PowerDigitSum();

            Console.WriteLine("sum of the modulus 3 or 5 below 1000");
            Console.WriteLine(m.multiple(1000));

            Console.WriteLine("sum fibonacci of the even-valued below 4 millions");
            Console.WriteLine(f.sumFibonacci(100));

            Console.WriteLine("sum of all the prime below 2 million");
            Console.WriteLine(sop.sumOfPrimes(2000000));

            Console.WriteLine("sum of sundays fell on the first of the month during the twentieth century");
            Console.WriteLine(cs.countSundays());

            Console.WriteLine("sum of the digit of the number 2^1000");
            Console.WriteLine(pds.sumPowerDigit(2,1000));
            
        }
    }
}
