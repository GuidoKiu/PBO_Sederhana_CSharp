using System;

namespace Jane020622
{
    class Anjing : Hewan
    {
        public Anjing()
        {
            TempatKesukaan = "Taman";
        }
        public override void Berlari()
        {
            Console.WriteLine("\t{0} berlari di {1}", Nama, TempatKesukaan);
        }
    }
}
