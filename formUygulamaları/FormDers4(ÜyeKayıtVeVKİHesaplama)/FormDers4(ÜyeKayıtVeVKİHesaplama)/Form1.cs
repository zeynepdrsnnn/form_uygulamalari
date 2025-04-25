using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormDers4_ÜyeKayıtVeVKİHesaplama_
{
    public partial class Form1 : Form
    {
        //dataGridView1 içerisindeki verileri çekme, bu verilerde arama yapma
        //boy, kilo gibi tip dönüşümü yapılan yerlerde textbox boş bırakıldığında veya "asdasdd" gibi değerler girdiliğinde hata vermiyor olması lazım
        //vkı hesaplama işlemi ayrı class ve o classın içindeki metot ile yapılması gerekiyor


       
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";

        }

       
           
           

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox5.Text) ||
               string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurun");
            }

            if (!IsTextOnly(textBox2.Text) || !IsTextOnly(textBox3.Text))
            {
                MessageBox.Show("İsim ve Soyisim alanlarına sadece harf girin.");
                return;
            }

            bool ss1 = IsNumeric("ggg");
            bool ss2 = IsNumeric("123");
            bool ss3 = IsNumeric("");



            if (!IsNumeric(textBox1.Text) || !IsNumeric(textBox4.Text) || !IsNumeric(textBox5.Text) || !IsNumeric(textBox6.Text))
            {
                MessageBox.Show("Sadece rakam kullanınız.");
                return;
            }


            if (IsNumeric(textBox5.Text) == true)
            {

            }
            else
            {
                MessageBox.Show("Sadece rakam kullanınız.");
            }

            if (!IsLong(textBox1.Text) || !IsLong(textBox4.Text))
            {
                MessageBox.Show("Üye Numarası ya da GSM bilgisi yanlış");
            }



            double boy, kilo, vkı;

            bool isBoyValid = double.TryParse(textBox5.Text, out boy);

            bool isKiloValid = double.TryParse(textBox6.Text, out kilo);


            vkı = kilo / Math.Pow(boy, 2);


            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, vkı.ToString());
            temizle();

        }

        private bool IsLong(string text)
        {
            return long.TryParse(text, out _);
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }


        private bool IsTextOnly(string text)
        {
            return text.All(char.IsLetter);
        }

    }
    
}



    

  
