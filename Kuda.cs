using System;

namespace Jane020622
{
    class Kuda : Hewan
    {
        public Kuda()
        {
            TempatKesukaan = "Hutan";
        }
        public override void Berlari()
        {

            Console.WriteLine("\t{0} berlari di {1} yang luas", Nama, TempatKesukaan);
        }
    }
}
