using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jane020622
{
    abstract class Hewan
    {
        private string _nama;
        private int _umur;
        private string _tempatKesukaan;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public int Umur
        {
            get { return _umur; }
            set
            {
                if (value > 0)
                {
                    _umur = value;
                }
                else
                {
                    _umur = 1;
                }
            }
        }

        public string TempatKesukaan
        {
            get { return _tempatKesukaan; }
            set
            {
                _tempatKesukaan = value;
            }
        }

        public void Makan()
        {
            Console.WriteLine("\t{0} sedang makan di {1}", Nama, TempatKesukaan);
        }
        public void Berjalan()
        {
            Console.WriteLine("\t{0} sedang berjalan di {1}", Nama, TempatKesukaan);
        }
        public virtual void Berlari()
        {
            Console.WriteLine("\tHewan berlari");
        }
    }
}
