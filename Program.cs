using System;

namespace Jane020622
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas PBO");
            Console.WriteLine("Domain: Hewan");
            Console.WriteLine("\t");

            Label_Perulangan:
            Console.WriteLine(" Pilih Jenis Hewan Yang Akan Dijadikan Objek [1-3]");
            Console.WriteLine(" 1. Anjing");
            Console.WriteLine(" 2. Kucing");
            Console.WriteLine(" 3. Kuda");
            Console.WriteLine(" 4. Tikus");
            Console.Write(" Jawab: ");
            string pilihan = Console.ReadLine();

            Console.WriteLine();
            Console.Write(" Masukan Nama Hewan : ");
            string nama = Console.ReadLine();
            Console.Write(" Masukan Umur Hewan : ");
            int umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            buatObjek(pilihan, nama, umur);

            Console.WriteLine();
            Console.Write(" Apakah Anda Ingin Membuat Objek Lain [Y/N]: ");
            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine(" -------------------------------------------- ");
                Console.WriteLine();
                goto Label_Perulangan;
            }
            Console.ReadKey();
        }

        public static void buatObjek(string pilihan, string nama, int umur)
        {
            if (pilihan == "1")
            {
                Console.WriteLine(" Anda Akan Menciptakan Objek Anjing");
                Anjing hewan1 = new Anjing();
                hewan1.Nama = nama;
                hewan1.Umur = umur;

                Console.WriteLine(" Nama Anjing : {0}",hewan1.Nama);
                Console.WriteLine(" Umur Anjing : {0} tahun", hewan1.Umur);
                Console.WriteLine(" Berikut ini adalah aktifitas dari {0}: ", hewan1.Nama);
                hewan1.Berjalan();
                hewan1.Makan();
                hewan1.Berlari();
            }
            else if (pilihan == "2")
            {
                Console.WriteLine(" Anda Akan Menciptakan Objek Kucing");
                
                Kucing hewan1 = new Kucing();
                hewan1.Nama = nama;
                hewan1.Umur = umur;

                Console.WriteLine(" Nama Kucing : {0}", hewan1.Nama);
                Console.WriteLine(" Umur Kucing : {0} tahun", hewan1.Umur);
                Console.WriteLine(" Berikut ini adalah aktifitas dari {0}:" , hewan1.Nama);
                hewan1.Berjalan();
                hewan1.Makan();
                hewan1.Berlari();
            }
            else if (pilihan == "3")
            {
                Console.WriteLine(" Anda Akan Menciptakan Objek Kuda");
                Kuda hewan1 = new Kuda();
                hewan1.Nama = nama;
                hewan1.Umur = umur;

                Console.WriteLine(" Nama Kuda : {0}", hewan1.Nama);
                Console.WriteLine(" Umur Kuda : {0} tahun", hewan1.Umur);
                Console.WriteLine(" Berikut ini adalah aktifitas dari {0}:", hewan1.Nama);
                hewan1.Berjalan();
                hewan1.Makan();
                hewan1.Berlari();
            }
            else if (pilihan == "4")
            {
                Console.WriteLine(" Anda Akan Menciptakan Objek Tikus");
                Tikus hewan1 = new Tikus();
                hewan1.Nama = nama;
                hewan1.Umur = umur;

                Console.WriteLine(" Nama Tikus : {0}", hewan1.Nama);
                Console.WriteLine(" Umur Tikus : {0} tahun", hewan1.Umur);
                Console.WriteLine(" Berikut ini adalah aktifitas dari {0}:", hewan1.Nama);
                hewan1.Berjalan();
                hewan1.Makan();
                hewan1.Berlari();
            }
        }
    } 
}
