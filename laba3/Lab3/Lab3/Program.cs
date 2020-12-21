using System;

namespace Lab3
{
    class Program
    {
        static void MatrixGeneration(ref double [,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = rnd.Next(0, 9);
                }
            }
        }
        static void Main(string[] args)
        {
            double[,] matrix = new double[9,9];
            double[,] matrix2 = new double[9, 9];

            MatrixGeneration(ref matrix);
            MatrixGeneration(ref matrix2);
            MyMatrix Mat = new MyMatrix(matrix);
            MyMatrix Mat2 = new MyMatrix(matrix2);
            MyMatrix Mat3 = Mat*Mat2;
            MyMatrix Mat4 = Mat + Mat2;
            Console.WriteLine("Перша матриця:");
            Mat.Print();
            Console.WriteLine("Друга матриця");
            Mat2.Print();
            Console.WriteLine("Помножена Матриця");
            Mat3.Print();
            Console.WriteLine("Додана матриця");
            Mat4.Print();
            Console.WriteLine("GetTransponedCopy матриця");
            Mat.GetTransponedCopy();
            Mat.Print();
            Console.WriteLine("TransponeMe матриця");
            Mat.TransponeMe();
            Mat.Print();







        }
    }
}
