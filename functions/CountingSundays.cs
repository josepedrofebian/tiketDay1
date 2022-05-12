using System;

namespace JosePedro_DotNet
{
    class CountingSundays{
    public int countSundays(){
    var result = 0;
        for(int year =  1901; year <= 2000; year++)
        {
            for(int month = 1;month<=12;month++)
            {
                if (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday)
                    result++;
            }
        }
        return result;
    }
    }
}