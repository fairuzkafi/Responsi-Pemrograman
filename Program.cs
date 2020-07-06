using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//FAIRUZ KAFI 19.11.2623

namespace ProjectProduk
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            produk.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.HargaBeli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.HargaJual = double.Parse(Console.ReadLine());
            daftarProduk.Add(produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, erase = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string code = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.KodeProduk == code)
                {
                    erase = no;
                }
            }
            if (erase != -1)
            {
                daftarProduk.RemoveAt(erase);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int Urutanno = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                Urutanno++;
                Console.WriteLine("{0}. Kode Produk: {1}, Nama Produk: {2}, Harga Beli: {3}, Harga Jual: {4}", Urutanno, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
            }
            if (Urutanno < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
