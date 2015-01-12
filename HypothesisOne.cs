using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsHypoyhesis
{
    class HypothesisOne
    {
        public static double LeftEndPoint(double s, double value, double leftend)
        {
            return (s - 1) * (value) * (value) / (leftend);

        }

        public static double RightEndPoint(double s, double value, double rightend)
        {
            return (s - 1) * (value) * (value) / (rightend);

        }

        public static double ConfiLeftEndPoint(double s, double value, double leftend)
        {
            return Math.Sqrt((s - 1) * (value) * (value) / (leftend));
        }

        public static double ConfiRightEndPoint(double s, double value, double rightend)
        {
            return Math.Sqrt((s - 1) * (value) * (value) / (rightend));
        }

        public static double P_Test(double value, double mean, double sample, double n)
        {
            return (value - mean) / (sample / Math.Sqrt(n));
        }

        public static double T_Test(double value, double mean, double sample, double n)
        {
            return (value - mean) / (sample / Math.Sqrt(n));
        }

        public static double ProportionTest(double value1, double value2, double p, double q, double n)
        {
            return (value1 - value2) / Math.Sqrt((p * q) / n);
        }

        public static double zTest(double x, double n, double p, double q)
        {
            return (x / n - p) / Math.Sqrt(p * q / n);
        }

        public static double PopulationVarianceTest(double n, double s, double value)
        {
            return (n - 1) * (s) / value;

        }
    }
}
