using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formdersleri_ClassYapıları_
{
    internal class Araba: ArabaDetay  //kalıtım kullanımı. Böylece araba detay sınıfının özellikleri araba claasına aktarıldı

    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        private int yil;
        private string marka;

        public int YIL
        {
            get
            {
                return yil;
            }

            set
            {
                yil = value;
            }
        }

        public string MARKA
        {
            get
            {
                return marka;
            }

            set
            {
                marka = value.ToUpper(); ;
            }
        }

    }
}
