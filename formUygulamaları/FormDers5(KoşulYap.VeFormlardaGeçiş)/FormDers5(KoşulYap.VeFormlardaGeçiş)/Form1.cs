using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers5_KoşulYap.VeFormlardaGeçiş_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456789")
            {
                Form2 yeniform = new Form2();//veriler doğruysa formlar arasında geçiş yapılaca
                yeniform.Show();//yeni form gösterilecek
                this.Hide();//form1'i kapatacak.temel kod


                yeniform.label2.Text = textBox1.Text;//bağlantıyı kullanarak label2'nin textini değiştirir. Burada hata verecek başka bir form üzerinden apılacak değişikliğe kapalı.
                                                     //modifiers kısmından private kısmını public olarak değiştirdiğimizden hata ortadan kalkar.
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }

            //Burada ilk başta ekrana form1 gelecek veri girildikten sonra ekrana form2 çıkacak.

        }
    }
}
