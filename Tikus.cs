using System;

namespace Jane020622
{
    class Tikus: Hewan
    {
        public Tikus()
        {
            TempatKesukaan = "Tempat Sampah";
        }
        public override void Berlari()
        {

            Console.WriteLine("\t{0} berlari di {1} yang luas", Nama, TempatKesukaan);
        }
    }
}
