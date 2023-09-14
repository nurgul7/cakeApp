﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace pastaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)//timer 1 enable true olarak değitirdik
        {
            progressBar1.Value += 10;//10 ar adım artıcak
            if (progressBar1.Value % 20 == 10)//20 ye bölümünde kalan 10 ise progresbarın değeri
            { label1.BackColor = Color.Peru; }//label1 in arkaplan rengini değiştirir
            if (progressBar1.Value % 20 == 0)//20 ye bölümünden kalan 0 ise progresbarın değeri
            { label1.BackColor= Color.SandyBrown; }//label1 in arkaplan rengini değiştirir
            if(progressBar1.Value ==100)//progresbar ın değeri 100 olunca
            { timer1.Stop();//timer1 i durdur
                timer2.Start();//timer2 yi başlat
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 0)
            { label2.BackColor = Color.Peru; }
            if (progressBar2.Value % 10 == 5)
            { label2.BackColor = Color.SandyBrown; }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 40 == 0)
            { label3.BackColor = Color.Peru; }
            if (progressBar3.Value % 40== 20)
            { label3.BackColor = Color.SandyBrown; }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 0)
            { label4.BackColor = Color.Peru; }
            if (progressBar4.Value % 2 == 1)
            { label4.BackColor = Color.SandyBrown; }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("PASTANIZ HAZIR");
            }
           

        }
    }
}
