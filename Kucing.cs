using System;

namespace Jane020622
{
    class Kucing : Hewan
    {
        public Kucing()
        {
            TempatKesukaan = "Rumah";
        }
        public override void Berlari()
        {
            Console.WriteLine("\t{0} berlari di dalam {1}", Nama, TempatKesukaan);
        }
    }
}
