using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int sonuc;

            sayi1 = Convert.ToInt32(textBox1.Text); //dönüştürme kodu () değiştirmek istediğimiz yeri yazdırıyoruz.
            sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 + sayi2;//sonuc değerini ayrıca convert etmedik sayilar int olduğu için sonuçta zaten int olacak.

            label4.Text = sonuc.ToString();//sonuc artık int olduğu için ekranda görmek için string türünde yazmamız gerekir.


            /*çarpma bölme çıkarma işlemleri içinde farklı butonlar ekleyip aynı mantıkta işlemler yapılabilir.
            kod tekrarına düşmemek için temel bir kod gösterilecek.*/
        }
    }
}
