using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formdersleri_ClassYapıları_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba car = new Araba();

            car.renk = "mavi";
            car.hiz = 160;
            car.motor = 1245.16;
            car.fiyat = 50000;
            car.durum = 's';
            car.YIL = 2016;
            car.MARKA = "Renault";
            car.plaka = "34 BD 2024";
            car.sahip = "Zeynep";
            car.muayne = 2017;



            label1.Text = car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.fiyat.ToString();
            label5.Text = car.durum.ToString();
            label6.Text = car.YIL.ToString();   
            label7.Text = car.MARKA;
            label8.Text = car.plaka;
            label9.Text = car.sahip; 
            label10.Text = car.muayne.ToString();


            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
