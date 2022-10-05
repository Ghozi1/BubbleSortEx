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
        }

    }
}
