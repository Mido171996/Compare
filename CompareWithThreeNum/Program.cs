using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareWithThreeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //مقارنة بين ثلاثة اعداد مختلفة 
            //compare with 3 numbers
            int num1, num2, num3, resutl1,result2;
            num1 = 10; num2 = 12; num3 = 0;
            resutl1 = num1>num2?num1:num2;
            result2 = resutl1 > num3 ? resutl1 : num3;
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
