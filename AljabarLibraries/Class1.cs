using System;

namespace AljabarLibraries
{
    public class PersamaanKuadrat
    {
        public double[] akarPersamaanKuadrat(double[] persamaan)
        {
            double num1 = persamaan[0];
            double num2 = persamaan[1];
            double num3 = persamaan[2];
            double diskriminan = (num2 * num2) - (4 * num1 * num3);

            // tidak memiliki akar real
            if (diskriminan < 0)
            {
                return new double[] { };
            }
            // memiliki akar real
            else if (diskriminan == 0)
            {
                double x = -num2 / (2 * num1);
                return new double[] { x };
            }
            else
            {
                // Persamaan memiliki dua akar real
                double x1 = (-num2 + Math.Sqrt(diskriminan)) / (2 * num1);
                double x2 = (-num2 - Math.Sqrt(diskriminan)) / (2 * num1);
                return new double[] { x1, x2 };
            }
        }

        public double[] hasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double y1 = a * a;
            double y2 = 2 * a * b;
            double y3 = b * b;

            return new double[] { y1, y2, y3 };
        }
    }
}