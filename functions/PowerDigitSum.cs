using System;
using System.Numerics;
namespace JosePedro_DotNet
{
    class PowerDigitSum
    {
        public int sumPowerDigit(int angka, int pangkat){
            
           int result = 0;
 
            BigInteger number = BigInteger.Pow(angka, pangkat);
 
            while (number > 0) {
            result += (int) (number % 10);
            number /= 10;
            }
            return result;
        }
    }
}
