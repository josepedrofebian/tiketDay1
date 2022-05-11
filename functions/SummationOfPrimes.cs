using System;

namespace JosePedro_DotNet
{
    class SummationOfPrimes
    {
        int sum = 0;
        public int sumOfPrimes(int n)
        {
            
                for (int i = 1; i < n; i++)
                {
                    int tot = 0;
                   for (int j = 1; j < n; j++)
                   {
                       if ((i % j)==0)
                       {
                           tot++;
                       }
                   }
                   if (tot == 2 && i != 1) {
                    //    Console.WriteLine("prime :"+ i);
                   sum = sum + i;
                   }

                }
            
            return sum;
        }
    }
}
