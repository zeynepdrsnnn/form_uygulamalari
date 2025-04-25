using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Soru Grafiği"].Points.AddXY("Türkçe", 5);
            //point lokasyonları tutar.
            chart1.Series["Soru Grafiği"].Points.AddXY("Matematik", 3);
        }
    }
}
