using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Degisken
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Degisken(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Amac()
        {

            double pi = Math.PI;
            return Math.Pow(Math.Sin(3 * pi * X), 2) +
               Math.Pow(X - 1, 2) * (1 + Math.Pow(Math.Sin(3 * pi * Y), 2)) +
               Math.Pow(Y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * pi * Y), 2));

        }


        public Degisken Kopyala()
        {
            return new Degisken(X, Y);
        }


        public double Fitness
        {
            get
            {
                return 1 / (1 + Math.Abs(Amac()));
            }
        }
    }
}
