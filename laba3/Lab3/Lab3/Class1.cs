using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
       public class MyMatrix
       {
            private double[,] matrix;


            public int Height
            {
                get { return matrix.GetLength(0); }
            }

            public int Width
            {
                get { return matrix.GetLength(1); }
            }

            public int getHeight()
            {
                return matrix.GetLength(0);
            }

            public int getWidth()
            {
                return matrix.GetLength(1);
            }

            public double this[int i1, int i2]
            {
                get
                {
                    if (Check(i1, i2))
                    {
                        return matrix[i1, i2];
                    }
                    return 0;
                }

                set
                {
                    if (Check(i1, i2))
                    {
                        matrix[i1, i2] = value;
                    }
                }
            }

            public double Get(int i1, int i2)
            {
                if (Check(i1, i2))
                {
                    return matrix[i1, i2];
                }
                return 0;
            }

            public void Set(int i1, int i2, double element)
            {
                if (Check(i1, i2))
                {
                    matrix[i1, i2] = element;
                }
            }

            public MyMatrix(double[,] array)
            {
                matrix = array;
            }

            public MyMatrix(MyMatrix previousMatrix)
            {
                matrix = previousMatrix.matrix;
            }

            public MyMatrix(double[][] array)
            {
                matrix = new double[array.Length, array[0].Length];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = array[i][j];
                    }
                }
            }

            public MyMatrix(string[] str)
            {
                string[] temp = str[0].Split(" ");
                matrix = new double[str.Length, temp.Length];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    temp = str[i].Split(" ");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = double.Parse(temp[j]);
                    }
                }
            }


            public void Print()
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            public override string ToString()
            {
                string result = "";
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        result += matrix[i, j] + " ";
                    }

                    result += "\n";
                }

                return result;
            }

            public static MyMatrix operator +(MyMatrix mat, MyMatrix mat1)
            {
                double[,] array = new double[mat.Height, mat.Width];
                for (int i = 0; i < mat.Height; i++)
                {
                    for (int j = 0; j < mat.Width; j++)
                    {
                        array[i, j] = mat.matrix[i, j] + mat1.matrix[i, j];
                    }
                }
                return new MyMatrix(array);
            }

            public static MyMatrix operator *(MyMatrix mat, MyMatrix mat1)
            {
                double[,] array = new double[mat.Height, mat1.Width];
                for (int i = 0; i < mat.Height; i++)
                {
                    for (int j = 0; j < mat1.Width; j++)
                    {
                        array[i, j] = 0;
                        for (int k = 0; k < mat.Width; k++)
                        {
                            array[i, j] += mat.matrix[i, k] * mat1.matrix[j, k];
                        }
                    }
                }
                return new MyMatrix(array);
            }

            private bool Check(int i1, int i2)
            {
                if (i1 >= 0 && i1 < Height && i2 >= 0 && i2 < Width)
                {
                    return true;
                }
                return false;
            }

            private double[,] GetTransponedArray()
            {
                double[,] array = new double[Height, Width];
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        array[j, i] = matrix[i, j];
                    }
                }
                return array;
            }

            public MyMatrix GetTransponedCopy()
            {
                return new MyMatrix(GetTransponedArray());
            }

            public void TransponeMe()
            {
                matrix = GetTransponedArray();
            }
       }
} 
