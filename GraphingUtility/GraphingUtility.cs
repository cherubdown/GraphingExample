using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphingUtility
{
    public static class GraphingUtility
    {
        public static IEnumerable<Coordinate> Geometric(int n)
        {
            double sum = 0F;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0F / Math.Pow(2, i);
                yield return new Coordinate(i, sum);
            }
        }

        public static IEnumerable<Coordinate> SineWave(int n)
        {
            double sum = 0F;
            for (double i = 1.0; i <= n; i +=0.1)
            {
                sum += Math.Sin(i);
                yield return new Coordinate(i, sum);
            }
        }

        public struct Coordinate
        {
            private readonly double _x;
            private readonly double _y;

            public Coordinate(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double X
            {
                get { return _x; }
            }

            public double Y
            {
                get { return _y; }
            }
        }
    }
}
