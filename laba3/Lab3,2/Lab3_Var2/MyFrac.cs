using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Var2
{
    public class MyFrac
    {
        private long nom, denom;
        public MyFrac(long nom_, long denom_)
        {
            void Simplify(ref long nom, ref long denom)
            {
                if (denom < 0)
                {
                    denom = Math.Abs(denom);
                    nom *= -1;
                }
                long gcdResult = Gcd(nom, denom);
                nom /= gcdResult;
                denom /= gcdResult;
            }

            long Gcd(long nom, long denom)
            {
                var x = Math.Abs(nom);
                var y = Math.Abs(denom);
                long m;

                if (x > y)
                    m = y;
                else
                    m = x;

                for (long i = m; i >= 1; i--)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        return i;
                    }
                }

                return 1;
            }

            nom = nom_;
            denom = denom_;
            Simplify(ref nom, ref denom);
            return;
        }
        public override string ToString()
        {

            return $"{nom.ToString()}/{denom.ToString()}";
        }

       public static string ToStringWithIntegerPart(MyFrac f)
        {
            var intPart = f.nom / f.denom;
            f.nom -= f.denom * intPart;
            return $"({intPart.ToString()}+{f.ToString()})";
        }
        public static double DoubleValue(MyFrac f)
        {
            return f.nom / (double)f.denom;
        }
        public static MyFrac Plus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom - f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
        }
        public static MyFrac GetRGR113LeftSum(int n)
        {
            MyFrac res = new MyFrac(1, 3);
            for (int i = 2; i <= n; i++)
            {
                res = Plus(res, new MyFrac(1, (2 * i - 1) * (2 * i + 1)));
            }
            return res;
        }
        public static MyFrac GetRGR115LeftSum(int n)
        {
            MyFrac res = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                res = Multiply(res, Minus(new MyFrac(1, 1), new MyFrac(1, i * i)));
            }
            return res;
        }
    }
}
