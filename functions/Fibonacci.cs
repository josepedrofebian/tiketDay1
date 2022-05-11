using System;

namespace JosePedro_DotNet
{
    class Fibonacci
    {
        int curr = 0, prev = 1 , next = 0, sum = 0;
        public int sumFibonacci(int n){ 
        for(int i = 1;i<n; i++){
            next = curr + prev;
            prev = curr;
            curr = next;

            if(next >= 4000000){
              break;
                }
            if(next % 2 == 0){
                sum+=next;
                }
            }
        return sum;
        }
    }
}