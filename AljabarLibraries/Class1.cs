using System;

namespace AljabarLibraries
{
    public class AljabarLibrary
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double d = b * b - 4 * a * c;
            double sqrt_val = Math.Sqrt(Math.Abs(d));

            if (d > 0)
            {
                return new double[] { (-b + sqrt_val) / (2 * a), (-b - sqrt_val) / (2 * a) };
            }
            else if (d == 0)
            {
                return new double[] { -b / (2 * a) };
            }
            else
            {
                return new double[] { };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            return new double[] { a * a, 2 * a * b, b * b };
        }
    }
}
