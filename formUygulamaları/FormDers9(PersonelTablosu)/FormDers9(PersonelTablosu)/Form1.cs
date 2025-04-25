using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// HATA VAR 4 4 9 OLUYOR!
namespace FormDers9_PersonelTablosu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R6FT69Q\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        void temizle()
        {
            textId.Clear();
            textAd.Clear();
            textSoyad.Clear();
            textMeslek.Clear();
            comboŞehir.Text = " ";
            maskedMaas.Clear();
            textMeslek.Clear(); 
            Btnevli.Checked = false;
            BtnBekar.Checked = false;
            textAd.Focus();//temizleme bittikten sonra imleci tekrar ad textBox'ından başlatır.
        
        }

        void listele()
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutekle = new SqlCommand(" insert into Tbl_Personel(PersonelAd,PersonelSoyad,PersonelŞehir,PersonelMaaş,PersonelMeslek,PersonelDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            if (string.IsNullOrWhiteSpace(textAd.Text) ||
              string.IsNullOrWhiteSpace(textSoyad.Text) ||
              string.IsNullOrWhiteSpace(comboŞehir.Text) ||
              string.IsNullOrWhiteSpace(maskedMaas.Text) ||
              string.IsNullOrWhiteSpace(textMeslek.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurun");
                return;
            }


            if (!IsTextOnly(textAd.Text) || !IsTextOnly(textSoyad.Text) || !IsTextOnly(comboŞehir.Text) || !IsTextOnly(textMeslek.Text))
            {
                MessageBox.Show("Yalnızca Harf Kullanınız.");
                return;
            }

           
            komutekle.Parameters.AddWithValue("@p1", textAd.Text);
            komutekle.Parameters.AddWithValue("@p2", textSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", comboŞehir.Text);
            komutekle.Parameters.AddWithValue("@p4", maskedMaas.Text);
            komutekle.Parameters.AddWithValue("@p5", textMeslek.Text);
            komutekle.Parameters.AddWithValue("@p6", label8.Text);


            komutekle.ExecuteNonQuery();//SQL komutlarını(delete insert vs.) çalıştırmak için kullanılır.

            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi!");

            temizle();
            listele();
           
        }

        private bool IsTextOnly(string text)
        {
            return text.All(char.IsLetter);
        }

        private void Btnevli_CheckedChanged(object sender, EventArgs e)
        {
            if (Btnevli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void BtnBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnBekar.Checked == true)
            {
                label8.Text = "False";
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;//tıkladığımız hücrenin satırını seçilene atadık.

            textId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboŞehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                Btnevli.Checked = true; 
            }

            if(label8.Text == "False")
            {
                BtnBekar.Checked = true;
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where PersonelID= @k1", baglanti);

            if (string.IsNullOrWhiteSpace(textAd.Text) ||
              string.IsNullOrWhiteSpace(textSoyad.Text) ||
              string.IsNullOrWhiteSpace(comboŞehir.Text) ||
              string.IsNullOrWhiteSpace(maskedMaas.Text) ||
              string.IsNullOrWhiteSpace(textMeslek.Text))
            {
                MessageBox.Show("Bir Alan Seçiniz!");
                return;
            }
            

            komutsil.Parameters.AddWithValue("@k1", textId.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi;");
            temizle();
            listele();
     
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            if (!IsTextOnly(textAd.Text) || !IsTextOnly(textSoyad.Text) || !IsTextOnly(comboŞehir.Text) || !IsTextOnly(textMeslek.Text))
            {
                MessageBox.Show("Yalnızca Harf Kullanınız.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textAd.Text) ||
             string.IsNullOrWhiteSpace(textSoyad.Text) ||
             string.IsNullOrWhiteSpace(comboŞehir.Text) ||
             string.IsNullOrWhiteSpace(maskedMaas.Text) ||
             string.IsNullOrWhiteSpace(textMeslek.Text))
            {
                MessageBox.Show("Güncellemek İçin Bir Alan Seçiniz!");
                return;
            }


            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Personel Set PersonelAd=@a1,PersonelSoyad=@a2,PersonelŞehir=@a3,PersonelMaaş=@a4,PersonelMeslek=@a5,PersonelDurum=@a6 WHERE PersonelId=@a7 ", baglanti);

            komutgüncelle.Parameters.AddWithValue("@a1", textAd.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", textSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", comboŞehir.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", maskedMaas.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", textMeslek.Text);
            komutgüncelle.Parameters.AddWithValue("@a6", label8.Text);
            komutgüncelle.Parameters.AddWithValue("@a7", textId.Text);

            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();

            temizle();
            listele();

            MessageBox.Show("Kayıt Güncellendi");
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Form2 yeniform= new Form2();
            yeniform.Show();
        }
    }
}