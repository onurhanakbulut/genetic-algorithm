using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void GrafikCiz(List<double> fitnessDegerleri)
        {

            chartYakinsama.Series.Clear();
            chartYakinsama.Series.Add("Fitness"); 

            chartYakinsama.Series["Fitness"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartYakinsama.Series["Fitness"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chartYakinsama.Series["Fitness"].MarkerSize = 5; 
            chartYakinsama.Series["Fitness"].BorderWidth = 2; 
            chartYakinsama.Series["Fitness"].Color = Color.Blue; 

            for (int i = 0; i < fitnessDegerleri.Count; i++)
            {
                chartYakinsama.Series["Fitness"].Points.AddXY(i + 1, fitnessDegerleri[i]);
            }

            chartYakinsama.ChartAreas[0].AxisX.Title = "İterasyon";
            chartYakinsama.ChartAreas[0].AxisY.Title = "Fitness Değeri";

            chartYakinsama.Series["Fitness"].BorderWidth = 3;

            chartYakinsama.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartYakinsama.ChartAreas[0].AxisY.IntervalAutoMode =
                System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int popBoyut = int.Parse(txtPop.Text);
            int jenerasyon = int.Parse(txtGen.Text);
            double seckinlik = double.Parse(txtElite.Text);
            double caprazlama = double.Parse(txtCross.Text);
            double mutasyon = double.Parse(txtMut.Text);



            GenetikAlgoritma ga = new GenetikAlgoritma(seckinlik, caprazlama, mutasyon);
            Populasyon pop = new Populasyon(popBoyut, new Random());




            List<double> fitnessDegerleri = new List<double> ();


            for (int i = 0; i<jenerasyon; i++)
            {
                pop = ga.SeckinPopulasyon(pop);



                fitnessDegerleri.Add(pop.EniyiDegisken().Fitness);
            }


            Degisken enIyi = pop.EniyiDegisken();


            lblSonuc.Text = $"En iyi çözüm:\nX = {enIyi.X:F4}, Y = {enIyi.Y:F4}\n" +
                    $"Amaç Fonksiyonu = {enIyi.Amac():F4}";





            GrafikCiz(fitnessDegerleri);



        }

        private void txtPop_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPop_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPop.KeyPress += new KeyPressEventHandler(txtPop_KeyPress);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(",") || (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txtGen_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtGen.KeyPress += new KeyPressEventHandler(txtGen_KeyPress);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(",") || (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtElite_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCross_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtMut_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
