using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Populasyon
    {
        public List<Degisken> Degiskenler { get; set; } = new List<Degisken>();

        public Populasyon(int size, Random rnd)
        {
            for (int i = 0; i < size; i++)
            {

                double randomX = rnd.NextDouble() * 20 - 10;  
                double randomY = rnd.NextDouble() * 20 - 10;  
                Degiskenler.Add(new Degisken(randomX, randomY));

            }
        }


        public Degisken EniyiDegisken()
        {
            return Degiskenler.OrderByDescending(i => i.Fitness).First();
        }
    }
}
