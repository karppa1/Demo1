using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ArrayCalcs
    {
        public static double Sum(double[] taulukko)
        {
            double sum = 0;
            foreach (double data in taulukko)
            {
                sum += data;
            }

            return sum;
        }

        public static double Avg(double[] taulukko)
        {
            double avg = 0;
            avg =  Sum(taulukko) / taulukko.Length;

            return avg;
        }

        public static double Min(double[] taulukko)
        {
            double min = 0;
            foreach (double data in taulukko)
            {
                if (min > data) min = data;
            }

            return min;
        }

        public static double Max(double[] taulukko)
        {
            double max = 0;
            foreach (double data in taulukko)
            {
                if (max < data) max = data;
            }

            return max;
        }
    }
}
