using System;

namespace JosePedro_DotNet
{
    class SummationOfPrimes
    {
        int sum = 0;
        bool prime = true;

        public int sumOfPrimes(int n)
        {
            if(n >= 2){
                for (int i = 2; i < n; i++)
                {
                   for (int j = 0; j < i; j++)
                   {
                       if ((i % j)==0)
                       {
                           prime = false;
                           break;
                       }
                   }
                   if(prime) {
                       sum++;
                   }
                }
            }
            return sum;
        }
    }
}
