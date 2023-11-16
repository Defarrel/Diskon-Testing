namespace Diskon
{
    using System;

    public class Program
    {

        public static double HitungDiskon(int kuantitasProduk)
        {
            if (kuantitasProduk < 20)
                return 0.02;
            else if (kuantitasProduk < 40)
                return 0.04;
            else if (kuantitasProduk < 60)
                return 0.06;
            else if (kuantitasProduk < 80)
                return 0.08;
            else if (kuantitasProduk < 100)
                return 0.10;
            else
                return 0.20;
        }

        public static void TampilkanDiskon(double diskon)
        {
            Console.WriteLine($"Diskon yang Anda dapatkan: {diskon * 100}%");
        }

        public static void Main()
        {
            double hargaProduk = 0; // Inisialisasi dengan nilai default
            bool hargaValid = false;

            while (!hargaValid)
            {
                Console.WriteLine("Masukkan harga produk per unit: ");
                if (double.TryParse(Console.ReadLine(), out hargaProduk))
                {
                    hargaValid = true;
                }
                else
                {
                    Console.WriteLine("Harga produk tidak valid. Harap masukkan angka.");
                }
            }

            int kuantitasProduk = 0; // Inisialisamsi dengan nilai default
            bool kuantitasValid = false;

            while (!kuantitasValid)
            {
                Console.WriteLine("Masukkan kuantitas produk: ");
                if (int.TryParse(Console.ReadLine(), out kuantitasProduk))
                {
                    kuantitasValid = true;
                }
                else
                {
                    Console.WriteLine("Kuantitas produk tidak valid. Harap masukkan angka.");
                }
            }

            // Hitung diskon
            double diskon = HitungDiskon(kuantitasProduk);

            // Tampilkan diskon
            TampilkanDiskon(diskon);

            // Hitung total harga setelah diskon
            double totalHarga = hargaProduk * kuantitasProduk * (1 - diskon);

            Console.WriteLine($"Total Harga: {totalHarga}");
        }
    }

}