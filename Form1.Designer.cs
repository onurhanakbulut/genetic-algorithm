namespace GeneticAlgorithm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtMut = new System.Windows.Forms.TextBox();
            this.txtCross = new System.Windows.Forms.TextBox();
            this.txtElite = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.chartYakinsama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinsama)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Populasyon Boyutu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mutasyon Oranı";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çaprazlama Oranı";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seçkinlik Oranı";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenerasyon Sayısı";
            // 
            // txtPop
            // 
            this.txtPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPop.Location = new System.Drawing.Point(265, 67);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(70, 30);
            this.txtPop.TabIndex = 7;
            this.txtPop.TextChanged += new System.EventHandler(this.txtPop_TextChanged);
            this.txtPop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPop_KeyPress);
            // 
            // txtMut
            // 
            this.txtMut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMut.Location = new System.Drawing.Point(265, 247);
            this.txtMut.Name = "txtMut";
            this.txtMut.Size = new System.Drawing.Size(70, 30);
            this.txtMut.TabIndex = 8;
            this.txtMut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMut_KeyPress);
            // 
            // txtCross
            // 
            this.txtCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCross.Location = new System.Drawing.Point(265, 202);
            this.txtCross.Name = "txtCross";
            this.txtCross.Size = new System.Drawing.Size(70, 30);
            this.txtCross.TabIndex = 9;
            this.txtCross.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCross_KeyPress);
            // 
            // txtElite
            // 
            this.txtElite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElite.Location = new System.Drawing.Point(265, 155);
            this.txtElite.Name = "txtElite";
            this.txtElite.Size = new System.Drawing.Size(70, 30);
            this.txtElite.TabIndex = 10;
            this.txtElite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElite_KeyPress);
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGen.Location = new System.Drawing.Point(265, 111);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(70, 30);
            this.txtGen.TabIndex = 11;
            this.txtGen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGen_KeyPress);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(995, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(194, 125);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Çalıştır";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 347);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(87, 27);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "SONUÇ ";
            // 
            // chartYakinsama
            // 
            chartArea3.Name = "ChartArea1";
            this.chartYakinsama.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartYakinsama.Legends.Add(legend3);
            this.chartYakinsama.Location = new System.Drawing.Point(344, 310);
            this.chartYakinsama.Name = "chartYakinsama";
            this.chartYakinsama.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Fitness";
            series3.YValuesPerPoint = 2;
            this.chartYakinsama.Series.Add(series3);
            this.chartYakinsama.Size = new System.Drawing.Size(845, 400);
            this.chartYakinsama.TabIndex = 14;
            this.chartYakinsama.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "30 - 100 arası ideal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "0.01 - 0.1 arası ideal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "0.6 - 0.95 arası ideal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "0.02 - 0.1 arası ideal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "100-1000 arası ideal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 722);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartYakinsama);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtElite);
            this.Controls.Add(this.txtCross);
            this.Controls.Add(this.txtMut);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Genetik Algoritma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinsama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtMut;
        private System.Windows.Forms.TextBox txtCross;
        private System.Windows.Forms.TextBox txtElite;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYakinsama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

