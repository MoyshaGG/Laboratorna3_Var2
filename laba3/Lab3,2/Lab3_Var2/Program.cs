using System;

namespace Lab3_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFrac drib1 = new MyFrac(18, -8);
            MyFrac drib2 = new MyFrac(4, 8);
            int n = 5;
            Console.WriteLine($"Дрiб1: " + drib1);
            Console.WriteLine("Дрiб2: " + drib2 );
            Console.WriteLine("Цiла частина дробу = " + MyFrac.ToStringWithIntegerPart(drib1));
            Console.WriteLine("Не цiла частина дробу = " + MyFrac.DoubleValue(drib1));
            Console.WriteLine("Додавання = " + MyFrac.Plus(drib1, drib2));
            Console.WriteLine("Вiднiмання = " + MyFrac.Minus(drib1, drib2));
            Console.WriteLine("Множення = " + MyFrac.Multiply(drib1, drib2));
            Console.WriteLine("GetRGR113LeftSum (5)" + MyFrac.GetRGR113LeftSum(n));
            Console.ReadKey();
        } 
    }
}