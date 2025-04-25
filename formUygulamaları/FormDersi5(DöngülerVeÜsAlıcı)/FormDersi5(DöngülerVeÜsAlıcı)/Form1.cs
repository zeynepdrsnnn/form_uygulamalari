using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormDersi5_DöngülerVeÜsAlıcı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double taban, üs, sonuc;

            taban = Convert.ToDouble(textBox1.Text);
            üs = Convert.ToDouble(textBox2.Text);

            for (double i = 0; i <= üs; i++)
            {
                sonuc = Math.Pow(taban, i);
                listBox1.Items.Add(sonuc.ToString());
            }

        }
    }
}
