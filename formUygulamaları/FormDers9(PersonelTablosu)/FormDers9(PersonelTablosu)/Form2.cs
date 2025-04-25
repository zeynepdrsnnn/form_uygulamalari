using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormDers9_PersonelTablosu_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R6FT69Q\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        public object Lbl_ToplamÇalışanPersonel { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();

                SqlCommand komut1 = new SqlCommand("select count(*) From Tbl_Personel", baglanti);

                SqlDataReader dataread1 = komut1.ExecuteReader();

                while (dataread1.Read())
                {
                    label5.Text = dataread1[0].ToString();//dataread[0]indeksten gelen değeri yazar
                }

                dataread1.Close();


                SqlCommand komut2 = new SqlCommand("select count(*) From Tbl_Personel WHERE PersonelDurum=0", baglanti);

                SqlDataReader dataread2 = komut2.ExecuteReader();

                while (dataread2.Read())
                {
                    label7.Text = dataread2[0].ToString();
                }
                dataread2.Close();


                SqlCommand komut3 = new SqlCommand("select count(*) From Tbl_Personel WHERE PersonelDurum=1", baglanti);

                SqlDataReader dataread3 = komut3.ExecuteReader();

                while (dataread3.Read())
                {
                    label6.Text = dataread3[0].ToString();
                }
                dataread3.Close();


                SqlCommand komut4 = new SqlCommand("select count(distinct(PersonelŞehir)) From Tbl_Personel", baglanti);

                SqlDataReader dataread4 = komut4.ExecuteReader();

                while (dataread4.Read())
                {
                    label13.Text = dataread4[0].ToString();
                }
                dataread4.Close();


                SqlCommand komut5 = new SqlCommand("select sum((PersonelMaaş)) From Tbl_Personel", baglanti);

                SqlDataReader dataread5 = komut5.ExecuteReader();

                while (dataread5.Read())
                {
                    label8.Text = dataread5[0].ToString();
                }
                dataread5.Close();


                SqlCommand komut6 = new SqlCommand("select Avg((PersonelMaaş)) From Tbl_Personel", baglanti);

                SqlDataReader dataread6 = komut6.ExecuteReader();

                while (dataread6.Read())
                {
                    label12.Text = dataread6[0].ToString();
                }

                dataread6.Close();
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}

