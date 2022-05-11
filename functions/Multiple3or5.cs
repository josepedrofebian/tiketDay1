using System;

namespace JosePedro_DotNet
{
    class Multiple3or5
    {
    int hasil;
        public int multiple(int angka){
            
            for(int i = 3; i < angka; i++){
                if(i % 3 == 0 || i % 5 == 0){
                  hasil += i;
                }
            }
            return hasil;
        }
    }
}
