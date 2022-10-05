using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortEx
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variable int untuk menyimpan banyaknya data pada array 
        private int n;

        // Fungsi /  methood untuk menerima masukan     
        public void read()
        {
            // Menerima angka untuk mementukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya element pada array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 element. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("    Masukkan Element Array   ");
            Console.WriteLine("-----------------------------");

            // Pengguna memasukkan element array 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i+ 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }


        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //For n-1 passes
            {
                // Pada pass i, bandingkan n-i element pertama dengan elemen selanjutnya 
                for (int j =0; j < n; j++)
                {
                    if (a[j] > a[j+ 1]) // Jika elemen tidak diatur dalam urutan yang benar 
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        public void main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima element array 
            myList.read();

            // Pemanggilan fungsi untuk mengurutkan array 
            myList.BubbleSortArray();

            // Pemanggilan fungsi untuk menampilkan array yang tersusun 
            myList.display();

            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
