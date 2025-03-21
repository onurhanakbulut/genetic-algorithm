using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    
    public class GenetikAlgoritma
    {

        public double SeckinlikOrani { get; set; }
        public double ÇaprazlamaOrani { get; set; }
        public double MutasyonOrani { get; set; }

        private Random rnd = new Random();

        public GenetikAlgoritma(double seckinlik, double çaprazlama, double mutasyon)
        {
            SeckinlikOrani = seckinlik;
            ÇaprazlamaOrani = çaprazlama;
            MutasyonOrani = mutasyon;
        }

        public Populasyon SeckinPopulasyon(Populasyon pop)
        {
            int SeckinSayisi = (int)(pop.Degiskenler.Count * SeckinlikOrani);

            var yeniPop = new Populasyon(0, rnd);
            var seckinler = pop.Degiskenler.OrderByDescending(i => i.Fitness).Take(SeckinSayisi).ToList();
            yeniPop.Degiskenler.AddRange(seckinler.Select(e => e.Kopyala()));



            while (yeniPop.Degiskenler.Count < pop.Degiskenler.Count)
            {
                Degisken cocuk;

                if (rnd.NextDouble() < ÇaprazlamaOrani)
                {
                    var p1 = Rulet(pop);
                    var p2 = Rulet(pop);
                    cocuk = Çaprazla(p1, p2);
                }
                else
                {
                    cocuk = Rulet(pop).Kopyala();
                }



                MutasyonYap(cocuk);
                yeniPop.Degiskenler.Add(cocuk);
            }


            return yeniPop;


        }




        private Degisken Rulet(Populasyon pop)
        {
            double sumFit = pop.Degiskenler.Sum(i => i.Fitness);
            double rand = rnd.NextDouble() * sumFit;
            double acc = 0;


            foreach (var dgs in pop.Degiskenler)
            {
                acc += dgs.Fitness;
                if (acc >= rand)
                {
                    return dgs;
                }
            }

            return pop.Degiskenler.Last();
        }



        private Degisken Çaprazla(Degisken p1, Degisken p2)
        {
            double alpha = rnd.NextDouble();
            double newX = alpha * p1.X + (1 - alpha) * p2.X;
            double newY = alpha * p1.Y + (1 - alpha) * p2.Y;


            return new Degisken(newX, newY);

        }


        private void MutasyonYap(Degisken dgs)
        {
            if (rnd.NextDouble() < MutasyonOrani)
            {
                dgs.X = Math.Max(-10, Math.Min(10, dgs.X + rnd.NextDouble() * 2 - 1));

            }


            if (rnd.NextDouble() < MutasyonOrani)
            {
                dgs.Y = Math.Max(-10, Math.Min(10, dgs.Y + rnd.NextDouble() * 2 - 1));
            }
        }




    }
    



}



